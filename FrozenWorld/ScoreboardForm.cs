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
            this.Width = 600;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.BackColor=Color.Black;
         }

        private void ScoreboardForm_Paint(object sender, PaintEventArgs e)
        {
            Font drawFont = new System.Drawing.Font("Sans Serif", 16);
            SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
            int tableTop = 170;
            int yOffset = 40;
            int xOffset = 190;

            //e.Graphics.DrawString("SCOREBOARD", new Font("Sans Serif", 25,FontStyle.Bold),drawBrush,120,30);

            e.Graphics.DrawString("UserName", drawFont, drawBrush, 50, tableTop -50);
            e.Graphics.DrawString("Points", drawFont, drawBrush, 50 + xOffset, tableTop - 50);
            e.Graphics.DrawString("Levels", drawFont, drawBrush, 50 + xOffset * 2, tableTop - 50);

            Pen p = new Pen(Color.White,3);
            e.Graphics.DrawLine(p,new Point(0, tableTop - 15),new Point(this.Width, tableTop-15));

            for (int i=0;i<userPoints.Count;i++)
            {
                e.Graphics.DrawString((i+1).ToString(), drawFont, drawBrush, 5, tableTop + i * yOffset);
                e.Graphics.DrawString(userPoints[i].UserName, drawFont, drawBrush, 55, tableTop +i*yOffset);
                e.Graphics.DrawString(userPoints[i].getTotalPoints().ToString(), drawFont, drawBrush, 55+xOffset, tableTop + i * yOffset);
                e.Graphics.DrawString(userPoints[i].LevelScores.Keys.Count.ToString(), drawFont, drawBrush, 55+xOffset*2, tableTop + i * yOffset);

            }

            pictureBox1.Location = new Point(this.Width/2-pictureBox1.Width/2,pictureBox1.Location.Y);
            drawFont.Dispose();
            drawBrush.Dispose();            
        }
    }
}
