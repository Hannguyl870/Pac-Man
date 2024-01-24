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
        int ghostspeed = 2;
        int playerscore = 0;
        int playerlife = 3;
        int size = 10;
        string mainmenue = "waiting";
        string pacDirection = "right";
        string ghost1Direction = "right";
        string ghost2Direction = "down";
        string ghost3Direction = "right";

        SoundPlayer sp;

        List<Rectangle> points = new List<Rectangle>();

        SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
        SolidBrush redBrush = new SolidBrush(Color.Red);
        SolidBrush blueBrush = new SolidBrush(Color.Blue);
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush orangeBrush = new SolidBrush(Color.Orange);
        SolidBrush blackBrush = new SolidBrush(Color.Black);
        SolidBrush transparentBrush = new SolidBrush(Color.Transparent);
        //pacman on homepage 
        Rectangle homepm1 = new Rectangle(55, 100, 40, 40);
        Rectangle homepm2 = new Rectangle(425, 178, 40, 40);
     //walls 
        Rectangle Wall1 = new Rectangle(50, 40, 70, 5);
        Rectangle Wall2 = new Rectangle(200, 40, 70, 5);
        Rectangle Wall3 = new Rectangle(0, 90, 70, 5);
        Rectangle Wall4 = new Rectangle(220, 115, 5, 130);
        Rectangle Wall5 = new Rectangle(155, 140, 5, 90);
        Rectangle Wall6 = new Rectangle(40, 170, 70, 5);
        Rectangle Wall7 = new Rectangle(80, 290, 5, 70);
        Rectangle Wall8 = new Rectangle(50, 130, 50, 5);
        Rectangle Wall9 = new Rectangle(120, 90, 70, 5);
        Rectangle Wall10 = new Rectangle(00, 225, 100, 5);
        Rectangle Wall11 = new Rectangle(140, 280, 70, 5);
        Rectangle Wall12 = new Rectangle(320, 0, 5, 90);
        Rectangle Wall13 = new Rectangle(260, 280, 5, 70);
        Rectangle Wall14 = new Rectangle(280, 230, 70, 5);
        Rectangle Wall15 = new Rectangle(280, 90, 5, 100);
        Rectangle Wall16 = new Rectangle(500, 185, 5, 140);
        Rectangle Wall17 = new Rectangle(390, 230, 70, 5);
        Rectangle Wall18 = new Rectangle(545, 280, 20, 5);
        Rectangle Wall19 = new Rectangle(505, 235, 40, 5);
        Rectangle Wall20 = new Rectangle(560, 190, 40, 5);
        Rectangle Wall21 = new Rectangle(310, 280, 140, 5);
        Rectangle Wall22 = new Rectangle(450, 0, 5, 90);
        Rectangle Wall23 = new Rectangle(360, 40, 50, 5);
        Rectangle Wall24 = new Rectangle(320, 90, 60, 5);
        Rectangle Wall25 = new Rectangle(380, 90, 5, 60);
        Rectangle Wall26 = new Rectangle(320, 130, 5, 65);
        Rectangle Wall27 = new Rectangle(360, 190, 80, 5);
        Rectangle Wall28 = new Rectangle(500, 50, 5, 60);
        Rectangle Wall29 = new Rectangle(320, 130, 30, 5);
        Rectangle Wall30 = new Rectangle(430, 150, 80, 5);
        Rectangle Wall31 = new Rectangle(430, 90, 25, 5);
        Rectangle Wall32 = new Rectangle(500, 50, 40, 5);
        Rectangle Wall33 = new Rectangle(550, 90, 5, 40);
        Rectangle Wall34 = new Rectangle(430, 130, 5, 20);
        Rectangle Wall35 = new Rectangle(540, 35, 5, 20);

    //pacman
        Rectangle pacman = new Rectangle(300, 300, 20, 20);
    //ghosts 
        Rectangle ghost1 = new Rectangle(10, 50, 15, 25);
        Rectangle ghost2 = new Rectangle(470,20,15,25);
        Rectangle ghost3 = new Rectangle(510,300,15,25);

        Rectangle Inva1= new Rectangle(460, 155, 20, 10);
        Rectangle Inva2 = new Rectangle(460, 220, 20, 10);
        Rectangle Inva3 = new Rectangle(320, 220, 20, 10);
        Rectangle Inva4 = new Rectangle(320, 155, 20, 10);
        Rectangle Inva5 = new Rectangle(510, 155, 20, 10);


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

            points.Clear();

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
                playerlifelable.Text = "";
                playerlifelable.Visible = false;
                Scorelable.Visible = false;
                e.Graphics.FillEllipse(yellowBrush, homepm1);
                e.Graphics.FillEllipse(yellowBrush, homepm2);
            }
            else if (mainmenue == "running")
            {

                Titlelable.Visible = false;
                Subtitlelable1.Visible = false;
                Subtitlelable2.Visible = false;
                playerlifelable.Text = $"{playerlife}";
                Scorelable.Visible = true;
                playerlifelable.Visible = true;
                Scorelable.Text = $"{playerscore}";

               
            //walls 
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
                e.Graphics.FillRectangle(blackBrush, Wall12);
                e.Graphics.FillRectangle(blackBrush, Wall13);
                e.Graphics.FillRectangle(blackBrush, Wall14);
                e.Graphics.FillRectangle(blackBrush, Wall15);
                e.Graphics.FillRectangle(blackBrush, Wall16);
                e.Graphics.FillRectangle(blackBrush, Wall17);
                e.Graphics.FillRectangle(blackBrush, Wall18);
                e.Graphics.FillRectangle(blackBrush, Wall19);
                e.Graphics.FillRectangle(blackBrush, Wall20);
                e.Graphics.FillRectangle(blackBrush, Wall21);
                e.Graphics.FillRectangle(blackBrush, Wall22);
                e.Graphics.FillRectangle(blackBrush, Wall23);
                e.Graphics.FillRectangle(blackBrush, Wall24);
                e.Graphics.FillRectangle(blackBrush, Wall25);
                e.Graphics.FillRectangle(blackBrush, Wall26);
                e.Graphics.FillRectangle(blackBrush, Wall27);
                e.Graphics.FillRectangle(blackBrush, Wall28);
                e.Graphics.FillRectangle(blackBrush, Wall29);
                e.Graphics.FillRectangle(blackBrush, Wall30);
                e.Graphics.FillRectangle(blackBrush, Wall31);
                e.Graphics.FillRectangle(blackBrush, Wall32);
                e.Graphics.FillRectangle(blackBrush, Wall33);
                e.Graphics.FillRectangle(blackBrush, Wall34);
                e.Graphics.FillRectangle(blackBrush, Wall35);
            //pacman
                e.Graphics.FillEllipse(yellowBrush, pacman);
            // ghosts 
                e.Graphics.FillEllipse(blueBrush, ghost1);
                e.Graphics.FillEllipse(redBrush, ghost2);
                e.Graphics.FillEllipse(orangeBrush, ghost3);

                e.Graphics.FillRectangle(transparentBrush,Inva1);
                e.Graphics.FillRectangle(transparentBrush, Inva2);
                e.Graphics.FillRectangle(transparentBrush, Inva3);
                e.Graphics.FillRectangle(transparentBrush, Inva4);
                e.Graphics.FillRectangle(redBrush, Inva5);

            }
            else if (mainmenue =="player lost")
            {
                Titlelable.Text = "YOU LOST";
                Subtitlelable1.Text = "PRESS SPACE TO TRY AGAIN";
                Subtitlelable2.Text = "OR ESC TO EXIT ";
                Scorelable.Text = $"{playerscore}";
                playerlifelable.Text = $"{playerlife}";
                playerlifelable.Visible = true; 
                Scorelable.Visible = true;
            }
            else if (mainmenue == "player won")
            {
                Titlelable.Text = "YOU WIN";
                Subtitlelable1.Text = "PRESS SPACE TO PLAY AGAIN";
                Subtitlelable2.Text = "OR ESC TO EXIT ";
                Scorelable.Text = $"{playerscore}";
                playerlifelable.Text = $"{playerlife}";
                playerlifelable.Visible = true;
                Scorelable.Visible = true;
            }
        }




        private void timer1_Tick(object sender, EventArgs e)
        {
           
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

            //player lifes 
            if (playerlife == 0)
            {
                mainmenue = "player lost";
            }
            if (pacman.IntersectsWith(ghost1))
            {
                playerlife--;
                pacman.X = 300;
                pacman.Y = 300;
            }

            //player intersects with walls
            wallintersection();

            // moving ghost1 
            if (ghost1Direction == "right")
            {
                ghost1.X += ghostspeed;
               
            }
            else if (ghost1Direction == "left")
            {
                ghost1.X -= ghostspeed;
               
            }
            else if (ghost1Direction == "up")
            {
                ghost1.Y -= ghostspeed;
              
            }
            else if (ghost1Direction == "down")
            {
                ghost1.Y += ghostspeed;
               
            }

            //moving ghost 2
            if (ghost2Direction == "right")
            {
                ghost2.X += ghostspeed;

            }
            else if (ghost2Direction == "left")
            {
                ghost2.X -= ghostspeed;

            }
            else if (ghost2Direction == "up")
            {
                ghost2.Y -= ghostspeed;

            }
            else if (ghost2Direction == "down")
            {
                ghost2.Y += ghostspeed;

            }
            // moving ghost3 
            if (ghost3Direction == "right")
            {
                ghost3.X += ghostspeed;

            }
            else if (ghost3Direction == "left")
            {
                ghost3.X -= ghostspeed;

            }
            else if (ghost3Direction == "up")
            {
                ghost3.Y -= ghostspeed;

            }
            else if (ghost3Direction == "down")
            {
                ghost3.Y += ghostspeed;

            }
            //ghost 1 pattern
            if (ghost1.X > 270 && ghost1Direction =="right")
            {
                ghost1Direction = "up";
            }
            if ((ghost1.Y < 10 && ghost1Direction == "up"))
            {
                ghost1Direction = "left";
            }
            if ((ghost1.X < 30 && ghost1Direction == "left"))
            {
                ghost1Direction = "down";
            }
            if ((ghost1.Y > 50 && ghost1Direction == "down"))
            {
                ghost1Direction = "right";
            }

            //ghost2 pattern 
            if (ghost2.Y > 110 && ghost2Direction == "down")
            {
                ghost2Direction = "right";
            }
            if ((ghost2.X > 515 && ghost2Direction == "right"))
            {
                ghost2Direction = "up";
            }
            if ((ghost2.Y < 60 && ghost2Direction == "up"))
            {
                ghost2Direction = "right";
            }
            if ((ghost2.X >= 570 && ghost2Direction == "right"))
            {
                ghost2Direction = "up";
            }
            if ((ghost2.Y <7 && ghost2Direction == "up"))
            {
                ghost2Direction = "left";
            }
            if (ghost2.X <470 && ghost2Direction == "left")
            {
                ghost2Direction = "down";
            }

            //ghost3 pattern 
            if (ghost3.X >= 570 && ghost3Direction == "right")
            {
                ghost3Direction = "up";
            }
            if ((ghost3.Y <= 200 && ghost3Direction == "up"))
            {
                ghost3Direction = "left";
            }
            if (ghost3.X <= 515 && ghost3Direction == "left")
            {
                ghost3Direction = "up";
            }
            if (ghost3.Y <= 160 && ghost3Direction == "up")// exit 
            {
                ghost3Direction = "left";
            }
            if (/*ghost3.X <= 450 &&*/ ghost3.IntersectsWith(Inva4)&& ghost3Direction == "left")
            {
                ghost3Direction = "down";
            }
            if (/*ghost3.Y >= 197*/ /*&&*/ ghost3.IntersectsWith(Inva3) && ghost3Direction == "down")
            {
                ghost3Direction = "right";
            }
            if (/*ghost3.X >= 450 &&*//* ghost3.Y <= 200*/ ghost3.IntersectsWith (Inva2)&& ghost3Direction == "right")
            {
                ghost3Direction = "up";

            }
            if (ghost3.Y >= 150 && ghost3.IntersectsWith(Inva1) && ghost3Direction == "up")
            {
                ghost3Direction = "right";

            }
            if (ghost3.X >= 520 && ghost3.IntersectsWith(Inva5) && ghost3Direction == "right")
            {
                ghost3Direction = "down";
            }
            if (ghost3.Y >= 205 && ghost3Direction == "down")
            {
                ghost3Direction = "right";
            }
            if (ghost3.X >= 570 && ghost3.IntersectsWith(Inva5) && ghost3Direction == "right")
            {
                ghost3Direction = "down";
            }


            Refresh();
        }

        private void wallintersection()
        {
            if (pacman.IntersectsWith(Wall1))
            {
                playerscore--;
                pacman.X = 300;
                pacman.Y = 300;
                
            }
            if (pacman.IntersectsWith(Wall2))
            {
                playerscore--;
                pacman.X = 300;
                pacman.Y = 300;
            }
            if (pacman.IntersectsWith(Wall3))
            {
                playerscore--;
                pacman.X = 300;
                pacman.Y = 300;
            }
            if (pacman.IntersectsWith(Wall4))
            {
                playerscore--;
                pacman.X = 300;
                pacman.Y = 300;
            }
            if (pacman.IntersectsWith(Wall5))
            {
                playerscore--;
                pacman.X = 300;
                pacman.Y = 300;
            }
            if (pacman.IntersectsWith(Wall6))
            {
                playerscore--;
                pacman.X = 300;
                pacman.Y = 300;
            }
            if (pacman.IntersectsWith(Wall7))
            {
                playerscore--;
                pacman.X = 300;
                pacman.Y = 300;
            }
            if (pacman.IntersectsWith(Wall8))
            {
                playerscore--;
                pacman.X = 300;
                pacman.Y = 300;
            }
            if (pacman.IntersectsWith(Wall9))
            {
                playerscore--;
                pacman.X = 300;
                pacman.Y = 300;
            }
            if (pacman.IntersectsWith(Wall10))
            {
                playerscore--;
                pacman.X = 300;
                pacman.Y = 300;
            }
            if (pacman.IntersectsWith(Wall11))
            {
                playerscore--;
                pacman.X = 300;
                pacman.Y = 300;
            }
            if (pacman.IntersectsWith(Wall12))
            {
                playerscore--;
                pacman.X = 300;
                pacman.Y = 300;
            }
            if (pacman.IntersectsWith(Wall13))
            {
                playerscore--;
                pacman.X = 300;
                pacman.Y = 300;
            }
            if (pacman.IntersectsWith(Wall14))
            {
                playerscore--;
                pacman.X = 300;
                pacman.Y = 300;
            }
            if (pacman.IntersectsWith(Wall15))
            {
                playerscore--;
                pacman.X = 300;
                pacman.Y = 300;
            }
            if (pacman.IntersectsWith(Wall16))
            {
                playerscore--;
                pacman.X = 300;
                pacman.Y = 300;
            }
            if (pacman.IntersectsWith(Wall17))
            {
                playerscore--;
                pacman.X = 300;
                pacman.Y = 300;
            }
            if (pacman.IntersectsWith(Wall18))
            {
                playerscore--;
                pacman.X = 300;
                pacman.Y = 300;
            }
            if (pacman.IntersectsWith(Wall19))
            {
                playerscore--;
                pacman.X = 300;
                pacman.Y = 300;
            }
            if (pacman.IntersectsWith(Wall20))
            {
                playerscore--;
                pacman.X = 300;
                pacman.Y = 300;
            }
            if (pacman.IntersectsWith(Wall21))
            {
                playerscore--;
                pacman.X = 300;
                pacman.Y = 300;
            }
            if (pacman.IntersectsWith(Wall22))
            {
                playerscore--;
                pacman.X = 300;
                pacman.Y = 300;
            }
            if (pacman.IntersectsWith(Wall23))
            {
                playerscore--;
                pacman.X = 300;
                pacman.Y = 300;
            }

            if (pacman.IntersectsWith(Wall24))
            {
                playerscore--;
                pacman.X = 300;
                pacman.Y = 300;
            }
            if (pacman.IntersectsWith(Wall25))
            {
                playerscore--;
                pacman.X = 300;
                pacman.Y = 300;
            }
            if (pacman.IntersectsWith(Wall26))
            {
                playerscore--;
                pacman.X = 300;
                pacman.Y = 300;
            }
            if (pacman.IntersectsWith(Wall27))
            {
                playerscore--;
                pacman.X = 300;
                pacman.Y = 300;
            }
            if (pacman.IntersectsWith(Wall28))
            {
                playerscore--;
                pacman.X = 300;
                pacman.Y = 300;
            }
            if (pacman.IntersectsWith(Wall29))
            {
                playerscore--;
                pacman.X = 300;
                pacman.Y = 300;
            }
            if (pacman.IntersectsWith(Wall30))
            {
                playerscore--;
                pacman.X = 300;
                pacman.Y = 300;

            }
            if (pacman.IntersectsWith(Wall31))
            {
                playerscore--;
                pacman.X = 300;
                pacman.Y = 300;
            }
            if (pacman.IntersectsWith(Wall32))
            {
                playerscore--;
                pacman.X = 300;
                pacman.Y = 300;
            }
            if (pacman.IntersectsWith(Wall33))
            {
                playerscore--;
                pacman.X = 300;
                pacman.Y = 300;
            }
            if (pacman.IntersectsWith(Wall34))
            {
                playerscore--;
                pacman.X = 300;
                pacman.Y = 300;
            }
            if (pacman.IntersectsWith(Wall35))
            {
                playerscore--;
                pacman.X = 300;
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

