using FrozenWorld.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrozenWorld
{
    [Serializable]
    public class Snowflake
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Image Image { get; set; }
        public bool isCollected { get; set; }

        public static int Width = 30;
        public static int Height = 30;

        public Snowflake(int x, int y)
        {
            X = x;
            Y = y;
            isCollected = false;
            Image = Resources.Snowflake;
        }

        public bool Collect(Player player)
        {
            if (this.isCollected) return true;
            else if (player.getRectagle().IntersectsWith(this.getRectagle()))
            {
                this.isCollected = true;
                return true;
                //Image = null;
            }
            return false;
        }

        public Rectangle getRectagle()
        {
            return new Rectangle(X, Y, Width, Height);
        }

        public void Draw(Graphics g)
        {
            g.DrawImage(Image, X, Y, Width, Height);
        }

    }
}
