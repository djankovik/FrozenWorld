using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrozenWorld
{
    public partial class ScoreboardForm : Form
    {
       List<User> userPoints;
        public ScoreboardForm(List<User> allUsers)
        {
            InitializeComponent();
            userPoints = allUsers.OrderByDescending(o => o.getTotalPoints()).ThenByDescending(o => o.LevelScores.Keys.Count).ToList();
            this.Height =400;
            this.Width = 600;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void ScoreboardForm_Paint(object sender, PaintEventArgs e)
        {
            Font drawFont = new System.Drawing.Font("Arial", 16);
            SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            int tableTop = 100;
            int yOffset = 150;
            int xOffset = 50;

            for(int i=0;i<userPoints.Count;i++)
            {
                e.Graphics.DrawString(userPoints[i].UserName, drawFont, drawBrush, 0, tableTop +i*xOffset);
                e.Graphics.DrawString(userPoints[i].getTotalPoints().ToString(), drawFont, drawBrush, yOffset, tableTop + i * xOffset);
                e.Graphics.DrawString(userPoints[i].LevelScores.Keys.Count.ToString(), drawFont, drawBrush, yOffset*2, tableTop + i * xOffset);

            }
            drawFont.Dispose();
            drawBrush.Dispose();            
        }
    }
}
