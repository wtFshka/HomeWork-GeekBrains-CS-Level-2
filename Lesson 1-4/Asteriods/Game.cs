using System;
using System.Windows.Forms;
using System.Drawing;

namespace Asteriods
{
    static class Game
    {
        private static BufferedGraphicsContext _context;
        public static BufferedGraphics Buffer;
        public static BaseObject[] _objs;

        public static int Width { get; set; }
        public static int Height { get; set; }

        public static void Init(Form form)
        {
            Graphics graphics;
            _context = BufferedGraphicsManager.Current;
            graphics = form.CreateGraphics();
            Width = form.ClientSize.Width;
            Height = form.ClientSize.Height;

            Buffer = _context.Allocate(graphics, new Rectangle(0, 0, Width, Height));
            Load();

            Timer timer = new Timer { Interval = 10 };
            timer.Start();
            timer.Tick += Timer_Tick;
        }

        private static void Timer_Tick(object sender, EventArgs e)
        {
            Draw();
            Update();
        }

        public static void Load()
        {
            Random rnd = new Random();
            Image star = Image.FromFile(@"Star.png");
            _objs = new BaseObject[60];
            for (int i = 0; i < _objs.Length; i++)
            {
                int size = rnd.Next(5, 30);
                int speed = rnd.Next(3, 7);
                _objs[i] = new Star(new Point(rnd.Next(1, Width), rnd.Next(1, Height)), new Point(speed, speed), new Size(size, size), star);
            }
        }
        public static void Draw()
        {
            Buffer.Graphics.Clear(Color.Black);

            Earth earth = new Earth(new Point(700, 100), new Point(700, 100), new Size(10, 10));
            earth.Draw();

            foreach (var obj in _objs)
            {
                obj.Draw();
            }

            Buffer.Render();
        }
        public static void Update()
        {
            foreach (var obj in _objs)
            {
                obj.Update();
            }
        }
    }
}
