using System.Numerics;
using System.Windows.Media;

namespace Core
{
    public class Particles
    {
        public Particles(float Mass, float radius, Vector2 position, Vector2 velocity, SolidColorBrush colorBrush)
        {
            this.Mass = Mass;
            this.Radius = radius;
            this.Position = position;
            this.Velocity = velocity;
            this.ColorBrush = colorBrush;
        }

        public float Mass { get; set; }
        public float Radius { get; set; }
        public Vector2 Position { get; set; }
        public Vector2 Velocity { get; set; }
        public SolidColorBrush ColorBrush { get; set; }
    }
}
