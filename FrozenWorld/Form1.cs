﻿using FrozenWorld.Properties;
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
    public partial class Form1 : Form
    {
        Game game;
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            game = DummyData.getLevel1();
            this.Width = game.maxRight;
            this.Height = game.maxDown;

            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            game.timerTick();
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
            if (e.KeyCode == Keys.Space && !game.Player.isJumping)
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
    }
}
