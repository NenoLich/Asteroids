using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asteroids
{
    class Program
    {
        static void Main(string[] args)
        {
            Form asteroidsForm = new Form();
            asteroidsForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            asteroidsForm.Width = 800;
            asteroidsForm.Height = 600;
            Utility.HideConsole();

            if (Game.Awake(asteroidsForm))
            {
                asteroidsForm.ShowDialog();
            }
        }
    }
}
