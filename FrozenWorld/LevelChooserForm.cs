using FrozenWorld.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrozenWorld
{
    public partial class LevelChooserForm : Form
    {
        public User currentUser;
        public List<int> levels;

       public LevelChooserForm(User currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            levels = currentUser.LevelScores.Keys.ToList();
            drawForm();
           
        }
        
        public void drawForm()
        {
            levels = currentUser.LevelScores.Keys.ToList();
            foreach (Control cntrl in Controls)
            {
                if (cntrl is PictureBox)
                {
                    PictureBox pb = (PictureBox)cntrl;
                        int pbNr;
                        if (Int32.TryParse(pb.Name.Substring(10), out pbNr))
                        {
                           pb.SizeMode = PictureBoxSizeMode.StretchImage;
                            if (levels.Contains(pbNr) || levels.Contains(pbNr - 1) || pbNr == 1)
                            {
                                pb.Image = Resources.ScoreBoardBG;
                                pb.Tag = "Unlocked";
                            }
                            else
                            {
                                pb.Image = Resources.ForestNatureNight;
                                pb.Tag = "Locked";
                            }                  
                        }
                }
                
            }

            foreach (Control cntrl in Controls)
            {
                if (cntrl is Label)
                {
                    Label lbl = (Label)cntrl;
                    int lblNr;
                    if (Int32.TryParse(lbl.Name.Substring(3), out lblNr))
                    {
                        if (levels.Contains(lblNr) || levels.Contains(lblNr - 1) || lblNr == 1)
                        {
                            lbl.BackgroundImage = Resources.ScoreBoardBG;
                            lbl.ForeColor = Color.Black;
                            lbl.Text = lblNr.ToString();
                            lbl.Tag = "Unlocked";
                            
                        }
                        else
                        {
                            lbl.BackgroundImage = Resources.ForestNatureNight;
                            lbl.ForeColor = Color.White;
                            lbl.Text = "X";
                            lbl.Tag = "Locked";
                            //if(lblNr>10)
                             //lbl.Location = new Point(lbl.Location.X + 10, lbl.Location.Y);
                        }
                    }
                }
            }
        }

        public void levelClicked(int level)
        {
            if(levels.Contains(level) || levels.Contains(level-1) || level == 1)
            {
                if (currentUser.TwoPlayer)
                {
                    Game2Player g = DummyData.getLevel2Player(level);
                    Form1_2Player formGame = new Form1_2Player(g, currentUser);
                    formGame.ShowDialog();
                    
                }
                else
                {
                    Game g = DummyData.getLevel(level);
                    Form1 formGame = new Form1(g, currentUser);
                    formGame.ShowDialog();
                    
                }
                this.drawForm();
            }
        }

        private void Lbl1_Click_1(object sender, EventArgs e)
        {
            levelClicked(1);
        }
        
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            levelClicked(1);
        }

        private void Lbl2_Click(object sender, EventArgs e)
        {
            levelClicked(2);
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            levelClicked(2);
        }

        private void Lbl3_Click(object sender, EventArgs e)
        {
            levelClicked(3);
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            levelClicked(3);
        }

        private void Lbl4_Click(object sender, EventArgs e)
        {
            levelClicked(4);
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            levelClicked(4);
        }

        private void Lbl5_Click(object sender, EventArgs e)
        {
            levelClicked(5);
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            levelClicked(5);
        }

        private void Lbl6_Click(object sender, EventArgs e)
        {
            levelClicked(6);
        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            levelClicked(6);
        }

        private void Lbl7_Click(object sender, EventArgs e)
        {
            levelClicked(7);
        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {
            levelClicked(7);
        }

        private void Lbl8_Click(object sender, EventArgs e)
        {
            levelClicked(8);
        }

        private void PictureBox8_Click(object sender, EventArgs e)
        {
            levelClicked(8);
        }

        private void Lbl9_Click(object sender, EventArgs e)
        {
            levelClicked(9);
        }

        private void PictureBox9_Click(object sender, EventArgs e)
        {
            levelClicked(9);
        }

        private void Lbl10_Click(object sender, EventArgs e)
        {
            levelClicked(10);
        }

        private void PictureBox10_Click(object sender, EventArgs e)
        {
            levelClicked(10);
        }

        private void Lbl11_Click(object sender, EventArgs e)
        {
            levelClicked(11);
        }

        private void PictureBox11_Click(object sender, EventArgs e)
        {
            levelClicked(11);
        }

        private void Lbl12_Click(object sender, EventArgs e)
        {
            levelClicked(12);
        }

        private void PictureBox12_Click(object sender, EventArgs e)
        {
            levelClicked(12);
        }

        private void Lbl13_Click(object sender, EventArgs e)
        {
            levelClicked(13);
        }

        private void PictureBox13_Click(object sender, EventArgs e)
        {
            levelClicked(13);
        }

        private void Lbl14_Click(object sender, EventArgs e)
        {
            levelClicked(14);
        }

        private void PictureBox14_Click(object sender, EventArgs e)
        {
            levelClicked(14);
        }

        private void Lbl15_Click(object sender, EventArgs e)
        {
            levelClicked(15);
        }

        private void PictureBox15_Click(object sender, EventArgs e)
        {
            levelClicked(15);
        }

        
        private void BtnSettings_Click(object sender, EventArgs e)
        {
            SettingsPage settings = new SettingsPage(currentUser);
            settings.ShowDialog();                       
        }

        private void LevelChooserForm_Paint(object sender, PaintEventArgs e)
        {
           e.Graphics.DrawImage(Resources.Levels, new Rectangle(150, 15, 180, 80));
        }

    }
}
