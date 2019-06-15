namespace FrozenWorld
{
    partial class SettingsPage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsPage));
            this.gbPlayer1 = new System.Windows.Forms.GroupBox();
            this.gbPlayer2 = new System.Windows.Forms.GroupBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // gbPlayer1
            // 
            this.gbPlayer1.BackColor = System.Drawing.Color.Black;
            this.gbPlayer1.ForeColor = System.Drawing.Color.White;
            this.gbPlayer1.Location = new System.Drawing.Point(13, 13);
            this.gbPlayer1.Name = "gbPlayer1";
            this.gbPlayer1.Size = new System.Drawing.Size(775, 293);
            this.gbPlayer1.TabIndex = 0;
            this.gbPlayer1.TabStop = false;
            this.gbPlayer1.Text = "Player 1";
            // 
            // gbPlayer2
            // 
            this.gbPlayer2.BackColor = System.Drawing.Color.Black;
            this.gbPlayer2.ForeColor = System.Drawing.Color.White;
            this.gbPlayer2.Location = new System.Drawing.Point(13, 312);
            this.gbPlayer2.Name = "gbPlayer2";
            this.gbPlayer2.Size = new System.Drawing.Size(775, 307);
            this.gbPlayer2.TabIndex = 1;
            this.gbPlayer2.TabStop = false;
            this.gbPlayer2.Text = "Player 2";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "avatalPinkWings.png");
            this.imageList1.Images.SetKeyName(1, "avatar1Boy.png");
            this.imageList1.Images.SetKeyName(2, "avatar1Girl.png");
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(805, 633);
            this.Controls.Add(this.gbPlayer2);
            this.Controls.Add(this.gbPlayer1);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPlayer1;
        private System.Windows.Forms.GroupBox gbPlayer2;
        private System.Windows.Forms.ImageList imageList1;
    }
}