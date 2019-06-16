using FrozenWorld.Properties;
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
    [Serializable]
    public class User
    {
        public String UserName { get; set; }
        public Dictionary<int,int> LevelScores { get; set; }

        public Image AvatarPlayer1 { get; set; }
        public Image AvatarPlayer2 { get; set; }
        public bool TwoPlayer { get; set; }

        public List<Keys> ControlsPlayer1 { get; set; }
        public List<Keys> ControlsPlayer2 { get; set; }

        public User(String UserName)
        {
            this.UserName = UserName;
            LevelScores = new Dictionary<int, int>();

            TwoPlayer = false;

            AvatarPlayer1 = Resources.avatar1Girl;
            AvatarPlayer2 = Resources.avatar1Boy;

            ControlsPlayer1 = new List<Keys>(){Keys.Up,Keys.Down,Keys.Left,Keys.Right,Keys.Space};
            ControlsPlayer2 = new List<Keys>() { Keys.W, Keys.S, Keys.A, Keys.D, Keys.Capital };
        }

        public void make2Player()
        {
            TwoPlayer = true;            
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

        public void addLevelScore(int level, int score)
        {
            if (LevelScores.ContainsKey(level))
            {
                if (LevelScores[level] < score)
                    LevelScores[level] = score;

                return;
            }
            LevelScores.Add(level, score);
        }

        public void setPlayer1Controls(Keys up, Keys down, Keys left, Keys right, Keys jump)
        {
            ControlsPlayer1 = new List<Keys>() { up,down,left,right,jump };
        }
        public void setPlayer2Controls(Keys up, Keys down, Keys left, Keys right, Keys jump)
        {
            ControlsPlayer2 = new List<Keys>() { up, down, left, right, jump };
        }
    }
}
