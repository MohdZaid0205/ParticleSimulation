using System.Numerics;

namespace Core
{
    public class Collision
    {
        public static bool CheckCollision(Particles _p1, Particles _p2)
        {
            return _p1.Radius + _p2.Radius >= Vector2.Distance( _p1.Position, _p2.Position );
        }

        public static void ResolveCollision(Particles _p1, Particles _p2)
        {
            Vector2 normal = _p2.Position - _p1.Position;
            normal = Vector2.Normalize(normal);

            Vector2 tangent = new Vector2(-normal.Y, normal.X);

            float v1n = Vector2.Dot(_p1.Velocity, normal);
            float v1t = Vector2.Dot(_p1.Velocity, tangent);
            float v2n = Vector2.Dot(_p2.Velocity, normal);
            float v2t = Vector2.Dot(_p2.Velocity, tangent);

            float v1tPrime = v1t;
            float v2tPrime = v2t;

            float v1nPrime = (v1n * (_p1.Mass - _p2.Mass) + 2 * _p2.Mass * v2n) / (_p1.Mass + _p2.Mass);
            float v2nPrime = (v2n * (_p2.Mass - _p1.Mass) + 2 * _p1.Mass * v1n) / (_p1.Mass + _p2.Mass);

            Vector2 v1nPrimeVec = v1nPrime * normal;
            Vector2 v1tPrimeVec = v1tPrime * tangent;
            Vector2 v2nPrimeVec = v2nPrime * normal;
            Vector2 v2tPrimeVec = v2tPrime * tangent;

            _p1.Velocity = v1nPrimeVec + v1tPrimeVec;
            _p2.Velocity = v2nPrimeVec + v2tPrimeVec;
        }
    }
}
