using System;
using System.Collections.Generic;
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
            STILL, UP, DOWN, LEFT, RIGHT
        }

        public List<Enemy> Enemies { get; set; }
        public List<Platform> Platforms { get; set; }
        public List<Stairs> Stairs { get; set; }
        public List<Snowflake> Snowflakes { get; set; }
        public Player Player { get; set; }


    }
}
