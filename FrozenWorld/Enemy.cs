using FrozenWorld.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrozenWorld
{
    public class Enemy
    {
        public enum DIRECTION
        {
            LEFT, RIGHT
        }
        public static Image EnemyLeft = Resources.enemySimple1Left;
        public static Image EnemyRight = Resources.enemySimple1Right;
        public static Image EnemyLeftFrozen = Resources.enemySimple2LeftFrozen;
        public static Image EnemyRightFrozen = Resources.enemySimple2RightFrozen;
        public static Image EnemyAdvanced = Resources.enemyAdvanced;
        public static Image EnemyAdvancedFrozen = Resources.enemyAdvancedFrozen;
        public static Image EnemyAdvancedAngry = Resources.enemyAdvancedAngry;

        public int X { get; set; }
        public int Y { get; set; }
        public int leftLimit { get; set; }
        public int rightLimit { get; set; }

        public static int Width = 50;
        public static int Height = 55;

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

            Image = EnemyRight;
            Direction = Enemy.DIRECTION.RIGHT;
            this.freezeTimeLeft = 0;
        }
       public void makeAdvancedEnemy()
        {
            isAdvancedEnemy = true;
            isAngry = false;
            Image = EnemyAdvanced;
        }
        public void FreezeImage()
        {
            if (isAdvancedEnemy)
            {
                if(Direction == Enemy.DIRECTION.RIGHT)
                {
                    Image = EnemyAdvancedFrozen;
                }
                else
                {
                    Image = EnemyAdvancedFrozen;
                }               
            }
            else
            {
                if (Direction == Enemy.DIRECTION.RIGHT)
                {
                    Image = EnemyRightFrozen;
                }
                else
                {
                    Image = EnemyLeftFrozen;
                }
            }
        }
        public void UnfreezeImage()
        {
            if (isAdvancedEnemy)
            {
                if (Direction == Enemy.DIRECTION.RIGHT)
                {
                    Image = EnemyAdvanced;
                }
                else
                {
                    Image = EnemyAdvanced;
                }
                if (this.isAngry)
                {
                    Image = EnemyAdvancedAngry;
                }
            }
            else
            {
                if (Direction == Enemy.DIRECTION.RIGHT)
                {
                    Image = EnemyRight;
                }
                else
                {
                    Image = EnemyLeft;
                }
            }
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
                if (Math.Abs(player.Y+Player.Height-this.Y) <= 16        //if the player is on top of the enemy
                    && ((player.X <= this.X && player.X+Player.Width >= this.X) //if the player is on the left side of enemy
                    || (this.X+Enemy.Width >= player.X && this.X<=player.X))) //if the player is on the right side of enemy
                {
                    this.isFrozen = true;
                    freezeTimeLeft = TOTALFREEZETIME;
                    FreezeImage();
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
                    }
                    UnfreezeImage();
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
                UnfreezeImage();
            }
        }
    }
}
