using System.Numerics;

namespace Core
{
    public class Physics
    {
        public static void UpdatePosition(Particles _p, float dt)
        {
            _p.Position += _p.Velocity * dt;
        }

        public static void ApplyForce(Particles _p, Vector2 force, float dt)
        {
            _p.Velocity += force*(dt/_p.Mass);
        }
    }
}
