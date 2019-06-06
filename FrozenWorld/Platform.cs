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
    public class Platform
    {
        public int X { get; set; }
        public int Y { get; set; }
        public static int Width = 50;
        public static int Height = 30;

        public bool isFrozen { get; set; }

        public Image Image { get; set; }

        public Platform(int x, int y)
        {
            X = x;
            Y = y;
            isFrozen = false;
            Image = Resources.platformBrick;
        }
        public void freezeImage()
        {
            Image = Resources.platformBrickFrozen;
        }
        public Rectangle getRectagle()
        {
            return new Rectangle(X, Y, Width, Height);
        }
        public Rectangle getRectagleWithPadding(int top, int bottom, int left, int right)
        {
            return new Rectangle(X - left, Y - top, Width + right + left, Height + bottom + top);
        }
        public void Draw(Graphics g)
        {
           g.DrawImage(Image, X, Y,Width,Height);
        }
        public void Freeze(Player p)
        {
            if (p.getRectagleWithPadding(0, 3, 0, 0).IntersectsWith(this.getRectagle()))
            {
                this.isFrozen = true;
                freezeImage();
            }            
        }
    }
}
