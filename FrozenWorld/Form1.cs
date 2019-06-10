﻿using FrozenWorld.Properties;
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
    public partial class Form1 : Form
    {
        public readonly string PATH = @"%USERPROFILE%\Documents\FrozenWorldUserData";

        Game game;
        public Form1(Game Game)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            
            newGame(Game);

            timer1.Start();
        }

        public void newGame(Game Game)
        {
            this.game = Game;
            this.Width = game.maxRight;
            this.Height = game.maxDown;
            tsspbFreezables.Maximum = game.TOTALITEMSTOFREEZE;
            tsspbFreezables.Value = 0;

            this.BackgroundImage = game.BACKGROUNDIMAGE;
            
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            game.timerTick();
            if (game.isPlayerOutOfBounds())
            {
                timer1.Stop();
                MessageBox.Show("Player out of bounds");
            }
            Invalidate(true);
            if (game.isGameWon())
            {
                timer1.Stop();
                MessageBox.Show("Game WON! " + game.TOTALITEMSTOFREEZE + " / " + game.TOTALITEMSTOFREEZE + " frozen blocks.");
                this.Close();
            }
            if (game.isGameLost())
            {
                timer1.Stop();
                MessageBox.Show("Game LOST!");
            }
            Invalidate(true);
        }
        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            game.Draw(e.Graphics);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                game.Player.isGoingLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                game.Player.isGoingRight = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                game.Player.isGoingUp = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                game.Player.isGoingDown = true;
            }
            if (e.KeyCode == Keys.Space && !game.Player.isJumping && game.isPlayerOnJumpablePlatform())
            {
                game.Player.isJumping = true;
            }

            Invalidate(true);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                game.Player.isGoingLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                game.Player.isGoingRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                game.Player.isGoingUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                game.Player.isGoingDown = false;
            }
            if (e.KeyCode == Keys.Space) 
            {
                game.Player.isJumping = false;
            }
            Invalidate(true);
        }

        private void StatusStrip1_Paint(object sender, PaintEventArgs e)
        {
            statusStrip1.ForeColor = Color.White;
            tsslSnowflakes.Text = string.Format("Snowflakes: {0}/{1}",game.collectedSnowflakes,game.TOTALSNOWFLAKES);
            tsspbFreezables.Value = game.getFrozenBlockNumber();
            tsslLivesLeft.Text = string.Format("Lives left: {0}/{1}", game.Player.LivesLeft, 5);
        }
    }
}
