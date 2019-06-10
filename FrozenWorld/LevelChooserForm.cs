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
            foreach (Control cntrl in Controls)
            {
                if (cntrl is PictureBox)
                {
                    PictureBox pb = (PictureBox)cntrl;
                    int pbNr;
                    if (Int32.TryParse(pb.Name.Substring(10), out pbNr))
                    {
                        if (levels.Contains(pbNr) || levels.Contains(pbNr - 1) || pbNr == 1)
                        {
                            pb.Image = Resources.UnlockedLevel;
                            pb.Tag = "Unlocked";
                        }
                        else
                        {
                            pb.Image = Resources.LockedLevel;
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
                            lbl.BackColor = Color.Transparent;
                            lbl.Text = lblNr.ToString();
                            lbl.Tag = "Unlocked";
                        }
                        else
                        {
                            lbl.BackColor = Color.Transparent;
                            lbl.Text = "X";
                            lbl.Tag = "Locked";
                        }
                    }
                }

            }
        }

        public void levelClicked(int level)
        {
            if(levels.Contains(level) || levels.Contains(level-1) || level == 1)
            {
                Game g = DummyData.getLevel(level);
                Form1 formGame = new Form1(g);
                formGame.UserPlayingThisGame= this.currentUser;
                g.LEVELID = level;
                formGame.ShowDialog();
                this.Close();
            }
        }
        private void Lbl1_Click(object sender, EventArgs e)
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

        private void Lbl16_Click(object sender, EventArgs e)
        {
            levelClicked(16);
        }

        private void PictureBox16_Click(object sender, EventArgs e)
        {
            levelClicked(16);
        }

        private void Lbl17_Click(object sender, EventArgs e)
        {
            levelClicked(17);
        }

        private void PictureBox17_Click(object sender, EventArgs e)
        {
            levelClicked(17);
        }

        private void Lbl18_Click(object sender, EventArgs e)
        {
            levelClicked(18);
        }

        private void PictureBox18_Click(object sender, EventArgs e)
        {
            levelClicked(18);
        }

        private void Lbl19_Click(object sender, EventArgs e)
        {
            levelClicked(19);
        }

        private void PictureBox19_Click(object sender, EventArgs e)
        {
            levelClicked(19);
        }

        private void PictureBox20_Click(object sender, EventArgs e)
        {
            levelClicked(20);
        }

        private void Lbl20_Click(object sender, EventArgs e)
        {
            levelClicked(20);
        }

        private void Lbl21_Click(object sender, EventArgs e)
        {
            levelClicked(21);
        }

        private void PictureBox21_Click(object sender, EventArgs e)
        {
            levelClicked(21);
        }

        private void Lbl22_Click(object sender, EventArgs e)
        {
            levelClicked(22);
        }

        private void PictureBox22_Click(object sender, EventArgs e)
        {
            levelClicked(22);
        }

        private void Lbl23_Click(object sender, EventArgs e)
        {
            levelClicked(23);
        }

        private void PictureBox23_Click(object sender, EventArgs e)
        {
            levelClicked(23);
        }

        private void Lbl24_Click(object sender, EventArgs e)
        {
            levelClicked(24);
        }

        private void PictureBox24_Click(object sender, EventArgs e)
        {
            levelClicked(24);
        }

        private void Lbl25_Click(object sender, EventArgs e)
        {
            levelClicked(25);
        }

        private void PictureBox25_Click(object sender, EventArgs e)
        {
            levelClicked(25);
        }

        private void Lbl26_Click(object sender, EventArgs e)
        {
            levelClicked(26);
        }

        private void PictureBox26_Click(object sender, EventArgs e)
        {
            levelClicked(26);
        }

        private void Lbl27_Click(object sender, EventArgs e)
        {
            levelClicked(27);
        }

        private void PictureBox27_Click(object sender, EventArgs e)
        {
            levelClicked(27);
        }

        private void Lbl28_Click(object sender, EventArgs e)
        {
            levelClicked(28);
        }

        private void PictureBox28_Click(object sender, EventArgs e)
        {
            levelClicked(28);
        }

        private void Lbl29_Click(object sender, EventArgs e)
        {
            levelClicked(29);
        }

        private void PictureBox29_Click(object sender, EventArgs e)
        {
            levelClicked(29);
        }

        private void Lbl30_Click(object sender, EventArgs e)
        {
            levelClicked(30);
        }

        private void PictureBox30_Click(object sender, EventArgs e)
        {
            levelClicked(30);
        }

        private void Lbl31_Click(object sender, EventArgs e)
        {
            levelClicked(31);
        }

        private void PictureBox31_Click(object sender, EventArgs e)
        {
            levelClicked(31);

        }

        private void Lbl32_Click(object sender, EventArgs e)
        {
            levelClicked(32);
        }

        private void PictureBox32_Click(object sender, EventArgs e)
        {
            levelClicked(32);
        }

        private void Lbl33_Click(object sender, EventArgs e)
        {
            levelClicked(33);
        }

        private void PictureBox33_Click(object sender, EventArgs e)
        {
            levelClicked(33);
        }

        private void Lbl34_Click(object sender, EventArgs e)
        {
            levelClicked(34);
        }

        private void PictureBox34_Click(object sender, EventArgs e)
        {
            levelClicked(34);
        }

        private void Lbl35_Click(object sender, EventArgs e)
        {
            levelClicked(35);
        }

        private void PictureBox35_Click(object sender, EventArgs e)
        {
            levelClicked(35);
        }
    }
}
