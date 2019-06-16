using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrozenWorld
{
    public class Game
    {
        public int LEVELID { get; set; }
        public Image BACKGROUNDIMAGE { get; set; }
        public int TOTALITEMSTOFREEZE { get; set; }
        public int TOTALSNOWFLAKES { get; set; }
        public List<Enemy> Enemies { get; set; }
        public List<Platform> Platforms { get; set; }
        public List<Stairs> Stairs { get; set; }
        public List<Snowflake> Snowflakes { get; set; }
        public Player Player { get; set; }

        public Image Image { get; set; }

        public int maxUp { get; set; }
        public int maxDown { get; set; }
        public int maxLeft { get; set; }
        public int maxRight { get; set; }

        public int collectedSnowflakes { get; set; }
        
        public Game(int maxUp,int maxDown, int maxRight, int maxLeft)
        {
            Enemies = new List<Enemy>();
            Platforms = new List<Platform>();
            Stairs = new List<Stairs>();
            Snowflakes = new List<Snowflake>();

            collectedSnowflakes = 0;
           
            this.maxUp = maxUp;
            this.maxDown = maxDown;
            this.maxLeft = maxLeft;
            this.maxRight = maxRight;
        }

        public void Draw(Graphics g)
        {
            foreach (Stairs st in Stairs)
            {
                st.Draw(g);
            }
            Player.Draw(g);
            foreach (Enemy e in Enemies)
            {
                e.Draw(g);
            }
            foreach (Platform p in Platforms)
            {
                p.Draw(g);
            }
            
            foreach (Snowflake sn in Snowflakes)
            {
                sn.Draw(g);
            }           
        }
        public bool isPlayerOutOfBounds()
        {
            if (Player.Y > maxDown + 10) return true;
            return false;
        }
        public bool isGameWon()
        {
            if (getFrozenBlockNumber() == TOTALITEMSTOFREEZE)
            {
                return true;
            }
            return false;
        }
        
        public int calculateScore()
        {
            return collectedSnowflakes * 100 + TOTALITEMSTOFREEZE;
        }
        public bool isGameLost()
        {
            if (Player.LivesLeft <= 0) return true;
            return false;
        }
        public int getFrozenBlockNumber()
        {
            int frozenBlocks = 0;
            foreach (Platform p in Platforms)
            {
                if (p.isFrozen) frozenBlocks++;
            }
            foreach (Stairs s in Stairs)
            {
                if (s.isFrozen) frozenBlocks++;
            }
            return frozenBlocks;
        }
        public void MovePlayerLeft()
        {
            Player.X -= Player.VELOCITY;

            if (Player.isOnStairs)
            {
                foreach (Stairs stair in Stairs)
                {
                    if (Player.getRectagle().IntersectsWith(stair.getRectagle()))
                    {
                        Player.isOnStairs = true; break;
                    }
                    else
                    {
                        Player.isOnStairs = false;
                    }
                }
            }
        }
        public void MovePlayerRight()
        {
            Player.X += Player.VELOCITY;
            if (Player.isOnStairs)
            {
                foreach (Stairs stair in Stairs)
                {
                    if (Player.getRectagle().IntersectsWith(stair.getRectagle()))
                    {
                        Player.isOnStairs = true; break;
                    }
                    else
                    {
                        Player.isOnStairs = false;
                    }
                }
            }
        }
        public void MovePlayerUp()
        {
            foreach (Stairs stair in Stairs)
            {
                if (Player.getRectagle().IntersectsWith(stair.getRectagle()))
                {
                    Player.Y -= Player.VELOCITY;
                    Player.isOnStairs = true; break;
                }
                else
                {
                    Player.isOnStairs = false;
                }
            }
        }
        public void MovePlayerDown()
        {
            foreach (Stairs stair in Stairs)
            {
                if ((Player.getRectagle().IntersectsWith(stair.getRectagle()) && Player.Y + Player.Height < stair.Y + stair.getHeight() + 1) || Player.Y + Player.Height == stair.Y)
                {
                    Player.Y += Player.VELOCITY;
                    Player.isOnStairs = true; break;
                }
                else
                {
                    Player.isOnStairs = false;
                }
            }
        }
        public void collectSnowflakes()
        {
            for (int i = 0; i < Snowflakes.Count; i++)
            {
                if (Snowflakes[i].Collect(Player))
                {
                    collectedSnowflakes++;
                    Snowflakes.RemoveAt(i);
                    i--;
                }
            }
        }

        public void interactWithEnemies()
        {
            foreach (Enemy e in Enemies)
            {
                e.Freeze(Player);

                if(!e.isFrozen && e.getRectagle().IntersectsWith(Player.getRectagleWithPadding(0, -3, 0, 0))){
                    Player.reduceLives();
                }
            }
        }
        public void MoveEnemies()
        {
            foreach (Enemy e in Enemies)
            {
                e.timerTick();
                if (e.isAngry && e.isAdvancedEnemy)
                {
                    e.isAngry = false;
                    foreach(Platform p in Platforms)
                    {
                        if (e.getRectagleWithPadding(35, 35, 35, 35).IntersectsWith(p.getRectagle()))
                        {
                            p.unfreeze();
                        }
                    }
                    foreach (Stairs s in Stairs)
                    {
                        if (e.getRectagleWithPadding(5, 5, 5, 5).IntersectsWith(s.getRectagle()))
                        {
                            s.unfreeze();
                        }
                    }
                }
            }
        }
        public void FreezeFreezableBlocks()
        {
            foreach (Platform p in Platforms)
            {
                p.Freeze(Player);
            }
            foreach (Stairs st in Stairs)
            {
                st.Freeze(Player);

            }
        }
        public bool isPlayerOnJumpablePlatform()
        {
           foreach (Platform p in Platforms)
            {
                if (Player.getRectagleWithPadding(-30,3,0,0).IntersectsWith(p.getRectagle())) return true;
            }
            foreach (Stairs s in Stairs)
            {
                if (Player.getRectagleWithPadding(-30, 3, 0, 0).IntersectsWith(s.getRectagle())) return true;
            }
            foreach(Enemy e in Enemies)
            {
                if (e.isFrozen) {
                    if (Math.Abs(Player.Y + Player.Height - e.Y) <= 3        //if the player is on top of the enemy
                        && ((Player.X <= e.X && Player.X + Player.Width >= e.X) //if the player is on the left side of enemy
                        || (e.X + Enemy.Width >= Player.X && e.X <= Player.X)))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public void timerTick()
        {
            MoveEnemies();
            FreezeFreezableBlocks();
            interactWithEnemies();

            if (!Player.isOnStairs)
            {
                Player.Y += Player.JUMPSPEED;
            }

            if (Player.isJumping && Player.GRAVITY < 0)
            {
                Player.isJumping = false;
            }

            if (Player.isGoingLeft && Player.X > 1)
            {
                MovePlayerLeft();
            }

            if (Player.isGoingRight && Player.X+ Player.Width+Player.VELOCITY < this.maxRight)
            {
                MovePlayerRight();
            }

            if (Player.isGoingUp)
            {
                MovePlayerUp();
            }

            if (Player.isGoingDown)
            {
                MovePlayerDown();
            }

            if (Player.isJumping && !Player.isOnStairs)
            {
                Player.JUMPSPEED = -22;
                Player.GRAVITY -= 3;
            }
            else if (Player.isOnStairs)
            {
                Player.JUMPSPEED = 22;
                Player.GRAVITY -= 3;
            }
            else
            {
                bool flag = false;
                Player.JUMPSPEED = 22;
            
                foreach (Platform p in Platforms)
                {
                    if (Player.getRectagleWithPadding(-35, 0, 0, 0).IntersectsWith(p.getRectagle()) && !Player.isJumping)
                    {
                        Player.GRAVITY = 12;
                        Player.Y = p.Y - Player.Height;
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    foreach (Enemy e in Enemies)
                    {
                        if (e.isFrozen)
                        {
                            if (Math.Abs(Player.Y + Player.Height - e.Y) <= 15        //if the player is on top of the enemy
                                && ((Player.X <= e.X && Player.X + Player.Width >= e.X) //if the player is on the left side of enemy
                                || (e.X + Enemy.Width >= Player.X && e.X <= Player.X)))
                            {
                                Player.GRAVITY = 12;
                                Player.Y = e.Y - Player.Height;
                                flag = true;
                                break;
                            }
                        }
                    }
                }
                if (!flag)
                {
                    foreach (Stairs s in Stairs)
                    {
                        if (Player.getRectagleWithPadding(-20, 0, 0, 0).IntersectsWith(s.getRectagle()) && !Player.isJumping)
                        {
                            Player.GRAVITY = 12;
                            Player.Y = s.Y - Player.Height;
                            break;
                        }
                    }
                }
            }
            collectSnowflakes();
            //interactWithEnemies();
            Player.RehabTimeLeft--;
        }
    }

}
