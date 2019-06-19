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
    public partial class Form1_2Player : Form
    {
        public User UserPlayingThisGame { get; set; }

        Game2Player game;
        public Form1_2Player(Game2Player Game,User u)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            UserPlayingThisGame = u;
            newGame(Game);
        }

        public void newGame(Game2Player Game)
        {
            this.game = Game;
            this.Width = game.maxRight;
            this.Height = game.maxDown;

            tsspbPlayer1FrozenMeter.Maximum = game.TOTALITEMSTOFREEZE;
            tsspbPlayer1FrozenMeter.Value = 0;
            tsspbPlayer2FrozenMeter.Maximum = game.TOTALITEMSTOFREEZE;

            tsspbPlayer2FrozenMeter.Value = 0;
            this.Text = "Level " + (game.LEVELID);
            this.BackgroundImage = game.BACKGROUNDIMAGE;

            game.Player1.Image = UserPlayingThisGame.AvatarPlayer1;
            game.Player2.Image = UserPlayingThisGame.AvatarPlayer2;

            timer1.Start();

        }
        

        public void SaveFile()
        {
            StartLoginPage slp = new StartLoginPage();
            slp.SaveFile(UserPlayingThisGame);
            slp.Dispose();
        }
        public void resetGame()
        {
            Game2Player g = DummyData.getLevel2Player(this.game.LEVELID);
            newGame(g);
        }
        public void nextLevel()
        {
            Game2Player g = DummyData.getLevel2Player(this.game.LEVELID+1);
            newGame(g);
        }

        private void Timer1_Tick_1(object sender, EventArgs e)
        {
            game.timerTick();
                    
            if (game.isGameWon())
            {
                timer1.Stop();
                UserPlayingThisGame.addLevelScore(game.LEVELID, game.calculateScore());
                SaveFile();
                MessageBox.Show("Game WON! " + game.TOTALITEMSTOFREEZE + " / " + game.TOTALITEMSTOFREEZE + " frozen blocks.");
                nextLevel();
            }
            Invalidate(true);
            if (game.isGameLost() || (game.Player1.LivesLeft < 0 && game.Player2.LivesLeft < 0))
            {
                timer1.Stop();
                MessageBox.Show("Game LOST!");
                resetGame();
            }
            
            Invalidate(true);
        }

        private void Form1_2Player_Paint(object sender, PaintEventArgs e)
        {
            game.Draw(e.Graphics);
        }

        private void StatusStrip1_Paint_1(object sender, PaintEventArgs e)
        {
            statusStrip1.ForeColor = Color.White;

            tsslPlayer1Snowflakes.Text = string.Format("Snowflakes: {0}/{1}", game.collectedSnowflakesPlayer1, game.TOTALSNOWFLAKES);
            tsspbPlayer1FrozenMeter.Value = game.frozenItemsPlayer1 <= tsspbPlayer1FrozenMeter.Maximum? game.frozenItemsPlayer1: tsspbPlayer1FrozenMeter.Maximum;
            tsslPlayer1Lives.Text = string.Format("Lives left: {0}/{1}", game.Player1.LivesLeft >= 0 ? game.Player1.LivesLeft : 0, 5);
            tsslPlayer1Snowflakes.Image = UserPlayingThisGame.AvatarPlayer1;


            tsslPlayer2Snowflakes.Text = string.Format("Snowflakes: {0}/{1}", game.collectedSnowflakesPlayer2, game.TOTALSNOWFLAKES);
            tsspbPlayer2FrozenMeter.Value = game.frozenItemsPlayer2 <= tsspbPlayer2FrozenMeter.Maximum ? game.frozenItemsPlayer2 : tsspbPlayer2FrozenMeter.Maximum;
            tsslPlayer2Lives.Text = string.Format("Lives left: {0}/{1}", game.Player2.LivesLeft >= 0 ? game.Player2.LivesLeft : 0, 5);
            tsslPlayer2Snowflakes.Image = UserPlayingThisGame.AvatarPlayer2;
        }

        private void Form1_2Player_KeyDown(object sender, KeyEventArgs e)
        {
            //PLAYER1
            if (e.KeyCode == UserPlayingThisGame.ControlsPlayer1[2])
            {
                game.Player1.isGoingLeft = true;
            }
            if (e.KeyCode == UserPlayingThisGame.ControlsPlayer1[3])
            {
                game.Player1.isGoingRight = true;
            }
            if (e.KeyCode == UserPlayingThisGame.ControlsPlayer1[0])
            {
                game.Player1.isGoingUp = true;
            }
            if (e.KeyCode == UserPlayingThisGame.ControlsPlayer1[1])
            {
                game.Player1.isGoingDown = true;
            }
            if (e.KeyCode == UserPlayingThisGame.ControlsPlayer1[4] && !game.Player1.isJumping && game.isPlayer1OnJumpablePlatform())
            {
                game.Player1.isJumping = true;
            }


            //PLAYER2
            if (e.KeyCode == UserPlayingThisGame.ControlsPlayer2[2])
            {
                game.Player2.isGoingLeft = true;
            }
            if (e.KeyCode == UserPlayingThisGame.ControlsPlayer2[3])
            {
                game.Player2.isGoingRight = true;
            }
            if (e.KeyCode == UserPlayingThisGame.ControlsPlayer2[0])
            {
                game.Player2.isGoingUp = true;
            }
            if (e.KeyCode == UserPlayingThisGame.ControlsPlayer2[1])
            {
                game.Player2.isGoingDown = true;
            }
            if (e.KeyCode == UserPlayingThisGame.ControlsPlayer2[4] && !game.Player2.isJumping && game.isPlayer2OnJumpablePlatform())
            {
                game.Player2.isJumping = true;
            }

            Invalidate(true);
        }

        private void Form1_2Player_KeyUp(object sender, KeyEventArgs e)
        {
            //PLAYER1
            if (e.KeyCode == UserPlayingThisGame.ControlsPlayer1[2])
            {
                game.Player1.isGoingLeft = false;
            }
            if (e.KeyCode == UserPlayingThisGame.ControlsPlayer1[3])
            {
                game.Player1.isGoingRight = false;
            }
            if (e.KeyCode == UserPlayingThisGame.ControlsPlayer1[0])
            {
                game.Player1.isGoingUp = false;
            }
            if (e.KeyCode == UserPlayingThisGame.ControlsPlayer1[1])
            {
                game.Player1.isGoingDown = false;
            }
            if (e.KeyCode == UserPlayingThisGame.ControlsPlayer1[4])
            {
                game.Player1.isJumping = false;
            }

            //PLAYER2
            if (e.KeyCode == UserPlayingThisGame.ControlsPlayer2[2])
            {
                game.Player2.isGoingLeft = false;
            }
            if (e.KeyCode == UserPlayingThisGame.ControlsPlayer2[3])
            {
                game.Player2.isGoingRight = false;
            }
            if (e.KeyCode == UserPlayingThisGame.ControlsPlayer2[0])
            {
                game.Player2.isGoingUp = false;
            }
            if (e.KeyCode == UserPlayingThisGame.ControlsPlayer2[1])
            {
                game.Player2.isGoingDown = false;
            }
            if (e.KeyCode == UserPlayingThisGame.ControlsPlayer2[4])
            {
                game.Player2.isJumping = false;
            }

            Invalidate(true);
        }

        private void Form1_2Player_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*this.Hide();
            LevelChooserForm levels = new LevelChooserForm(UserPlayingThisGame);
            levels.ShowDialog();
            this.Close();*/
        }
    }
}
