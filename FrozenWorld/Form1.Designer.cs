namespace FrozenWorld
{
    partial class Form1
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslSnowflakes = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsspbFreezables = new System.Windows.Forms.ToolStripProgressBar();
            this.tsslLivesLeft = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbPausePlay = new System.Windows.Forms.PictureBox();
            this.pbRestart = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPausePlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRestart)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Black;
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslSnowflakes,
            this.toolStripStatusLabel1,
            this.tsspbFreezables,
            this.tsslLivesLeft});
            this.statusStrip1.Location = new System.Drawing.Point(0, 469);
            this.statusStrip1.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1310, 33);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.Paint += new System.Windows.Forms.PaintEventHandler(this.StatusStrip1_Paint);
            // 
            // tsslSnowflakes
            // 
            this.tsslSnowflakes.ForeColor = System.Drawing.Color.White;
            this.tsslSnowflakes.Margin = new System.Windows.Forms.Padding(4, 3, 20, 2);
            this.tsslSnowflakes.Name = "tsslSnowflakes";
            this.tsslSnowflakes.Size = new System.Drawing.Size(200, 28);
            this.tsslSnowflakes.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel1.Margin = new System.Windows.Forms.Padding(20, 3, 0, 2);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(125, 28);
            this.toolStripStatusLabel1.Text = "FreezeMeter";
            // 
            // tsspbFreezables
            // 
            this.tsspbFreezables.BackColor = System.Drawing.Color.DarkBlue;
            this.tsspbFreezables.Margin = new System.Windows.Forms.Padding(3);
            this.tsspbFreezables.Name = "tsspbFreezables";
            this.tsspbFreezables.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsspbFreezables.Size = new System.Drawing.Size(160, 27);
            // 
            // tsslLivesLeft
            // 
            this.tsslLivesLeft.ActiveLinkColor = System.Drawing.Color.Red;
            this.tsslLivesLeft.ForeColor = System.Drawing.Color.White;
            this.tsslLivesLeft.Margin = new System.Windows.Forms.Padding(20, 3, 0, 2);
            this.tsslLivesLeft.Name = "tsslLivesLeft";
            this.tsslLivesLeft.Size = new System.Drawing.Size(200, 28);
            this.tsslLivesLeft.Text = "toolStripStatusLabel1";
            // 
            // pbPausePlay
            // 
            this.pbPausePlay.BackColor = System.Drawing.Color.Transparent;
            this.pbPausePlay.Image = global::FrozenWorld.Properties.Resources.pause;
            this.pbPausePlay.Location = new System.Drawing.Point(950, 22);
            this.pbPausePlay.Name = "pbPausePlay";
            this.pbPausePlay.Size = new System.Drawing.Size(43, 39);
            this.pbPausePlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPausePlay.TabIndex = 1;
            this.pbPausePlay.TabStop = false;
            this.pbPausePlay.Click += new System.EventHandler(this.PbPausePlay_Click);
            // 
            // pbRestart
            // 
            this.pbRestart.BackColor = System.Drawing.Color.Transparent;
            this.pbRestart.Image = global::FrozenWorld.Properties.Resources.restart;
            this.pbRestart.Location = new System.Drawing.Point(887, 22);
            this.pbRestart.Name = "pbRestart";
            this.pbRestart.Size = new System.Drawing.Size(37, 39);
            this.pbRestart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRestart.TabIndex = 2;
            this.pbRestart.TabStop = false;
            this.pbRestart.Click += new System.EventHandler(this.PbRestart_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1310, 502);
            this.Controls.Add(this.pbRestart);
            this.Controls.Add(this.pbPausePlay);
            this.Controls.Add(this.statusStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Frozen World";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPausePlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRestart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar tsspbFreezables;
        private System.Windows.Forms.ToolStripStatusLabel tsslLivesLeft;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsslSnowflakes;
        private System.Windows.Forms.PictureBox pbPausePlay;
        private System.Windows.Forms.PictureBox pbRestart;
    }
}

