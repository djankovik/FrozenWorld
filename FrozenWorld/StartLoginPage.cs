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
    public partial class StartLoginPage : Form
    {
        public readonly string PATH = @"%USERPROFILE%\Documents\FrozenWorldUserData"; //Where is all this user data saved?
        public User User { get; set; }

        public StartLoginPage()
        {
            InitializeComponent();
            PATH = Environment.ExpandEnvironmentVariables(PATH);
            Directory.CreateDirectory(PATH);    //If a folder does not exist, create it
            var files = Directory.GetFiles(PATH);
            foreach (var file in files)
                if (file.EndsWith(".fwuser"))
                    tbUsername.AutoCompleteCustomSource.Add(System.IO.Path.GetFileNameWithoutExtension(file));
        }
        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbUsername.Text))
                return;

            string userFile = tbUsername.Text;

            if (btnOK.Text == "Continue Game")
            {
                if (User == null)
                    OpenFile(userFile);
            }
            else
            {
                User = new User(userFile);
                SaveFile();
            }

            var levelChooserForm = new LevelChooserForm(User);
            levelChooserForm.Show();
            SaveFile();
            //Close();
        }
        
        private void TbUsername_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbUsername.Text)) return;
            var files = Directory.GetFiles(PATH).Select(f => System.IO.Path.GetFileNameWithoutExtension(f)).ToArray();

            if (files.Contains(tbUsername.Text))
            {
                btnOK.Text = "Continue Game";
                lblWelcomingMessage.Text = "Welcome back " + tbUsername.Text;
            }
            else
            {
                lblWelcomingMessage.Text = "Welcome " + tbUsername.Text;
                btnOK.Text = "Start New Game";
            }
        }

        public void OpenFile(string fileName)
        {
            if (fileName != null)
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream file = File.OpenRead($@"{PATH}\{fileName}.fwuser"))
                    User = (User)formatter.Deserialize(file);
            }
        }
        public void SaveFile()
        {
            string fileName = User.UserName;
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream file = File.Create($@"{PATH}\{fileName}.fwuser"))
                formatter.Serialize(file, User);
        }

        private void BtnViewScoreboard_Click(object sender, EventArgs e)
        {
            List<User> allUsers=new List<User>();
            var files = Directory.GetFiles(PATH);

            foreach (var file in files)
                if (file.EndsWith(".fwuser"))
                {
                    User user;
                    BinaryFormatter formatter = new BinaryFormatter();
                    using (FileStream fileStream = File.OpenRead(file))
                        user = (User)formatter.Deserialize(fileStream);
                    allUsers.Add(user);
                }

            ScoreboardForm scoreboardForm = new ScoreboardForm(allUsers);
            scoreboardForm.ShowDialog();
        }

        private void StartLoginPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }

}
