using FrozenWorld.Properties;
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
            this.Height =600;
            this.Width = 500;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.BackgroundImage = Resources.iceStartpage2;
         }

        private void ScoreboardForm_Paint(object sender, PaintEventArgs e)
        {
            Font drawFont = new System.Drawing.Font("Sans Serif", 16);
            SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            int tableTop = 150;
            int yOffset = 40;
            int xOffset = 180;

            e.Graphics.DrawString("SCOREBOARD", new Font("Sans Serif", 25,FontStyle.Bold),drawBrush,110,30);

            e.Graphics.DrawString("UserName", drawFont, drawBrush, 30, tableTop -50);
            e.Graphics.DrawString("Points", drawFont, drawBrush, 30 + xOffset, tableTop - 50);
            e.Graphics.DrawString("Levels", drawFont, drawBrush, 30 + xOffset * 2, tableTop - 50);

            Pen p = new Pen(Color.Black,3);
            e.Graphics.DrawLine(p,new Point(0, tableTop - 15),new Point(this.Width, tableTop-15));

            for (int i=0;i<userPoints.Count;i++)
            {
                e.Graphics.DrawString((i+1).ToString(), drawFont, drawBrush, 5, tableTop + i * yOffset);
                e.Graphics.DrawString(userPoints[i].UserName, drawFont, drawBrush, 40, tableTop +i*yOffset);
                e.Graphics.DrawString(userPoints[i].getTotalPoints().ToString(), drawFont, drawBrush, 40+xOffset, tableTop + i * yOffset);
                e.Graphics.DrawString(userPoints[i].LevelScores.Keys.Count.ToString(), drawFont, drawBrush, 40+xOffset*2, tableTop + i * yOffset);

            }
            drawFont.Dispose();
            drawBrush.Dispose();            
        }
    }
}
