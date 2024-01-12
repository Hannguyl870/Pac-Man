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
        int playerSpeed = 4;
        int playerscore = 0;
        string mainmenue = "waiting";

        SoundPlayer sp;

        //bool wDown = false;
        //bool sDown = false;
        //bool dDown = false;
        //bool aDown = false;
        //bool upArrowDown = false;
        //bool downArrowDown = false;
        //bool rightArrowDown = false;
        //bool leftArrowDown = false;

        SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
        SolidBrush redBrush = new SolidBrush(Color.Red);
        SolidBrush blueBrush = new SolidBrush(Color.Blue);
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush orangeBrush = new SolidBrush(Color.Orange);
        SolidBrush blackBrush = new SolidBrush(Color.Black);


       
        Rectangle Wall1 = new Rectangle(50 ,60, 70, 5);
        Rectangle Wall2 = new Rectangle(180, 60, 70, 5);
        Rectangle Wall3 = new Rectangle(170, 200, 5, 125);
        Rectangle Wall4 = new Rectangle(110, 190, 5, 90);
        Rectangle Wall5 = new Rectangle(60, 275, 50, 5);
        Rectangle Wall6 = new Rectangle(50, 125, 70, 5);
        //Rectangle Wall7 = new Rectangle(0, 125, 70, 5); 
        //Rectangle Wall6 = new Rectangle(50, 125, 70, 5);
        //Rectangle Wall6 = new Rectangle(50, 125, 70, 5);
        //Rectangle Wall6 = new Rectangle(50, 125, 70, 5);
        //Rectangle Wall6 = new Rectangle(50, 125, 70, 5);

        Rectangle pacman = new Rectangle(10, 300, 20, 20);
        string pacDirection = "right";


        public PacMan()
        {
            InitializeComponent();
        }
        public void GameInitialize()
        {
          
            Titlelable.Visible = false;
            Subtitlelable1.Visible = false;
            Subtitlelable2.Visible = false;
            Titlelable.Text = "";
            Subtitlelable1.Text = "";
            Subtitlelable2.Text = "";
            Scorelable.Text = "0";

            pacmantimer.Enabled = true;

            mainmenue = "running";

        }

        private void PacMan_Paint(object sender, PaintEventArgs e)
        {
          
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
               
                Titlelable.Visible = false;
                Subtitlelable1.Visible = false;
                Subtitlelable2.Visible = false;

                Scorelable.Visible = true;
                Scorelable.Text = $"{playerscore}";

                e.Graphics.FillRectangle(blackBrush, Wall1);
                e.Graphics.FillRectangle(blackBrush, Wall2);
                e.Graphics.FillRectangle(blackBrush, Wall3);
                e.Graphics.FillRectangle(blackBrush, Wall4);
                e.Graphics.FillRectangle(blackBrush, Wall5);
                e.Graphics.FillRectangle(blackBrush, Wall6);

                e.Graphics.FillEllipse(yellowBrush, pacman);


            }
        }
       

     

        private void timer1_Tick(object sender, EventArgs e)
        {
           // if (upArrowDown == true /*&& pacman.Y > this.Height*/)
            if (pacDirection == "up")
            {
                pacman.Y -= playerSpeed;

            }

            if (pacDirection == "down")
            {
                pacman.Y += playerSpeed;

            }
          
            if (pacDirection == "right")
            {
                pacman.X += playerSpeed;
            }

            if (pacDirection == "left ")
            {
                pacman.X += playerSpeed;
            }

            if (pacDirection == "up ")
            {
                pacman.Y -= playerSpeed;
            }
            if (pacDirection == "down")
            {
                pacman.Y += playerSpeed;

            }
            if (pacDirection == "right")
            {
                pacman.X += playerSpeed;
            }

            if (pacDirection == "left ")
            {
                pacman.X += playerSpeed;
            }

            if (pacman.Y > this.Height)
            {
                pacman.Y = 300;
                pacman.X = 10;

            }
            if (playerscore == 5)
            {
                pacmantimer.Enabled = false;
                mainmenue = "playerwon";
            }

            Refresh();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    pacDirection = "up";

                    break;
                case Keys.S:
                    pacDirection = "down";
                    break;

                case Keys.D:
                    pacDirection = "right";
                    break;

                case Keys.A:
                    pacDirection = "left";
                    break;

                case Keys.Up:
                    pacDirection = "up";
                    break;

                case Keys.Down:
                    pacDirection = "down";
                    break;

                case Keys.Right:
                    pacDirection = "right";
                    break;

                case Keys.Left:
                    pacDirection = "left";
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
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    pacDirection = "up";

                    break;
                case Keys.S:
                    pacDirection = "down";
                    break;

                case Keys.D:
                    pacDirection = "right";
                    break;

                case Keys.A:
                    pacDirection = "left";
                    break;

                case Keys.Up:
                    pacDirection = "up";
                    break;

                case Keys.Down:
                    pacDirection = "down";
                    break;

                case Keys.Right:
                    pacDirection = "right";
                    break;

                case Keys.Left:
                    pacDirection = "left";
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
