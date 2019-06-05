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

        public void timerTick()
        {
            bool before = false;
            bool after = false;

            Player.timerTick();

            foreach (Enemy e in Enemies)
            {
                before = e.isFrozen;
                if (e.Freeze(Player))
                {
                    if(Player.isJumping == false)
                    {
                        Player.GRAVITY = 8;
                        Player.X = e.X + Player.Height;
                    }
                }
                e.timerTick();
                after = e.isFrozen;

                if (before != after)
                {
                    frozenBlocks++;
                }
            }
            foreach (Platform p in Platforms)
            {
                before = p.isFrozen;
                if (p.Freeze(Player))
                {
                    if (Player.isJumping == false)
                    {
                        Player.GRAVITY = 8;
                        Player.X = p.X + Player.Height;
                    }
                }
                after = p.isFrozen;
                if (before != after)
                {
                    frozenBlocks++;
                }
            }
            foreach (Stairs st in Stairs)
            {
                before = st.isFrozen;

                st.Freeze(Player);
                if (Player.getRectagleWithPadding(0,2,0,0).IntersectsWith(st.getRectagle()))
                {
                    Player.isOnStairs = true;
                }
                after = st.isFrozen;
                if (before != after)
                {
                    frozenBlocks++;
                }
            }

            for(int i=0;i<Snowflakes.Count;i++)
            {
                if (Snowflakes[i].Collect(Player)){
                    collectedSnowflakes++;
                    Snowflakes.RemoveAt(i);
                    i--;
                }
            }
        }

    }
}
