using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace Pac_Man
{
   
    public partial class PacMan : Form
    {
        int playerspeed = 4; 
        string mainmenue = "waiting";

        SoundPlayer sp;

        bool wDown = false;
        bool sDown = false;
        bool dDown = false;
        bool aDown = false;
        bool upArrowDown = false;
        bool downArrowDown = false;
        bool rightArrowDown = false;
        bool leftArrowDown = false;

        SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
        SolidBrush redBrush = new SolidBrush(Color.Red);
        SolidBrush blueBrush = new SolidBrush(Color.Blue);
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush orangeBrush = new SolidBrush(Color.Orange);
        SolidBrush blackBrush = new SolidBrush(Color.Black);


        Rectangle Wall1 = new Rectangle(260, 40, 5, 300);
        Rectangle Wall2 = new Rectangle(50, 40, 5, 40);
        Rectangle Wall3 = new Rectangle(600, 200, 5, 100); 
        Rectangle Wall4 = new Rectangle(50, 40, 5, 40);
        Rectangle Wall5 = new Rectangle(50, 40, 5, 40);


        public PacMan()
        {
            InitializeComponent();
        }
        public void GameInitialize()
        {
            Graphics g = this.CreateGraphics();

            Titlelable.Visible = false;
            Subtitlelable1.Visible = false;
            Subtitlelable2.Visible = false;
            Titlelable.Text = "";
            Subtitlelable1.Text = "";
            Subtitlelable2.Text = "";
            Scorelable.Text = "";

            //player1score = 0;
          
            mainmenue = "running";

        }

        private void PacMan_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            if (mainmenue == "waiting")
            {

                //Score1lable.Text = "";

                Titlelable.Text = "WELCOME PLAYER";
                Subtitlelable1.Text = "               Press Space to start";
                Subtitlelable2.Text = "            or Esc to exit";
                Scorelable.Text = "";
                Scorelable.Visible = false;
            }
            else if (mainmenue == "running")
            {
                pacmantimer.Enabled = true;
                Titlelable.Visible = false;
                Subtitlelable1.Visible = false;
                Subtitlelable2.Visible = false;

                Scorelable.Visible = true;

                e.Graphics.FillRectangle(blackBrush, Wall1);
                e.Graphics.FillRectangle(blackBrush, Wall2);
                e.Graphics.FillRectangle(blackBrush, Wall3);
                e.Graphics.FillRectangle(blackBrush, Wall4);
                e.Graphics.FillRectangle(blackBrush, Wall5);


            }
        }
       

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = true;

                    break;
                case Keys.S:
                    sDown = true;
                    break;

                case Keys.D:
                    dDown = true;
                    break;

                case Keys.A:
                    aDown = true;
                    break;

                case Keys.Up:
                    upArrowDown = true;
                    break;

                case Keys.Down:
                    downArrowDown = true;
                    break;

                case Keys.Right:
                    rightArrowDown = true;
                    break;

                case Keys.Left:
                    leftArrowDown = true;
                    break;

                case Keys.Space:
                    if (mainmenue == "waiting" || mainmenue == "playerwon" || mainmenue == "playerlost")
                    {
                        GameInitialize();
                    }
                    break;
                case Keys.Escape:
                    if (mainmenue == "waiting" || mainmenue == "playerwon" || mainmenue == "playerlost")
                    {
                        this.Close();
                    }
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //    if (upArrowDown == true && player.Y > Finishlinelable.Height - 3)
            //    {
            //        //player.Y -= playerSpeed;
            //       

            //    }
            //    if (downArrowDown == true && player2.Y < this.Height - player2.Height)
            //    {
            //        player.Y += playerSpeed;
            //      
            //    }

            //   if (rightArrowDown == true)
            //    {
            //         player.Y+= playerSpeed;
            //    }

            //    if (LeftArrowDown == true)
            //    {
            //         player.Y+= playerSpeed;
            //    }

            // if (player1.Y < this.Hight)
            //{
            //    player.Y = 400;
            //   
            //}
           // if (player1score == 5)
           // {
                //Pacmantimer.Enabled = false;
               // mainmenue = "playerwon";
            //}

            Refresh();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = true;

                    break;
                case Keys.S:
                    sDown = true;
                    break;

                case Keys.D:
                    dDown = true;
                    break;

                case Keys.A:
                    aDown = true;
                    break;

                case Keys.Up:
                    upArrowDown = true;
                    break;

                case Keys.Down:
                    downArrowDown = true;
                    break;

                case Keys.Right:
                    rightArrowDown = true;
                    break;

                case Keys.Left:
                    leftArrowDown = true;
                    break;

                case Keys.Space:
                    if (mainmenue == "waiting" || mainmenue == "playerwon" || mainmenue == "playerlost")
                    {
                        GameInitialize();
                    }
                    break;
                case Keys.Escape:
                    if (mainmenue == "waiting" || mainmenue == "playerwon" || mainmenue == "playerlost")
                    {
                        this.Close();
                    }
                    break;
            }
        }
    }
}
