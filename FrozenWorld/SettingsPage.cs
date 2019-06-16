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
        public List<Image> AVATARS = new List<Image>() { Resources.avatar1Girl, Resources.avatar1Boy, Resources.avatar3Girl, Resources.avatar2Boy, Resources.avatar2Girl, Resources.avatar3Boy };


        public static int padd = 10;

        Rectangle player1SelectedAvatar;
        Rectangle player2SelectedAvatar;
        Image player1AVATAR;
        Image player2AVATAR;

        List<TextBox> textBoxesControls;
        List<Keys> keysControls;
        List<Image> playerAvatars;

        User user;
        public SettingsPage(User u)
        {
            InitializeComponent();
            textBoxesControls = new List<TextBox>();
            keysControls = new List<Keys>();
            playerAvatars = new List<Image>();

            user = u;

            keysControls.AddRange(user.ControlsPlayer1);

            gbPlayer2.Visible = false;

            setUpAvatarsP1();
            setUserAvatar1Selection();
            player1AVATAR = AVATARS[0];

            setUpControlsP1();

            this.Height = gbPlayer1.Height+60;

            if (user.TwoPlayer)
            {
                keysControls.AddRange(user.ControlsPlayer2);

                gbPlayer2.Visible = true;
                setUpAvatarsP2();
                setUserAvatar2Selection();
                player2AVATAR = AVATARS[1];

                setUpControlsP2();
                this.Height = gbPlayer1.Height+gbPlayer2.Height+60;
            }           
        }

        public void setUpAvatarsP1()
        {            
            pb1.Image = AVATARS[0];
            pb2.Image = AVATARS[1];
            pb3.Image = AVATARS[2];
            pb4.Image = AVATARS[3];
            pb5.Image = AVATARS[4];
            pb6.Image = AVATARS[5];            
        }

        public void setUpAvatarsP2()
        {
            pb1p2.Image = AVATARS[0];
            pb2p2.Image = AVATARS[1];
            pb3p2.Image = AVATARS[2];
            pb4p2.Image = AVATARS[3];
            pb5p2.Image = AVATARS[4]; ;
            pb6p2.Image = AVATARS[5];
        }

        public void setUserAvatar1Selection()
        {
            player1SelectedAvatar = new Rectangle(pb1.Location.X-padd, pb1.Location.Y-padd,pb1.Width+2*padd,pb1.Height+2*padd);
            Invalidate(true);
        }
        public void setUserAvatar2Selection()
        {
            player2SelectedAvatar = new Rectangle(pb2p2.Location.X - padd, pb2p2.Location.Y - padd, pb2p2.Width + 2 * padd, pb2p2.Height + 2 * padd);
            Invalidate(true);
        }
        public void setUpControlsP1()
        {
            txtUp.Text = keysControls[0].ToString();
            txtDown.Text = keysControls[1].ToString();
            txtLeft.Text = keysControls[2].ToString();
            txtRight.Text = keysControls[3].ToString();
            txtJump.Text = keysControls[4].ToString();

            textBoxesControls.Add(txtUp);
            textBoxesControls.Add(txtDown);
            textBoxesControls.Add(txtLeft);
            textBoxesControls.Add(txtRight);
            textBoxesControls.Add(txtJump);
        }
        public void setUpControlsP2()
        {
            txtUpP2.Text = keysControls[5].ToString();
            txtDownP2.Text = keysControls[6].ToString();
            txtLeftP2.Text = keysControls[7].ToString();
            txtRightP2.Text = keysControls[8].ToString();
            txtJumpP2.Text = keysControls[9].ToString();

            textBoxesControls.Add(txtUpP2);
            textBoxesControls.Add(txtDownP2);
            textBoxesControls.Add(txtLeftP2);
            textBoxesControls.Add(txtRightP2);
            textBoxesControls.Add(txtJumpP2);
        }
        private void TxtUp_KeyUp(object sender, KeyEventArgs e)
        {
            keysControls[0] = e.KeyCode;
            txtUp.Text = e.KeyCode.ToString();
        }

        private void TxtDown_KeyUp(object sender, KeyEventArgs e)
        {
            keysControls[1] = e.KeyCode;
            txtDown.Text = e.KeyCode.ToString();
        }

        private void TxtLeft_KeyUp(object sender, KeyEventArgs e)
        {
            keysControls[2] = e.KeyCode;
            txtLeft.Text = e.KeyCode.ToString();
        }

        private void TxtRight_KeyUp(object sender, KeyEventArgs e)
        {
            keysControls[3] = e.KeyCode;
            txtRight.Text = e.KeyCode.ToString();
        }

        private void TxtJump_KeyUp(object sender, KeyEventArgs e)
        {
            keysControls[4] = e.KeyCode;
            txtJump.Text = e.KeyCode.ToString();
        }

        private void Pb1_Click(object sender, EventArgs e)
        {
            player1AVATAR = AVATARS[0];
            player1SelectedAvatar = new Rectangle(pb1.Location.X-padd, pb1.Location.Y-padd,pb1.Width+2*padd,pb1.Height+2*padd);
            Invalidate(true);
        }

        private void Pb2_Click(object sender, EventArgs e)
        {
            player1AVATAR = AVATARS[1];
            player1SelectedAvatar = new Rectangle(pb2.Location.X - padd, pb2.Location.Y - padd, pb2.Width + 2 * padd, pb2.Height + 2 * padd);
            Invalidate(true);
        }

        private void Pb3_Click(object sender, EventArgs e)
        {
            player1AVATAR = AVATARS[2];
            player1SelectedAvatar = new Rectangle(pb3.Location.X - padd, pb3.Location.Y - padd, pb3.Width + 2 * padd, pb3.Height + 2 * padd);
            Invalidate(true);
        }

        private void Pb4_Click(object sender, EventArgs e)
        {
            player1AVATAR = AVATARS[3];
            player1SelectedAvatar = new Rectangle(pb4.Location.X - padd, pb4.Location.Y - padd, pb4.Width + 2 * padd, pb4.Height + 2 * padd);
            Invalidate(true);
        }

        private void Pb5_Click(object sender, EventArgs e)
        {
            player1AVATAR = AVATARS[4];
            player1SelectedAvatar = new Rectangle(pb5.Location.X - padd, pb5.Location.Y - padd, pb5.Width + 2 * padd, pb5.Height + 2 * padd);
            Invalidate(true);
        }

        private void Pb6_Click(object sender, EventArgs e)
        {
            player1AVATAR = AVATARS[5];
            player1SelectedAvatar = new Rectangle(pb6.Location.X - padd, pb6.Location.Y - padd, pb6.Width + 2 * padd, pb6.Height + 2 * padd);
            Invalidate(true);
        }

        private void GbPlayer1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Lavender, 5);
            if (player1SelectedAvatar.IsEmpty == false)
                e.Graphics.DrawRectangle(pen, player1SelectedAvatar);
        }

        private void GbPlayer2_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.LavenderBlush, 5);
            if (player2SelectedAvatar.IsEmpty == false)
                e.Graphics.DrawRectangle(pen, player2SelectedAvatar);
        }

        private void TxtUpP2_KeyUp(object sender, KeyEventArgs e)
        {
            keysControls[5] = e.KeyCode;
            txtUpP2.Text = e.KeyCode.ToString();
        }

        private void TxtDownP2_KeyUp(object sender, KeyEventArgs e)
        {
            keysControls[6] = e.KeyCode;
            txtDownP2.Text = e.KeyCode.ToString();
        }

        private void TxtLeftP2_KeyUp(object sender, KeyEventArgs e)
        {
            keysControls[7] = e.KeyCode;
            txtLeftP2.Text = e.KeyCode.ToString();
        }

        private void TxtRightP2_KeyUp(object sender, KeyEventArgs e)
        {
            keysControls[8] = e.KeyCode;
            txtRightP2.Text = e.KeyCode.ToString();
        }

        private void TxtJumpP2_KeyUp(object sender, KeyEventArgs e)
        {
            keysControls[9] = e.KeyCode;
            txtJumpP2.Text = e.KeyCode.ToString();
        }

        private void Pb1p2_Click(object sender, EventArgs e)
        {
            player2AVATAR = AVATARS[0];
            player2SelectedAvatar = new Rectangle(pb1p2.Location.X-padd, pb1p2.Location.Y - padd,pb1p2.Width+2*padd,pb1p2.Height+2*padd);
            Invalidate(true);
        }

        private void Pb2p2_Click(object sender, EventArgs e)
        {
            player2AVATAR = AVATARS[1];
            player2SelectedAvatar = new Rectangle(pb2p2.Location.X - padd, pb2p2.Location.Y - padd, pb2p2.Width + 2 * padd, pb2p2.Height + 2 * padd);
            Invalidate(true);

        }

        private void Pb3p2_Click(object sender, EventArgs e)
        {
            player2AVATAR = AVATARS[2];
            player2SelectedAvatar = new Rectangle(pb3p2.Location.X - padd, pb3p2.Location.Y - padd, pb3p2.Width + 2 * padd, pb3p2.Height + 2 * padd);
            Invalidate(true);

        }

        private void Pb4p2_Click(object sender, EventArgs e)
        {
            player2AVATAR = AVATARS[3];
            player2SelectedAvatar = new Rectangle(pb4p2.Location.X - padd, pb4p2.Location.Y - padd, pb4p2.Width + 2 * padd, pb4p2.Height + 2 * padd);
            Invalidate(true);

        }

        private void Pb5p2_Click(object sender, EventArgs e)
        {
            player2AVATAR = AVATARS[4];
            player2SelectedAvatar = new Rectangle(pb5p2.Location.X - padd, pb5p2.Location.Y - padd, pb5p2.Width + 2 * padd, pb5p2.Height + 2 * padd);
            Invalidate(true);

        }

        private void Pb6p2_Click(object sender, EventArgs e)
        {
            player2AVATAR = AVATARS[5];
            player2SelectedAvatar = new Rectangle(pb6p2.Location.X - padd, pb6p2.Location.Y - padd, pb6p2.Width + 2 * padd, pb6p2.Height + 2 * padd);
            Invalidate(true);

        }

        public bool checkIfControlsAreOk()
        {
            for (int i = 0; i < textBoxesControls.Count; i++)
            {
                for (int j = i+1; j < textBoxesControls.Count; j++)
                {
                    if(textBoxesControls[i].Text == textBoxesControls[j].Text)
                    {
                        MessageBox.Show("No two movents can be dictated by the same control key!");
                        return false;
                    }
                }
            }
            return true;
        }
        private void SettingsPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void BtnSaveChangesPlayer1_Click(object sender, EventArgs e)
        {
            if (checkIfControlsAreOk())
            {
                user.ControlsPlayer1 = new List<Keys>();
                for (int i=0;i<=4;i++)
                {
                    user.ControlsPlayer1.Add(keysControls[i]);
                }
                user.AvatarPlayer1 = player1AVATAR;
                StartLoginPage startPage = new StartLoginPage();
                startPage.SaveFile(user);

                if(!this.user.TwoPlayer)
                  this.Close();
            }
        }

        private void BtnSaveChangesPlayer2_Click(object sender, EventArgs e)
        {
            if (checkIfControlsAreOk())
            {
                user.ControlsPlayer2 = new List<Keys>();
                for (int i = 5; i <= 9; i++)
                {
                    user.ControlsPlayer2.Add(keysControls[i]);
                }
                user.AvatarPlayer2 = player2AVATAR;
                StartLoginPage startPage = new StartLoginPage();
                startPage.SaveFile(user);
                //this.Close();
            }
        }
    }
}
