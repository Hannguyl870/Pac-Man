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
        int playerSpeed = 3;
        int playerscore = 0;
        string mainmenue = "waiting";

        SoundPlayer sp;

       
        SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
        SolidBrush redBrush = new SolidBrush(Color.Red);
        SolidBrush blueBrush = new SolidBrush(Color.Blue);
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush orangeBrush = new SolidBrush(Color.Orange);
        SolidBrush blackBrush = new SolidBrush(Color.Black);

        Rectangle homepm1 = new Rectangle(55, 100, 40, 40);
        Rectangle homepm2 = new Rectangle(425, 178, 40, 40);

        Rectangle Wall1 = new Rectangle(50 ,40, 70, 5);
        Rectangle Wall2 = new Rectangle(200,40, 70, 5);
        Rectangle Wall3 = new Rectangle(0, 90, 70, 5);
        Rectangle Wall4 = new Rectangle(220,115,5,130);
        Rectangle Wall5 = new Rectangle(155, 140,5, 90);
        Rectangle Wall6 = new Rectangle(40, 170, 70, 5);
        Rectangle Wall7 = new Rectangle(80, 290, 5, 70);
        Rectangle Wall8 = new Rectangle(50, 130, 50, 5);
        Rectangle Wall9 = new Rectangle(120, 90, 70, 5);
        Rectangle Wall10 = new Rectangle(00, 225, 100, 5);
        Rectangle Wall11 = new Rectangle(160, 280, 70, 5);

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
                e.Graphics.FillEllipse(yellowBrush, homepm1);
                e.Graphics.FillEllipse(yellowBrush, homepm2);
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
                e.Graphics.FillRectangle(blackBrush, Wall7);
                e.Graphics.FillRectangle(blackBrush, Wall8);
                e.Graphics.FillRectangle(blackBrush, Wall9);
                e.Graphics.FillRectangle(blackBrush, Wall10);
                e.Graphics.FillRectangle(blackBrush, Wall11);

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

            if (pacDirection == "left")
            {
                pacman.X -= playerSpeed;
            }
            // pac man appears on otherside of screen once gone over boundries 
            if (pacman.Y > this.Height)
            {
                pacman.Y = pacman.Y - this.Height;
            }
            if (pacman.Y < 0)
            {
                pacman.Y = pacman.Y + this.Height;
            }
            if (pacman.X > this.Width)
            {
                pacman.X = pacman.X - this.Width;
            }
            if (pacman.X < 0)
            {
                pacman.X = pacman.X + this.Width;
            }
            if (playerscore == 5)
            {
                pacmantimer.Enabled = false;
                mainmenue = "playerwon";
            }

            //player intersects with walls
            wallintersection();

            Refresh();
        }

        private void wallintersection()
        {
            if (pacman.IntersectsWith(Wall1))
            {
                playerscore--;
                pacman.X = 10;
                pacman.Y = 300;
            }
            if (pacman.IntersectsWith(Wall2))
            {
                playerscore--;
                pacman.X = 10;
                pacman.Y = 300;
            }
            if (pacman.IntersectsWith(Wall3))
            {
                playerscore--;
                pacman.X = 10;
                pacman.Y = 300;
            }
            if (pacman.IntersectsWith(Wall4))
            {
                playerscore--;
                pacman.X = 10;
                pacman.Y = 300;
            }
            if (pacman.IntersectsWith(Wall5))
            {
                playerscore--;
                pacman.X = 10;
                pacman.Y = 300;
            }
            if (pacman.IntersectsWith(Wall6))
            {
                playerscore--;
                pacman.X = 10;
                pacman.Y = 300;
            }
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
