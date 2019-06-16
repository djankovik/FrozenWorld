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
    public partial class SettingsPage : Form
    {
        Rectangle player1SelectedAvatar;
        Rectangle player2Avatar;
        public SettingsPage()
        {
            InitializeComponent();
            groupBox1.Visible = false;

            setUpAvatars();
        }

        public void setUpAvatars()
        {
            
            pb1.Image = Resources.avatar1Girl;
            pb2.Image = Resources.avatar1Girl;
            pb3.Image = Resources.avatar1Girl;
            pb4.Image = Resources.avatar1Girl;
            pb5.Image = Resources.avatar1Girl;
            pb6.Image = Resources.avatar1Girl;
        }
        private void TxtUp_KeyUp(object sender, KeyEventArgs e)
        {
            txtUp.Text = e.KeyCode.ToString();
        }

        private void TxtDown_KeyUp(object sender, KeyEventArgs e)
        {
            txtDown.Text = e.KeyCode.ToString();
        }

        private void TxtLeft_KeyUp(object sender, KeyEventArgs e)
        {
            txtLeft.Text = e.KeyCode.ToString();
        }

        private void TxtRight_KeyUp(object sender, KeyEventArgs e)
        {
            txtRight.Text = e.KeyCode.ToString();
        }

        private void TxtJump_KeyUp(object sender, KeyEventArgs e)
        {
            txtJump.Text = e.KeyCode.ToString();
        }

        private void Pb1_Click(object sender, EventArgs e)
        {
            int padd = 5;
            player1SelectedAvatar = new Rectangle(pb1.Location.X-padd, pb1.Location.Y-padd,pb1.Width+2*padd,pb1.Height+2*padd);
            Invalidate(true);
        }

        private void Pb2_Click(object sender, EventArgs e)
        {
            int padd = 5;
            player1SelectedAvatar = new Rectangle(pb2.Location.X - padd, pb2.Location.Y - padd, pb2.Width + 2 * padd, pb2.Height + 2 * padd);
            Invalidate(true);
        }

        private void Pb3_Click(object sender, EventArgs e)
        {
            int padd = 5;
            player1SelectedAvatar = new Rectangle(pb3.Location.X - padd, pb3.Location.Y - padd, pb3.Width + 2 * padd, pb3.Height + 2 * padd);
            Invalidate(true);
        }

        private void Pb4_Click(object sender, EventArgs e)
        {
            int padd = 5;
            player1SelectedAvatar = new Rectangle(pb4.Location.X - padd, pb4.Location.Y - padd, pb4.Width + 2 * padd, pb4.Height + 2 * padd);
            Invalidate(true);
        }

        private void Pb5_Click(object sender, EventArgs e)
        {
            int padd = 5;
            player1SelectedAvatar = new Rectangle(pb5.Location.X - padd, pb5.Location.Y - padd, pb5.Width + 2 * padd, pb5.Height + 2 * padd);
            Invalidate(true);
        }

        private void Pb6_Click(object sender, EventArgs e)
        {
            int padd = 5;
            player1SelectedAvatar = new Rectangle(pb6.Location.X - padd, pb6.Location.Y - padd, pb6.Width + 2 * padd, pb6.Height + 2 * padd);
            Invalidate(true);
        }

        private void SettingsPage_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Red,5);
            if(player1SelectedAvatar.IsEmpty == false)
            e.Graphics.DrawRectangle(pen,player1SelectedAvatar);
        }
    }
}
