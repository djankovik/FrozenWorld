﻿namespace FrozenWorld
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
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblWelcomingMessage = new System.Windows.Forms.Label();
            this.btnViewScoreboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(34, 93);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(278, 45);
            this.tbUsername.TabIndex = 0;
            this.tbUsername.TextChanged += new System.EventHandler(this.TbUsername_TextChanged);
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(34, 172);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(278, 49);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "Start New Game";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // lblWelcomingMessage
            // 
            this.lblWelcomingMessage.AutoSize = true;
            this.lblWelcomingMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomingMessage.Location = new System.Drawing.Point(27, 31);
            this.lblWelcomingMessage.Name = "lblWelcomingMessage";
            this.lblWelcomingMessage.Size = new System.Drawing.Size(159, 39);
            this.lblWelcomingMessage.TabIndex = 2;
            this.lblWelcomingMessage.Text = "Welcome";
            // 
            // btnViewScoreboard
            // 
            this.btnViewScoreboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewScoreboard.Location = new System.Drawing.Point(34, 302);
            this.btnViewScoreboard.Name = "btnViewScoreboard";
            this.btnViewScoreboard.Size = new System.Drawing.Size(278, 46);
            this.btnViewScoreboard.TabIndex = 3;
            this.btnViewScoreboard.Text = "Show Scoreboard";
            this.btnViewScoreboard.UseVisualStyleBackColor = true;
            this.btnViewScoreboard.Click += new System.EventHandler(this.BtnViewScoreboard_Click);
            // 
            // StartLoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 450);
            this.Controls.Add(this.btnViewScoreboard);
            this.Controls.Add(this.lblWelcomingMessage);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbUsername);
            this.Name = "StartLoginPage";
            this.Text = "StartLoginPage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StartLoginPage_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblWelcomingMessage;
        private System.Windows.Forms.Button btnViewScoreboard;
    }
}