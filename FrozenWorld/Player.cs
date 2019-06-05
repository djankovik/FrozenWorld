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

        public static int VELOCITY = 5;

        public bool isJumping { get; set; }
        public bool isGoingLeft { get; set; }
        public bool isGoingRight { get; set; }
        public bool isGoingDown { get; set; }
        public bool isGoingUp { get; set; }

        public bool isOnStairs { get; set; }
        public Image Image { get; set; }

        public Player(int x, int y)
        {
            X = x;
            Y = y;
            Image = Resources.player;

            GRAVITY = 8;
            JUMPSPEED = 12;

            isJumping = false;
            isGoingLeft = false;
            isGoingRight = false;
            isGoingDown = false;
            isGoingUp = false;

            isOnStairs = false;

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

        public void timerTick()
        {
            this.X += JUMPSPEED;
            if(isJumping && GRAVITY < 0)
            {
                isJumping = false;
            }
            if (isGoingLeft)
            {
                X -= VELOCITY;
            }
            if (isGoingRight)
            {
                X += VELOCITY;
            }
            if (isGoingUp && isOnStairs)
            {
                Y -= VELOCITY;
            }
            if (isGoingDown && isOnStairs)
            {
                Y += VELOCITY;
            }
            if (isJumping)
            {
                JUMPSPEED -= 12;
                GRAVITY--;
            }
            else
            {
                JUMPSPEED = 12;
            }
            if (isOnStairs) GRAVITY = 0;
        }

    }
}
