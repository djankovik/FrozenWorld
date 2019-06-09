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
                        }
                        else
                        {
                            pb.Image = Resources.LockedLevel;
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
                        }
                        else
                        {
                            lbl.BackColor = Color.Transparent;
                            lbl.Text = "X";                           
                        }
                    }
                }

            }
        }

    }
}
