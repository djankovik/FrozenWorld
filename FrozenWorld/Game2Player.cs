using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrozenWorld
{
    public class Game2Player
    {

        public int LEVELID { get; set; }
        public Image BACKGROUNDIMAGE { get; set; }
        public int TOTALITEMSTOFREEZE { get; set; }
        public int TOTALSNOWFLAKES { get; set; }
        public List<Enemy> Enemies { get; set; }
        public List<Platform> Platforms { get; set; }
        public List<Stairs> Stairs { get; set; }
        public List<Snowflake> Snowflakes { get; set; }
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }
        public Image Image { get; set; }

        public int maxUp { get; set; }
        public int maxDown { get; set; }
        public int maxLeft { get; set; }
        public int maxRight { get; set; }

        public int collectedSnowflakesPlayer1 { get; set; }
        public int collectedSnowflakesPlayer2 { get; set; }
        public int frozenItemsPlayer1 { get; set; }
        public int frozenItemsPlayer2 { get; set; }

        public Game2Player(int maxUp, int maxDown, int maxRight, int maxLeft)
        {
            Enemies = new List<Enemy>();
            Platforms = new List<Platform>();
            Stairs = new List<Stairs>();
            Snowflakes = new List<Snowflake>();

            collectedSnowflakesPlayer1 = 0;
            collectedSnowflakesPlayer2 = 0;

            frozenItemsPlayer1 = 0;
            frozenItemsPlayer2 = 0;

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
            if(Player1.LivesLeft > 0)
                Player1.Draw(g);
            if (Player2.LivesLeft > 0)
                Player2.Draw(g);

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
        public void isPlayerOutOfBounds()
        {
            if (Player1.Y+Player.Height >= maxDown -30 && Player1.LivesLeft >0)
            {
                Player1.LivesLeft = -5;
                
            }
            if (Player2.Y + Player.Height >= maxDown -30 && Player2.LivesLeft > 0)
            {
                Player2.LivesLeft = -5;                
            }
            
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
            return collectedSnowflakesPlayer1 * 100+collectedSnowflakesPlayer2 * 100 + TOTALITEMSTOFREEZE;
        }
        public bool isGameLost()
        {
            if (Player1.LivesLeft <= 0 && Player2.LivesLeft <=0)
                return true;

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
        public void MovePlayer1Left()
        {
            Player1.X -= Player.VELOCITY;

            if (Player1.isOnStairs)
            {
                foreach (Stairs stair in Stairs)
                {
                    if (Player1.getRectagle().IntersectsWith(stair.getRectagle()))
                    {
                        Player1.isOnStairs = true; break;
                    }
                    else
                    {
                        Player1.isOnStairs = false;
                    }
                }
            }
        }
        public void MovePlayer1Right()
        {
            Player1.X += Player.VELOCITY;
            if (Player1.isOnStairs)
            {
                foreach (Stairs stair in Stairs)
                {
                    if (Player1.getRectagle().IntersectsWith(stair.getRectagle()))
                    {
                        Player1.isOnStairs = true; break;
                    }
                    else
                    {
                        Player1.isOnStairs = false;
                    }
                }
            }
        }
        public void MovePlayer1Up()
        {
            foreach (Stairs stair in Stairs)
            {
                if (Player1.getRectagle().IntersectsWith(stair.getRectagle()))
                {
                    Player1.Y -= Player.VELOCITY;
                    Player1.isOnStairs = true; break;
                }
                else
                {
                    Player1.isOnStairs = false;
                }
            }
        }
        public void MovePlayer1Down()
        {
            foreach (Stairs stair in Stairs)
            {
                if ((Player1.getRectagle().IntersectsWith(stair.getRectagle()) && Player1.Y + Player.Height < stair.Y + stair.getHeight() + 1) || Player1.Y + Player.Height == stair.Y)
                {
                    Player1.Y += Player.VELOCITY;
                    Player1.isOnStairs = true; break;
                }
                else
                {
                    Player1.isOnStairs = false;
                }
            }
        }
        
        public void MovePlayer2Left()
        {
            Player2.X -= Player.VELOCITY;

            if (Player2.isOnStairs)
            {
                foreach (Stairs stair in Stairs)
                {
                    if (Player2.getRectagle().IntersectsWith(stair.getRectagle()))
                    {
                        Player2.isOnStairs = true; break;
                    }
                    else
                    {
                        Player2.isOnStairs = false;
                    }
                }
            }
        }
        public void MovePlayer2Right()
        {
            Player2.X += Player.VELOCITY;
            if (Player2.isOnStairs)
            {
                foreach (Stairs stair in Stairs)
                {
                    if (Player2.getRectagle().IntersectsWith(stair.getRectagle()))
                    {
                        Player2.isOnStairs = true; break;
                    }
                    else
                    {
                        Player2.isOnStairs = false;
                    }
                }
            }
        }
        public void MovePlayer2Up()
        {
            foreach (Stairs stair in Stairs)
            {
                if (Player2.getRectagle().IntersectsWith(stair.getRectagle()))
                {
                    Player2.Y -= Player.VELOCITY;
                    Player2.isOnStairs = true; break;
                }
                else
                {
                    Player2.isOnStairs = false;
                }
            }
        }
        public void MovePlayer2Down()
        {
            foreach (Stairs stair in Stairs)
            {
                if ((Player2.getRectagle().IntersectsWith(stair.getRectagle()) && Player2.Y + Player.Height < stair.Y + stair.getHeight() + 1) || Player2.Y + Player.Height == stair.Y)
                {
                    Player2.Y += Player.VELOCITY;
                    Player2.isOnStairs = true; break;
                }
                else
                {
                    Player2.isOnStairs = false;
                }
            }
        }
        public void collectSnowflakesPlayer1()
        {
            for (int i = 0; i < Snowflakes.Count; i++)
            {
                if (Snowflakes[i].Collect(Player1))
                {
                    collectedSnowflakesPlayer1++;
                    Snowflakes.RemoveAt(i);
                    i--;
                }
            }
        }
        public void collectSnowflakesPlayer2()
        {
            for (int i = 0; i < Snowflakes.Count; i++)
            {
                if (Snowflakes[i].Collect(Player2))
                {
                    collectedSnowflakesPlayer2++;
                    Snowflakes.RemoveAt(i);
                    i--;
                }
            }
        }

        public void interactWithEnemiesPlayer1()
        {
            foreach (Enemy e in Enemies)
            {
                e.Freeze(Player1);

                if (!e.isFrozen && e.getRectagle().IntersectsWith(Player1.getRectagleWithPadding(0, -3, 0, 0)))
                {
                    Player1.reduceLives();
                }
            }
        }
        public void interactWithEnemiesPlayer2()
        {
            foreach (Enemy e in Enemies)
            {
                e.Freeze(Player2);

                if (!e.isFrozen && e.getRectagle().IntersectsWith(Player2.getRectagleWithPadding(0, -3, 0, 0)))
                {
                    Player2.reduceLives();
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
                    foreach (Platform p in Platforms)
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
        public void FreezeFreezableBlocksPlayer1()
        {
            bool flag = false;
            foreach (Platform p in Platforms)
            {
                flag = p.isFrozen;
                p.Freeze(Player1);
                if (flag != p.isFrozen) frozenItemsPlayer1++;
            }
            foreach (Stairs st in Stairs)
            {
                flag = st.isFrozen;
                st.Freeze(Player1);
                if (flag != st.isFrozen) frozenItemsPlayer1++;
            }
        }
        public void FreezeFreezableBlocksPlayer2()
        {
            bool flag = false;
            foreach (Platform p in Platforms)
            {
                flag = p.isFrozen;
                p.Freeze(Player2);
                if (flag != p.isFrozen) frozenItemsPlayer2++;
            }
            foreach (Stairs st in Stairs)
            {
                flag = st.isFrozen;
                st.Freeze(Player2);
                if (flag != st.isFrozen) frozenItemsPlayer2++;
            }
        }
        public bool isPlayer1OnJumpablePlatform()
        {
            foreach (Platform p in Platforms)
            {
                if (Player1.getRectagleWithPadding(-30, 3, 0, 0).IntersectsWith(p.getRectagle())) return true;
            }
            foreach (Stairs s in Stairs)
            {
                if (Player1.getRectagleWithPadding(-30, 3, 0, 0).IntersectsWith(s.getRectagle())) return true;
            }
            foreach (Enemy e in Enemies)
            {
                if (e.isFrozen)
                {
                    if (Math.Abs(Player1.Y + Player.Height - e.Y) <= 3        //if the player is on top of the enemy
                        && ((Player1.X <= e.X && Player1.X + Player.Width >= e.X) //if the player is on the left side of enemy
                        || (e.X + Enemy.Width >= Player1.X && e.X <= Player1.X)))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool isPlayer2OnJumpablePlatform()
        {
            foreach (Platform p in Platforms)
            {
                if (Player2.getRectagleWithPadding(-30, 3, 0, 0).IntersectsWith(p.getRectagle())) return true;
            }
            foreach (Stairs s in Stairs)
            {
                if (Player2.getRectagleWithPadding(-30, 3, 0, 0).IntersectsWith(s.getRectagle())) return true;
            }
            foreach (Enemy e in Enemies)
            {
                if (e.isFrozen)
                {
                    if (Math.Abs(Player2.Y + Player.Height - e.Y) <= 3        //if the player is on top of the enemy
                        && ((Player2.X <= e.X && Player2.X + Player.Width >= e.X) //if the player is on the left side of enemy
                        || (e.X + Enemy.Width >= Player2.X && e.X <= Player2.X)))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public void movePlayer1()
        {
            if (!Player1.isOnStairs)
            {
                Player1.Y += Player1.JUMPSPEED;
            }

            if (Player1.isJumping && Player1.GRAVITY < 0)
            {
                Player1.isJumping = false;
            }

            if (Player1.isGoingLeft && Player1.X > 1)
            {
                MovePlayer1Left();
            }

            if (Player1.isGoingRight && Player1.X + Player.Width + Player.VELOCITY < this.maxRight)
            {
                MovePlayer1Right();
            }

            if (Player1.isGoingUp)
            {
                MovePlayer1Up();
            }

            if (Player1.isGoingDown)
            {
                MovePlayer1Down();
            }

            if (Player1.isJumping && !Player1.isOnStairs)
            {
                Player1.JUMPSPEED = -22;
                Player1.GRAVITY -= 3;
            }
            else if (Player1.isOnStairs)
            {
                Player1.JUMPSPEED = 22;
                Player1.GRAVITY -= 3;
            }
            else
            {
                bool flag = false;
                Player1.JUMPSPEED = 22;

                foreach (Platform p in Platforms)
                {
                    if (Player1.getRectagleWithPadding(-35, 0, 0, 0).IntersectsWith(p.getRectagle()) && !Player1.isJumping)
                    {
                        Player1.GRAVITY = 12;
                        Player1.Y = p.Y - Player.Height;
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
                            if (Math.Abs(Player1.Y + Player.Height - e.Y) <= 15        //if the player is on top of the enemy
                                && ((Player1.X <= e.X && Player1.X + Player.Width >= e.X) //if the player is on the left side of enemy
                                || (e.X + Enemy.Width >= Player1.X && e.X <= Player1.X)))
                            {
                                Player1.GRAVITY = 12;
                                Player1.Y = e.Y - Player.Height;
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
                        if (Player1.getRectagleWithPadding(-20, 0, 0, 0).IntersectsWith(s.getRectagle()) && !Player1.isJumping)
                        {
                            Player1.GRAVITY = 12;
                            Player1.Y = s.Y - Player.Height;
                            break;
                        }
                    }
                }
            }
        }
        public void movePlayer2()
        {
            if (!Player2.isOnStairs)
            {
                Player2.Y += Player2.JUMPSPEED;
            }

            if (Player2.isJumping && Player2.GRAVITY < 0)
            {
                Player2.isJumping = false;
            }

            if (Player2.isGoingLeft && Player2.X > 1)
            {
                MovePlayer2Left();
            }

            if (Player2.isGoingRight && Player2.X + Player.Width + Player.VELOCITY < this.maxRight)
            {
                MovePlayer2Right();
            }

            if (Player2.isGoingUp)
            {
                MovePlayer2Up();
            }

            if (Player2.isGoingDown)
            {
                MovePlayer2Down();
            }

            if (Player2.isJumping && !Player2.isOnStairs)
            {
                Player2.JUMPSPEED = -22;
                Player2.GRAVITY -= 3;
            }
            else if (Player2.isOnStairs)
            {
                Player2.JUMPSPEED = 22;
                Player2.GRAVITY -= 3;
            }
            else
            {
                bool flag = false;
                Player2.JUMPSPEED = 22;

                foreach (Platform p in Platforms)
                {
                    if (Player2.getRectagleWithPadding(-20, 0, 0, 0).IntersectsWith(p.getRectagle()) && !Player2.isJumping)
                    {
                        Player2.GRAVITY = 12;
                        Player2.Y = p.Y - Player.Height;
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
                            if (Math.Abs(Player2.Y + Player.Height - e.Y) <= 15        //if the player is on top of the enemy
                                && ((Player2.X <= e.X && Player2.X + Player.Width >= e.X) //if the player is on the left side of enemy
                                || (e.X + Enemy.Width >= Player2.X && e.X <= Player2.X)))
                            {
                                Player2.GRAVITY = 12;
                                Player2.Y = e.Y - Player.Height;
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
                        if (Player2.getRectagleWithPadding(-20, 0, 0, 0).IntersectsWith(s.getRectagle()) && !Player2.isJumping)
                        {
                            Player2.GRAVITY = 12;
                            Player2.Y = s.Y - Player.Height;
                            break;
                        }
                    }
                }
            }
        }
        public void timerTick()
        {
            MoveEnemies();
            FreezeFreezableBlocksPlayer1();
            FreezeFreezableBlocksPlayer2();
            interactWithEnemiesPlayer1();
            interactWithEnemiesPlayer2();

            movePlayer1();
            movePlayer2();
            
            collectSnowflakesPlayer1();
            collectSnowflakesPlayer2();
            Player1.RehabTimeLeft--;
            Player2.RehabTimeLeft--;

            isPlayerOutOfBounds();
        }
    }
}
