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
    public class Player
    {
        public int X { get; set; }
        public int Y { get; set; }

        public static int Width = 50;
        public static int Height = 70;

        public Image Image { get; set; }

        public Player(int x, int y)
        {
            X = x;
            Y = y;
            Image = Resources.player;
        }
        public void Draw(Graphics g)
        {
            g.DrawImage(Image, X, Y, Width, Height);
        }
        public Rectangle getRectagle()
        {
            return new Rectangle(X, Y, Width, Height);
        }
        public Rectangle getRectagleWithPadding(int top, int bottom, int left, int right)
        {
            return new Rectangle(X - left, Y - top, Width + right+left, Height + bottom+top);
        }

    }
}
