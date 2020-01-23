using System;
using System.Drawing;

namespace Asteriods
{
    abstract class BaseObject
    {
        protected Point Pos;
        protected Point Dir;
        protected Size Size;
        public BaseObject (Point pos, Point dir, Size size)
        {
            if (dir.X == 0 && dir.Y == 0)
            {
                Random rnd = new Random();
                int speed = rnd.Next(1, 5);
                dir.X = speed;
                dir.Y = speed;
            }
            this.Pos = pos;
            this.Dir = dir;
            this.Size = size;
        }
        public abstract void Draw();
        public virtual void Update()
        {
            Pos.X = Pos.X + Dir.X;
            Pos.Y = Pos.Y + Dir.Y;
            if (Pos.X < 0) Dir.X = -Dir.X;
            if (Pos.X > Game.Width) Dir.X = -Dir.X;
            if (Pos.Y < 0) Dir.Y = -Dir.Y;
            if (Pos.Y > Game.Height) Dir.Y = -Dir.Y;
        }
    }
}
