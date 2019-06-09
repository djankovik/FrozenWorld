using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrozenWorld
{
    [Serializable]
    public class User
    {
        public String UserName { get; set; }
        public Dictionary<int,int> LevelScores { get; set; }

        public User(String UserName)
        {
            this.UserName = UserName;
            LevelScores = new Dictionary<int, int>();
        }

        public int getTotalPoints()
        {
            int total = 0;
            foreach(int i in LevelScores.Values)
            {
                total += i;
            }
            return total;
        }

        public void addLevelScore(int level,int score)
        {
            if (LevelScores.ContainsKey(level))
            {
                if (LevelScores[level] < score)
                    LevelScores[level] = score;

                return;
            }
                LevelScores.Add(level, score);
        }
    }
}
