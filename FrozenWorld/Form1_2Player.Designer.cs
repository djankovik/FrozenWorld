namespace FrozenWorld
{
    partial class Form1_2Player
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsspbPlayer1FrozenMeter = new System.Windows.Forms.ToolStripProgressBar();
            this.tsslPlayer1Lives = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsspbPlayer2FrozenMeter = new System.Windows.Forms.ToolStripProgressBar();
            this.tsslPlayer2Lives = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tsslPlayer1Snowflakes = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslPlayer2Snowflakes = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Black;
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslPlayer1Snowflakes,
            this.toolStripStatusLabel5,
            this.tsspbPlayer1FrozenMeter,
            this.tsslPlayer1Lives,
            this.tsslPlayer2Snowflakes,
            this.toolStripStatusLabel2,
            this.tsspbPlayer2FrozenMeter,
            this.tsslPlayer2Lives});
            this.statusStrip1.Location = new System.Drawing.Point(0, 508);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1186, 28);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.Paint += new System.Windows.Forms.PaintEventHandler(this.StatusStrip1_Paint_1);
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(122, 23);
            this.toolStripStatusLabel5.Text = "Freeze Meter1:";
            // 
            // tsspbPlayer1FrozenMeter
            // 
            this.tsspbPlayer1FrozenMeter.Name = "tsspbPlayer1FrozenMeter";
            this.tsspbPlayer1FrozenMeter.Size = new System.Drawing.Size(100, 22);
            // 
            // tsslPlayer1Lives
            // 
            this.tsslPlayer1Lives.ForeColor = System.Drawing.Color.White;
            this.tsslPlayer1Lives.Margin = new System.Windows.Forms.Padding(0, 3, 10, 2);
            this.tsslPlayer1Lives.Name = "tsslPlayer1Lives";
            this.tsslPlayer1Lives.Size = new System.Drawing.Size(101, 23);
            this.tsslPlayer1Lives.Text = "Player1Lives";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(122, 23);
            this.toolStripStatusLabel2.Text = "Freeze Meter2:";
            // 
            // tsspbPlayer2FrozenMeter
            // 
            this.tsspbPlayer2FrozenMeter.Name = "tsspbPlayer2FrozenMeter";
            this.tsspbPlayer2FrozenMeter.Size = new System.Drawing.Size(100, 22);
            // 
            // tsslPlayer2Lives
            // 
            this.tsslPlayer2Lives.ForeColor = System.Drawing.Color.White;
            this.tsslPlayer2Lives.Name = "tsslPlayer2Lives";
            this.tsslPlayer2Lives.Size = new System.Drawing.Size(101, 23);
            this.tsslPlayer2Lives.Text = "Player2Lives";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick_1);
            // 
            // tsslPlayer1Snowflakes
            // 
            this.tsslPlayer1Snowflakes.ForeColor = System.Drawing.Color.White;
            this.tsslPlayer1Snowflakes.Image = global::FrozenWorld.Properties.Resources.player;
            this.tsslPlayer1Snowflakes.Name = "tsslPlayer1Snowflakes";
            this.tsslPlayer1Snowflakes.Size = new System.Drawing.Size(168, 23);
            this.tsslPlayer1Snowflakes.Text = "Player1Snowflakes";
            // 
            // tsslPlayer2Snowflakes
            // 
            this.tsslPlayer2Snowflakes.ForeColor = System.Drawing.Color.White;
            this.tsslPlayer2Snowflakes.Image = global::FrozenWorld.Properties.Resources.player2;
            this.tsslPlayer2Snowflakes.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
            this.tsslPlayer2Snowflakes.Name = "tsslPlayer2Snowflakes";
            this.tsslPlayer2Snowflakes.Size = new System.Drawing.Size(168, 23);
            this.tsslPlayer2Snowflakes.Text = "Player2Snowflakes";
            // 
            // Form1_2Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 536);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1_2Player";
            this.Text = "Game 2 Player";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_2Player_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_2Player_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_2Player_KeyUp);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslPlayer1Snowflakes;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripProgressBar tsspbPlayer1FrozenMeter;
        private System.Windows.Forms.ToolStripStatusLabel tsslPlayer1Lives;
        private System.Windows.Forms.ToolStripStatusLabel tsslPlayer2Snowflakes;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripProgressBar tsspbPlayer2FrozenMeter;
        private System.Windows.Forms.ToolStripStatusLabel tsslPlayer2Lives;
        private System.Windows.Forms.Timer timer1;
    }
}