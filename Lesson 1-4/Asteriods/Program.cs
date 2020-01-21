using System;
using System.Windows.Forms;

namespace Asteriods
{
    class Program
    {
        static void Main(string[] args)
        {
            Form frm = new Form();
            frm.Width = 800;
            frm.Height = 600;
            Game.Init(frm);
            frm.Show();
            Game.Draw();
            Application.Run(frm);
        }
    }
}
