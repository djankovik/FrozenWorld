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

        public int GRAVITY { get; set; }
        public int JUMPSPEED { get; set; }
        public static int REHABTIME = 10;
        public static int VELOCITY = 30;

        public bool isJumping { get; set; }
        public bool isGoingLeft { get; set; }
        public bool isGoingRight { get; set; }
        public bool isGoingDown { get; set; }
        public bool isGoingUp { get; set; }

        public bool isOnStairs { get; set; }
        public Image Image { get; set; }

        public int LivesLeft { get; set; }
        public int RehabTimeLeft { get; set; }

        public Player(int x, int y)
        {
            this.X = x;
            this.Y = y;
            Image = Resources.player;

            GRAVITY = 12;
            JUMPSPEED = 22;

            isJumping = false;
            isGoingLeft = false;
            isGoingRight = false;
            isGoingDown = false;
            isGoingUp = false;
            isOnStairs = false;

            LivesLeft = 5;
            RehabTimeLeft = 0;

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
        public void reduceLives()
        {
            if (RehabTimeLeft <= 0)
            {
                RehabTimeLeft = REHABTIME;
                LivesLeft--;
            }
            
        }
        
    }
}
