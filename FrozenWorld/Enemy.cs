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
        public enum DIRECTION
        {
            LEFT, RIGHT
        }

        public int X { get; set; }
        public int Y { get; set; }
        public int leftLimit { get; set; }
        public int rightLimit { get; set; }

        public static int Width = 40;
        public static int Height = 50;

        public Enemy.DIRECTION Direction { get; set; }

        public static int Velocity = 5;
        public bool isFrozen { get; set; }

        public static int TOTALFREEZETIME = 50;
        public int freezeTimeLeft { get; set; }
        public bool isAdvancedEnemy { get; set; }
        public bool isAngry { get; set; }
        public Image Image { get; set; }

        public Enemy(int x, int y, int leftLimit, int rightLimit)
        {
            X = x;
            Y = y;
            this.leftLimit = leftLimit;
            this.rightLimit = rightLimit;

            isFrozen = false;
            isAdvancedEnemy = false;
            isAngry = false;

            Image = Resources.enemy;
            Direction = Enemy.DIRECTION.RIGHT;
            this.freezeTimeLeft = 0;
        }
       public void makeAdvancedEnemy()
        {
            isAdvancedEnemy = true;
            isAngry = false;
            Image = Resources.enemyAdvanced;
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
            g.DrawImage(Image,X,Y,Width,Height);
        }

        public void Freeze(Player player)
        {
            if (!isFrozen)
            {
                if (Math.Abs(player.Y+Player.Height-this.Y) <= 10        //if the player is on top of the enemy
                    && ((player.X <= this.X && player.X+Player.Width >= this.X) //if the player is on the left side of enemy
                    || (this.X+Enemy.Width >= player.X && this.X<=player.X))) //if the player is on the right side of enemy
                {
                    this.isFrozen = true;
                    freezeTimeLeft = TOTALFREEZETIME;
                    Image = Resources.enemyFrozen;
                }
            }
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
                    if (isAdvancedEnemy)
                    {
                        isAngry = true;
                        Image = Resources.enemyAdvanced;
                        return;
                    }
                    else
                        Image = Resources.enemy; //change the image to unfrozen
                }
            }

            //Alternative: if(!isFrozen)
            else //if not frozen, it should move in its default ways
            {
                if (this.Direction == Enemy.DIRECTION.RIGHT) //if direction is RIGHT
                {
                    this.X += Velocity;                     //move to the RIGHT

                    if (this.X + Enemy.Width >= this.rightLimit)           //if near EDGE, change direction
                        this.Direction = Enemy.DIRECTION.LEFT;
                }
                else if (this.Direction == Enemy.DIRECTION.LEFT) //if direction is LEFT
                {
                    this.X -= Velocity;                     //move to the LEFT

                    if (this.X <= this.leftLimit)           //if near EDGE, change direction
                        this.Direction = Enemy.DIRECTION.RIGHT; 
                }
            }
        }
    }
}
