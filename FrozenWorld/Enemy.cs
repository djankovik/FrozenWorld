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
    public class Enemy
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int leftLimit { get; set; }
        public int rightLimit { get; set; }
        public static int Width = 50;
        public static int Height = 70;

        public Game.Direction Direction{ get; set; }
        public static int Velocity = 20;
        public bool isFrozen { get; set; }

        public static int TOTALFREEZETIME = 20;
        public int freezeTimeLeft { get; set; }

        public Image Image { get; set; }

        public Enemy(int x, int y, int leftLimit, int rightLimit)
        {
            X = x;
            Y = y;
            isFrozen = false;
            Image = Resources.enemy;
            Direction = Game.Direction.RIGHT;
        }
        public void freezeImage()
        {
            Image = Resources.enemyFrozen;
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
            g.DrawImage(Image, X, Y, Width, Height);
        }
        public void Freeze(Player play)
        {
            if (!isFrozen)
            {
                if (Math.Abs(play.Y+Player.Height-this.Y) <= 1 && Math.Abs(play.Y - this.Y) <= 1)
                {
                    this.isFrozen = true;
                    freezeImage();
                }
            }
        }
    }
}
