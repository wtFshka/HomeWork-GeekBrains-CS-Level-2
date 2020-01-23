using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteriods
{
    class Earth : BaseObject
    {
        public Earth(Point pos, Point dir, Size size) : base(pos, dir, size)
        {
        }
        public override void Draw()
        {
            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X, Pos.Y), new Point(Pos.X + 1, Pos.Y));
            Game.Buffer.Graphics.DrawLine(Pens.Green, new Point(Pos.X + 2, Pos.Y), new Point(Pos.X + 3, Pos.Y));
            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X + 4, Pos.Y), new Point(Pos.X + 5, Pos.Y));
            Game.Buffer.Graphics.DrawLine(Pens.Blue, new Point(Pos.X + 6, Pos.Y), new Point(Pos.X + 7, Pos.Y));
            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X + 8, Pos.Y), new Point(Pos.X + 9, Pos.Y));

            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X - 1, Pos.Y + 1), new Point(Pos.X, Pos.Y + 1));
            Game.Buffer.Graphics.DrawLine(Pens.Green, new Point(Pos.X + 1, Pos.Y + 1), new Point(Pos.X + 2, Pos.Y + 1));
            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X + 3, Pos.Y + 1), new Point(Pos.X + 4, Pos.Y + 1));
            Game.Buffer.Graphics.DrawLine(Pens.Blue, new Point(Pos.X + 5, Pos.Y + 1), new Point(Pos.X + 6, Pos.Y + 1));
            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X + 7, Pos.Y + 1), new Point(Pos.X + 8, Pos.Y + 1));
            Game.Buffer.Graphics.DrawLine(Pens.Green, new Point(Pos.X + 9, Pos.Y + 1), new Point(Pos.X + 11, Pos.Y + 1));

            Game.Buffer.Graphics.DrawLine(Pens.Green, new Point(Pos.X - 2, Pos.Y + 2), new Point(Pos.X - 1, Pos.Y + 2));
            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X, Pos.Y + 2), new Point(Pos.X + 1, Pos.Y + 2));
            Game.Buffer.Graphics.DrawLine(Pens.Blue, new Point(Pos.X + 2, Pos.Y + 2), new Point(Pos.X + 3, Pos.Y + 2));
            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X + 4, Pos.Y + 2), new Point(Pos.X + 6, Pos.Y + 2));
            Game.Buffer.Graphics.DrawLine(Pens.Green, new Point(Pos.X + 6, Pos.Y + 2), new Point(Pos.X + 12, Pos.Y + 2));

            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X - 3, Pos.Y + 3), new Point(Pos.X - 1, Pos.Y + 3));
            Game.Buffer.Graphics.DrawLine(Pens.Blue, new Point(Pos.X, Pos.Y + 3), new Point(Pos.X + 3, Pos.Y + 3));
            Game.Buffer.Graphics.DrawLine(Pens.Green, new Point(Pos.X + 4, Pos.Y + 3), new Point(Pos.X + 13, Pos.Y + 3));

            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X - 4, Pos.Y + 4), new Point(Pos.X - 2, Pos.Y + 4));
            Game.Buffer.Graphics.DrawLine(Pens.Blue, new Point(Pos.X - 1, Pos.Y + 4), new Point(Pos.X + 2, Pos.Y + 4));
            Game.Buffer.Graphics.DrawLine(Pens.Green, new Point(Pos.X + 3, Pos.Y + 4), new Point(Pos.X + 7, Pos.Y + 4));
            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X + 8, Pos.Y + 4), new Point(Pos.X + 9, Pos.Y + 4));
            Game.Buffer.Graphics.DrawLine(Pens.Green, new Point(Pos.X + 10, Pos.Y + 4), new Point(Pos.X + 14, Pos.Y + 4));

            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X - 5, Pos.Y + 5), new Point(Pos.X - 2, Pos.Y + 5));
            Game.Buffer.Graphics.DrawLine(Pens.Blue, new Point(Pos.X - 1, Pos.Y + 5), new Point(Pos.X, Pos.Y + 5));
            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X + 1, Pos.Y + 5), new Point(Pos.X + 3, Pos.Y + 5));
            Game.Buffer.Graphics.DrawLine(Pens.Blue, new Point(Pos.X + 4, Pos.Y + 5), new Point(Pos.X + 7, Pos.Y + 5));
            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X + 8, Pos.Y + 5), new Point(Pos.X + 9, Pos.Y + 5));
            Game.Buffer.Graphics.DrawLine(Pens.Green, new Point(Pos.X + 10, Pos.Y + 5), new Point(Pos.X + 15, Pos.Y + 5));

            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X - 5, Pos.Y + 6), new Point(Pos.X - 2, Pos.Y + 6));
            Game.Buffer.Graphics.DrawLine(Pens.Blue, new Point(Pos.X - 1, Pos.Y + 6), new Point(Pos.X + 1, Pos.Y + 6));
            Game.Buffer.Graphics.DrawLine(Pens.Green, new Point(Pos.X + 2, Pos.Y + 6), new Point(Pos.X + 4, Pos.Y + 6));
            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X + 5, Pos.Y + 6), new Point(Pos.X + 9, Pos.Y + 6));
            Game.Buffer.Graphics.DrawLine(Pens.Green, new Point(Pos.X + 10, Pos.Y + 6), new Point(Pos.X + 16, Pos.Y + 6));

            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X - 6, Pos.Y + 7), new Point(Pos.X - 5, Pos.Y + 7));
            Game.Buffer.Graphics.DrawLine(Pens.Blue, new Point(Pos.X - 4, Pos.Y + 7), new Point(Pos.X - 2, Pos.Y + 7));
            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X - 1, Pos.Y + 7), new Point(Pos.X, Pos.Y + 7));
            Game.Buffer.Graphics.DrawLine(Pens.Green, new Point(Pos.X + 1, Pos.Y + 7), new Point(Pos.X+12, Pos.Y + 7));
            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X + 13, Pos.Y + 7), new Point(Pos.X+14, Pos.Y + 7));
            Game.Buffer.Graphics.DrawLine(Pens.Green, new Point(Pos.X + 15, Pos.Y + 7), new Point(Pos.X+16, Pos.Y + 7));

            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X - 7, Pos.Y + 8), new Point(Pos.X - 6, Pos.Y + 8));
            Game.Buffer.Graphics.DrawLine(Pens.Blue, new Point(Pos.X - 5, Pos.Y + 8), new Point(Pos.X - 4, Pos.Y + 8));
            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X - 3, Pos.Y + 8), new Point(Pos.X - 1, Pos.Y + 8));
            Game.Buffer.Graphics.DrawLine(Pens.Green, new Point(Pos.X, Pos.Y + 8), new Point(Pos.X + 12, Pos.Y + 8));
            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X + 13, Pos.Y + 8), new Point(Pos.X + 15, Pos.Y + 8));
            Game.Buffer.Graphics.DrawLine(Pens.Green, new Point(Pos.X + 16, Pos.Y + 8), new Point(Pos.X + 17, Pos.Y + 8));

            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X - 7, Pos.Y + 9), new Point(Pos.X - 6, Pos.Y + 9));
            Game.Buffer.Graphics.DrawLine(Pens.Blue, new Point(Pos.X - 5, Pos.Y + 9), new Point(Pos.X - 4, Pos.Y + 9));
            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X - 3, Pos.Y + 9), new Point(Pos.X - 2, Pos.Y + 9));
            Game.Buffer.Graphics.DrawLine(Pens.Green, new Point(Pos.X - 1, Pos.Y + 9), new Point(Pos.X + 13, Pos.Y + 9));
            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X + 14, Pos.Y + 9), new Point(Pos.X + 15, Pos.Y + 9));
            Game.Buffer.Graphics.DrawLine(Pens.Green, new Point(Pos.X + 16, Pos.Y + 9), new Point(Pos.X + 17, Pos.Y + 9));

            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X - 8, Pos.Y + 10), new Point(Pos.X - 6, Pos.Y + 10));
            Game.Buffer.Graphics.DrawLine(Pens.Blue, new Point(Pos.X - 5, Pos.Y + 10), new Point(Pos.X - 4, Pos.Y + 10));
            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X - 3, Pos.Y + 10), new Point(Pos.X - 2, Pos.Y + 10));
            Game.Buffer.Graphics.DrawLine(Pens.Green, new Point(Pos.X - 1, Pos.Y + 10), new Point(Pos.X + 13, Pos.Y + 10));
            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X + 14, Pos.Y + 10), new Point(Pos.X + 15, Pos.Y + 10));
            Game.Buffer.Graphics.DrawLine(Pens.Green, new Point(Pos.X + 16, Pos.Y + 10), new Point(Pos.X + 18, Pos.Y + 10));

            Game.Buffer.Graphics.DrawLine(Pens.Green, new Point(Pos.X - 8, Pos.Y + 11), new Point(Pos.X - 7, Pos.Y + 11));
            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X - 6, Pos.Y + 11), new Point(Pos.X - 5, Pos.Y + 11));
            Game.Buffer.Graphics.DrawLine(Pens.Blue, new Point(Pos.X - 4, Pos.Y + 11), new Point(Pos.X - 3, Pos.Y + 11));
            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X - 2, Pos.Y + 11), new Point(Pos.X - 1, Pos.Y + 11));
            Game.Buffer.Graphics.DrawLine(Pens.Green, new Point(Pos.X, Pos.Y + 11), new Point(Pos.X + 11, Pos.Y + 11));
            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X + 12, Pos.Y + 11), new Point(Pos.X + 16, Pos.Y + 11));
            Game.Buffer.Graphics.DrawLine(Pens.Green, new Point(Pos.X + 17, Pos.Y + 11), new Point(Pos.X + 18, Pos.Y + 11));

            Game.Buffer.Graphics.DrawLine(Pens.Green, new Point(Pos.X - 8, Pos.Y + 12), new Point(Pos.X - 7, Pos.Y + 12));
            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X - 6, Pos.Y + 12), new Point(Pos.X - 5, Pos.Y + 12));
            Game.Buffer.Graphics.DrawLine(Pens.Blue, new Point(Pos.X - 4, Pos.Y + 12), new Point(Pos.X - 3, Pos.Y + 12));
            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X - 2, Pos.Y + 12), new Point(Pos.X - 1, Pos.Y + 12));
            Game.Buffer.Graphics.DrawLine(Pens.Green, new Point(Pos.X, Pos.Y + 12), new Point(Pos.X + 13, Pos.Y + 12));
            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X + 14, Pos.Y + 12), new Point(Pos.X + 15, Pos.Y + 12));
            Game.Buffer.Graphics.DrawLine(Pens.Green, new Point(Pos.X + 16, Pos.Y + 12), new Point(Pos.X + 17, Pos.Y + 12));

            Game.Buffer.Graphics.DrawLine(Pens.Green, new Point(Pos.X - 8, Pos.Y + 13), new Point(Pos.X - 7, Pos.Y + 13));
            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X - 6, Pos.Y + 13), new Point(Pos.X - 5, Pos.Y + 13));
            Game.Buffer.Graphics.DrawLine(Pens.Blue, new Point(Pos.X - 4, Pos.Y + 13), new Point(Pos.X - 3, Pos.Y + 13));
            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X - 2, Pos.Y + 13), new Point(Pos.X - 1, Pos.Y + 13));
            Game.Buffer.Graphics.DrawLine(Pens.Green, new Point(Pos.X, Pos.Y + 13), new Point(Pos.X + 1, Pos.Y + 13));
            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X + 2, Pos.Y + 13), new Point(Pos.X + 3, Pos.Y + 13));
            Game.Buffer.Graphics.DrawLine(Pens.Green, new Point(Pos.X + 4, Pos.Y + 13), new Point(Pos.X + 11, Pos.Y + 13));
            Game.Buffer.Graphics.DrawLine(Pens.Blue, new Point(Pos.X + 12, Pos.Y + 13), new Point(Pos.X + 13, Pos.Y + 13));
            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X + 14, Pos.Y + 13), new Point(Pos.X + 15, Pos.Y + 13));
            Game.Buffer.Graphics.DrawLine(Pens.Green, new Point(Pos.X + 16, Pos.Y + 13), new Point(Pos.X + 17, Pos.Y + 13));

            Game.Buffer.Graphics.DrawLine(Pens.Green, new Point(Pos.X - 8, Pos.Y + 14), new Point(Pos.X - 6, Pos.Y + 14));
            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X - 5, Pos.Y + 14), new Point(Pos.X - 4, Pos.Y + 14));
            Game.Buffer.Graphics.DrawLine(Pens.Blue, new Point(Pos.X - 3, Pos.Y + 14), new Point(Pos.X - 2, Pos.Y + 14));
            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X - 1, Pos.Y + 14), new Point(Pos.X + 3, Pos.Y + 14));
            Game.Buffer.Graphics.DrawLine(Pens.Green, new Point(Pos.X + 4, Pos.Y + 14), new Point(Pos.X + 10, Pos.Y + 14));
            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X + 11, Pos.Y + 14), new Point(Pos.X + 12, Pos.Y + 14));
            Game.Buffer.Graphics.DrawLine(Pens.Blue, new Point(Pos.X + 13, Pos.Y + 14), new Point(Pos.X + 15, Pos.Y + 14));
            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X + 16, Pos.Y + 14), new Point(Pos.X + 17, Pos.Y + 14));

            Game.Buffer.Graphics.DrawLine(Pens.Green, new Point(Pos.X - 8, Pos.Y + 15), new Point(Pos.X - 5, Pos.Y + 15));
            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X - 4, Pos.Y + 15), new Point(Pos.X - 3, Pos.Y + 15));
            Game.Buffer.Graphics.DrawLine(Pens.Blue, new Point(Pos.X - 2, Pos.Y + 15), new Point(Pos.X + 2, Pos.Y + 15));
            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X + 3, Pos.Y + 15), new Point(Pos.X + 4, Pos.Y + 15));
            Game.Buffer.Graphics.DrawLine(Pens.Green, new Point(Pos.X + 5, Pos.Y + 15), new Point(Pos.X + 9, Pos.Y + 15));
            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X + 10, Pos.Y + 15), new Point(Pos.X + 11, Pos.Y + 15));
            Game.Buffer.Graphics.DrawLine(Pens.Blue, new Point(Pos.X + 12, Pos.Y + 15), new Point(Pos.X + 15, Pos.Y + 15));
            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X + 16, Pos.Y + 15), new Point(Pos.X + 17, Pos.Y + 15));

            Game.Buffer.Graphics.DrawLine(Pens.Green, new Point(Pos.X - 8, Pos.Y + 16), new Point(Pos.X - 5, Pos.Y + 16));
            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X - 4, Pos.Y + 16), new Point(Pos.X - 3, Pos.Y + 16));
            Game.Buffer.Graphics.DrawLine(Pens.Blue, new Point(Pos.X - 2, Pos.Y + 16), new Point(Pos.X + 2, Pos.Y + 16));
            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X + 3, Pos.Y + 16), new Point(Pos.X + 4, Pos.Y + 16));
            Game.Buffer.Graphics.DrawLine(Pens.Green, new Point(Pos.X + 5, Pos.Y + 16), new Point(Pos.X + 10, Pos.Y + 16));
            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X + 11, Pos.Y + 16), new Point(Pos.X + 12, Pos.Y + 16));
            Game.Buffer.Graphics.DrawLine(Pens.Blue, new Point(Pos.X + 13, Pos.Y + 16), new Point(Pos.X + 15, Pos.Y + 16));
            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X + 16, Pos.Y + 16), new Point(Pos.X + 17, Pos.Y + 16));

            Game.Buffer.Graphics.DrawLine(Pens.Green, new Point(Pos.X - 7, Pos.Y + 17), new Point(Pos.X - 5, Pos.Y + 17));
            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X - 4, Pos.Y + 17), new Point(Pos.X - 3, Pos.Y + 17));
            Game.Buffer.Graphics.DrawLine(Pens.Blue, new Point(Pos.X - 2, Pos.Y + 17), new Point(Pos.X + 2, Pos.Y + 17));
            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X + 3, Pos.Y + 17), new Point(Pos.X + 4, Pos.Y + 17));
            Game.Buffer.Graphics.DrawLine(Pens.Green, new Point(Pos.X + 5, Pos.Y + 17), new Point(Pos.X + 10, Pos.Y + 17));
            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X + 11, Pos.Y + 17), new Point(Pos.X + 12, Pos.Y + 17));
            Game.Buffer.Graphics.DrawLine(Pens.Blue, new Point(Pos.X + 13, Pos.Y + 17), new Point(Pos.X + 14, Pos.Y + 17));
            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X + 15, Pos.Y + 17), new Point(Pos.X + 16, Pos.Y + 17));

            Game.Buffer.Graphics.DrawLine(Pens.Green, new Point(Pos.X - 6, Pos.Y + 18), new Point(Pos.X - 5, Pos.Y + 18));
            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X - 4, Pos.Y + 18), new Point(Pos.X - 3, Pos.Y + 18));
            Game.Buffer.Graphics.DrawLine(Pens.Blue, new Point(Pos.X - 2, Pos.Y + 18), new Point(Pos.X + 3, Pos.Y + 18));
            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X + 4, Pos.Y + 18), new Point(Pos.X + 5, Pos.Y + 18));
            Game.Buffer.Graphics.DrawLine(Pens.Green, new Point(Pos.X + 6, Pos.Y + 18), new Point(Pos.X + 9, Pos.Y + 18));
            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X + 10, Pos.Y + 18), new Point(Pos.X + 11, Pos.Y + 18));
            Game.Buffer.Graphics.DrawLine(Pens.Green, new Point(Pos.X + 12, Pos.Y + 18), new Point(Pos.X + 13, Pos.Y + 18));
            Game.Buffer.Graphics.DrawLine(Pens.Blue, new Point(Pos.X + 14, Pos.Y + 18), new Point(Pos.X + 15, Pos.Y + 18));

            Game.Buffer.Graphics.DrawLine(Pens.Green, new Point(Pos.X - 6, Pos.Y + 19), new Point(Pos.X - 5, Pos.Y + 19));
            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X - 4, Pos.Y + 19), new Point(Pos.X - 3, Pos.Y + 19));
            Game.Buffer.Graphics.DrawLine(Pens.Blue, new Point(Pos.X - 2, Pos.Y + 19), new Point(Pos.X + 3, Pos.Y + 19));
            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X + 4, Pos.Y + 19), new Point(Pos.X + 5, Pos.Y + 19));
            Game.Buffer.Graphics.DrawLine(Pens.Green, new Point(Pos.X + 6, Pos.Y + 19), new Point(Pos.X + 8, Pos.Y + 19));
            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X + 9, Pos.Y + 19), new Point(Pos.X + 10, Pos.Y + 19));
            Game.Buffer.Graphics.DrawLine(Pens.Green, new Point(Pos.X + 11, Pos.Y + 19), new Point(Pos.X + 12, Pos.Y + 19));
            Game.Buffer.Graphics.DrawLine(Pens.Blue, new Point(Pos.X + 13, Pos.Y + 19), new Point(Pos.X + 15, Pos.Y + 19));

            Game.Buffer.Graphics.DrawLine(Pens.Green, new Point(Pos.X - 5, Pos.Y + 20), new Point(Pos.X - 4, Pos.Y + 20));
            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X - 3, Pos.Y + 20), new Point(Pos.X - 2, Pos.Y + 20));
            Game.Buffer.Graphics.DrawLine(Pens.Blue, new Point(Pos.X - 1, Pos.Y + 20), new Point(Pos.X + 3, Pos.Y + 20));
            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X + 4, Pos.Y + 20), new Point(Pos.X + 5, Pos.Y + 20));
            Game.Buffer.Graphics.DrawLine(Pens.Green, new Point(Pos.X + 6, Pos.Y + 20), new Point(Pos.X + 8, Pos.Y + 20));
            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X + 9, Pos.Y + 20), new Point(Pos.X + 10, Pos.Y + 20));
            Game.Buffer.Graphics.DrawLine(Pens.Green, new Point(Pos.X + 11, Pos.Y + 20), new Point(Pos.X + 12, Pos.Y + 20));
            Game.Buffer.Graphics.DrawLine(Pens.Blue, new Point(Pos.X + 13, Pos.Y + 20), new Point(Pos.X + 14, Pos.Y + 20));

            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X - 4, Pos.Y + 21), new Point(Pos.X - 2, Pos.Y + 21));
            Game.Buffer.Graphics.DrawLine(Pens.Blue, new Point(Pos.X - 1, Pos.Y + 21), new Point(Pos.X + 3, Pos.Y + 21));
            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X + 4, Pos.Y + 21), new Point(Pos.X + 5, Pos.Y + 21));
            Game.Buffer.Graphics.DrawLine(Pens.Green, new Point(Pos.X + 6, Pos.Y + 21), new Point(Pos.X + 7, Pos.Y + 21));
            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X + 8, Pos.Y + 21), new Point(Pos.X + 9, Pos.Y + 21));
            Game.Buffer.Graphics.DrawLine(Pens.Blue, new Point(Pos.X + 10, Pos.Y + 21), new Point(Pos.X + 11, Pos.Y + 21));
            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X + 12, Pos.Y + 21), new Point(Pos.X + 13, Pos.Y + 21));

            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X - 3, Pos.Y + 22), new Point(Pos.X - 1, Pos.Y + 22));
            Game.Buffer.Graphics.DrawLine(Pens.Blue, new Point(Pos.X - 1, Pos.Y + 22), new Point(Pos.X + 4, Pos.Y + 22));
            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X + 5, Pos.Y + 22), new Point(Pos.X + 8, Pos.Y + 22));
            Game.Buffer.Graphics.DrawLine(Pens.Blue, new Point(Pos.X + 9, Pos.Y + 22), new Point(Pos.X + 10, Pos.Y + 22));
            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X + 11, Pos.Y + 22), new Point(Pos.X + 12, Pos.Y + 22));

            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X - 2, Pos.Y + 23), new Point(Pos.X + 1, Pos.Y + 23));
            Game.Buffer.Graphics.DrawLine(Pens.Blue, new Point(Pos.X + 2, Pos.Y + 23), new Point(Pos.X + 4, Pos.Y + 23));
            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X + 5, Pos.Y + 23), new Point(Pos.X + 6, Pos.Y + 23));
            Game.Buffer.Graphics.DrawLine(Pens.Blue, new Point(Pos.X + 7, Pos.Y + 23), new Point(Pos.X + 9, Pos.Y + 23));
            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X + 10, Pos.Y + 23), new Point(Pos.X + 11, Pos.Y + 23));

            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X - 1, Pos.Y + 23), new Point(Pos.X + 1, Pos.Y + 23));
            Game.Buffer.Graphics.DrawLine(Pens.Blue, new Point(Pos.X + 2, Pos.Y + 23), new Point(Pos.X + 4, Pos.Y + 23));
            Game.Buffer.Graphics.DrawLine(Pens.White, new Point(Pos.X + 5, Pos.Y + 23), new Point(Pos.X + 6, Pos.Y + 23));
            Game.Buffer.Graphics.DrawLine(Pens.Blue, new Point(Pos.X + 7, Pos.Y + 23), new Point(Pos.X + 10, Pos.Y + 23));

            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X, Pos.Y + 23), new Point(Pos.X + 1, Pos.Y + 23));
            Game.Buffer.Graphics.DrawLine(Pens.White, new Point(Pos.X + 2, Pos.Y + 23), new Point(Pos.X + 7, Pos.Y + 23));
            Game.Buffer.Graphics.DrawLine(Pens.DarkBlue, new Point(Pos.X + 8, Pos.Y + 23), new Point(Pos.X + 9, Pos.Y + 23));
        }
    }
}
