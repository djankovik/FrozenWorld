using FrozenWorld.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrozenWorld
{
    public partial class Form1 : Form
    {
        Platform p = new Platform(40,40);
        Platform p2 = new Platform(140, 140);
        Player play = new Player(200, 200);
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            p2.freezeImage();
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            int x = 0;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            p.Draw(e.Graphics);
            p2.Draw(e.Graphics);
            play.Draw(e.Graphics);

        }
    }
}
