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
            this.leftLimit = leftLimit;
            this.rightLimit = rightLimit;

            isFrozen = false;
            Image = Resources.enemy;
            Direction = Game.Direction.RIGHT;
            this.freezeTimeLeft = 0;
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

        public bool Freeze(Player player)
        {
            if (!isFrozen)
            {
                if (Math.Abs(player.Y+Player.Height-this.Y) <= 2        //if the player is on top of the enemy
                    && ((player.X <= this.X && player.X+Player.Width >= this.X) //if the player is on the left side of enemy
                    || (this.X+Enemy.Width >= player.X && this.X<=player.X))) //if the player is on the right side of enemy
                {
                    this.isFrozen = true;
                    freezeTimeLeft = TOTALFREEZETIME;
                    Image = Resources.enemyFrozen;
                }
            }

            if (isFrozen) return true;
            return false;
        }

        public void timerTick()
        {
            if (isFrozen)
            {
                freezeTimeLeft--; //reduce time of being frozen left
                if (freezeTimeLeft <= 0) //if zero seconds left of freeze time
                {
                    isFrozen = false; //unfreeze
                    freezeTimeLeft = 0; //set freezetimeleft to 0
                    Image = Resources.enemy; //change the image to unfrozen

                }
            }

            //Alternative: if(!isFrozen)
            else //if not frozen, it should move in its default ways
            {
                if (this.Direction == Game.Direction.RIGHT) //if direction is RIGHT
                {
                    this.X += Velocity;                     //move to the RIGHT

                    if (this.X + Enemy.Width >= this.rightLimit)           //if near EDGE, change direction
                        this.Direction = Game.Direction.LEFT;
                }
                else if (this.Direction == Game.Direction.LEFT) //if direction is LEFT
                {
                    this.X -= Velocity;                     //move to the LEFT

                    if (this.X <= this.leftLimit)           //if near EDGE, change direction
                        this.Direction = Game.Direction.RIGHT; 
                }
            }
        }
    }
}
