using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrozenWorld
{
    [Serializable]
    public class Game
    {
        public enum Direction
        {
            STILL, UP, DOWN, LEFT, RIGHT, JUMPING
        }

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
        public int frozenBlocks { get; set; }

        public Game(int maxUp,int maxDown, int maxRight, int maxLeft)
        {
            Enemies = new List<Enemy>();
            Platforms = new List<Platform>();
            Stairs = new List<Stairs>();
            Snowflakes = new List<Snowflake>();

            collectedSnowflakes = 0;
            frozenBlocks = 0;

            this.maxUp = maxUp;
            this.maxDown = maxDown;
            this.maxLeft = maxLeft;
            this.maxRight = maxRight;
        }

        public void Draw(Graphics g)
        {
            foreach(Enemy e in Enemies)
            {
                e.Draw(g);
            }
            foreach (Platform p in Platforms)
            {
                p.Draw(g);
            }
            foreach (Stairs st in Stairs)
            {
                st.Draw(g);
            }
            foreach (Snowflake sn in Snowflakes)
            {
                sn.Draw(g);
            }
            
            Player.Draw(g);
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
            }
        }
        public void MoveEnemies()
        {
            foreach (Enemy e in Enemies)
            {
                e.timerTick();
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
                if (Player.getRectagleWithPadding(-30,5,0,0).IntersectsWith(p.getRectagle())) return true;
            }
            foreach (Stairs s in Stairs)
            {
                if (Player.getRectagleWithPadding(-30, 5, 0, 0).IntersectsWith(s.getRectagle())) return true;
            }
            foreach(Enemy e in Enemies)
            {
                if (e.isFrozen) {
                    if (Math.Abs(Player.Y + Player.Height - e.Y) <= 5        //if the player is on top of the enemy
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
                Player.JUMPSPEED = -12;
                Player.GRAVITY -= 1;
            }
            else if (Player.isOnStairs)
            {
                Player.JUMPSPEED = 12;
                Player.GRAVITY -= 1;
            }
            else
            {
                Player.JUMPSPEED = 12;
                foreach (Platform p in Platforms)
                {
                    if (Player.getRectagleWithPadding(-20, 0, 0, 0).IntersectsWith(p.getRectagle()) && !Player.isJumping)
                    {
                        Player.GRAVITY = 10;
                        Player.Y = p.Y - Player.Height;
                        break;
                    }
                }
                foreach (Enemy e in Enemies)
                {
                    if (e.isFrozen)
                    {
                        if (Math.Abs(Player.Y + Player.Height - e.Y) <= 5        //if the player is on top of the enemy
                            && ((Player.X <= e.X && Player.X + Player.Width >= e.X) //if the player is on the left side of enemy
                            || (e.X + Enemy.Width >= Player.X && e.X <= Player.X)))
                        {
                            Player.GRAVITY = 10;
                            Player.Y = e.Y - Player.Height;
                            break;
                        }
                    }
                }
            }
            collectSnowflakes();
            interactWithEnemies();
        }
    }

}
