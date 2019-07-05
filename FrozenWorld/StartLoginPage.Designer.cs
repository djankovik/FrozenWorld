namespace FrozenWorld
{
    partial class StartLoginPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartLoginPage));
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblWelcomingMessage = new System.Windows.Forms.Label();
            this.btnViewScoreboard = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK2Player = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(21, 109);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(258, 36);
            this.tbUsername.TabIndex = 2;
            this.tbUsername.TextChanged += new System.EventHandler(this.TbUsername_TextChanged);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Lavender;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(21, 151);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(258, 52);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "Start New Game";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // lblWelcomingMessage
            // 
            this.lblWelcomingMessage.AutoSize = true;
            this.lblWelcomingMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcomingMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomingMessage.ForeColor = System.Drawing.Color.Black;
            this.lblWelcomingMessage.Location = new System.Drawing.Point(24, 21);
            this.lblWelcomingMessage.MaximumSize = new System.Drawing.Size(700, 50);
            this.lblWelcomingMessage.Name = "lblWelcomingMessage";
            this.lblWelcomingMessage.Size = new System.Drawing.Size(166, 39);
            this.lblWelcomingMessage.TabIndex = 0;
            this.lblWelcomingMessage.Text = "Welcome";
            // 
            // btnViewScoreboard
            // 
            this.btnViewScoreboard.BackColor = System.Drawing.Color.Lavender;
            this.btnViewScoreboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewScoreboard.Location = new System.Drawing.Point(21, 376);
            this.btnViewScoreboard.Name = "btnViewScoreboard";
            this.btnViewScoreboard.Size = new System.Drawing.Size(258, 46);
            this.btnViewScoreboard.TabIndex = 6;
            this.btnViewScoreboard.Text = "Scoreboard";
            this.btnViewScoreboard.UseVisualStyleBackColor = false;
            this.btnViewScoreboard.Click += new System.EventHandler(this.BtnViewScoreboard_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.Lavender;
            this.btnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Location = new System.Drawing.Point(21, 331);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(258, 39);
            this.btnAbout.TabIndex = 5;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username:";
            // 
            // btnOK2Player
            // 
            this.btnOK2Player.BackColor = System.Drawing.Color.Lavender;
            this.btnOK2Player.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK2Player.Location = new System.Drawing.Point(21, 209);
            this.btnOK2Player.Name = "btnOK2Player";
            this.btnOK2Player.Size = new System.Drawing.Size(258, 48);
            this.btnOK2Player.TabIndex = 4;
            this.btnOK2Player.Text = "Start New 2 Player Game";
            this.btnOK2Player.UseVisualStyleBackColor = false;
            this.btnOK2Player.Click += new System.EventHandler(this.BtnOK2Player_Click);
            // 
            // StartLoginPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(698, 434);
            this.Controls.Add(this.btnOK2Player);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnViewScoreboard);
            this.Controls.Add(this.lblWelcomingMessage);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbUsername);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartLoginPage";
            this.Text = "Start Page";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StartLoginPage_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblWelcomingMessage;
        private System.Windows.Forms.Button btnViewScoreboard;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK2Player;
    }
}