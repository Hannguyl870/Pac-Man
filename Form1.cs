﻿//hannah guylee
//pac man game 
//summitive assignment
// January 26th 2024
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
       
        string mainmenue = "waiting";
        string playerDirection = "right";
        string ghost1Direction = "right";
        string ghost2Direction = "down";
        string ghost3Direction = "right";

       
        SoundPlayer sp;

        SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
        SolidBrush redBrush = new SolidBrush(Color.Red);
        SolidBrush blueBrush = new SolidBrush(Color.Blue);
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush orangeBrush = new SolidBrush(Color.Orange);
        SolidBrush blackBrush = new SolidBrush(Color.Black);
        SolidBrush transparentBrush = new SolidBrush(Color.Transparent);
        //player on homepage 
        Rectangle homepm1 = new Rectangle(55, 100, 40, 40);
        //Rectangle h1M = new Rectangle(55, 100, 40, 40);
        Rectangle homepm2 = new Rectangle(425, 178, 40, 40);

        //walls 
        List<Rectangle> walls = new List<Rectangle>();

        Rectangle W1 = new Rectangle(50, 40, 70, 5);
        Rectangle W2 = new Rectangle(200, 40, 70, 5);
        Rectangle W3 = new Rectangle(0, 90, 70, 5);
        Rectangle W4 = new Rectangle(220, 115, 5, 130);
        Rectangle W5 = new Rectangle(155, 140, 5, 90);
        Rectangle W6 = new Rectangle(40, 170, 70, 5);
        Rectangle W7 = new Rectangle(80, 290, 5, 70);
        Rectangle W8 = new Rectangle(50, 130, 50, 5);
        Rectangle W9 = new Rectangle(120, 90, 70, 5);
        Rectangle W10 = new Rectangle(00, 225, 100, 5);
        Rectangle W11 = new Rectangle(140, 280, 70, 5);
        Rectangle W12 = new Rectangle(320, 0, 5, 90);
        Rectangle W13 = new Rectangle(260, 280, 5, 70);
        Rectangle W14 = new Rectangle(280, 230, 70, 5);
        Rectangle W15 = new Rectangle(280, 90, 5, 100);
        Rectangle W16 = new Rectangle(500, 190, 5, 135);
        Rectangle W17 = new Rectangle(390, 230, 70, 5);
        Rectangle W18 = new Rectangle(545, 280, 20, 5);
        Rectangle W19 = new Rectangle(505, 235, 40, 5);
        Rectangle W20 = new Rectangle(560, 190, 40, 5);
        Rectangle W21 = new Rectangle(310, 280, 140, 5);
        Rectangle W22 = new Rectangle(450, 0, 5, 90);
        Rectangle W23 = new Rectangle(360, 40, 50, 5);
        Rectangle W24 = new Rectangle(320, 90, 60, 5);
        Rectangle W25 = new Rectangle(380, 90, 5, 60);
        Rectangle W26 = new Rectangle(320, 130, 5, 65);
        Rectangle W27 = new Rectangle(360, 190, 80, 5);
        Rectangle W28 = new Rectangle(500, 50, 5, 60);
        Rectangle W29 = new Rectangle(320, 130, 30, 5);
        Rectangle W30 = new Rectangle(430, 150, 80, 5);
        Rectangle W31 = new Rectangle(430, 90, 25, 5);
        Rectangle W32 = new Rectangle(500, 50, 40, 5);
        Rectangle W33 = new Rectangle(550, 90, 5, 40);
        Rectangle W34 = new Rectangle(430, 130, 5, 20);
        Rectangle W35 = new Rectangle(540, 35, 5, 20);

    //player
        Rectangle player = new Rectangle(300, 300, 20, 20);
    //ghosts 
        Rectangle ghost1 = new Rectangle(10, 50, 15, 25);
        Rectangle ghost2 = new Rectangle(470,20,15,25);
        Rectangle ghost3 = new Rectangle(510,300,15,25);
//inviable POINTS 
        Rectangle Inva1= new Rectangle(465, 155, 20, 10);
        Rectangle Inva2 = new Rectangle(465, 220, 20, 10);
        Rectangle Inva3 = new Rectangle(320, 220, 20, 10);
        Rectangle Inva4 = new Rectangle(320, 155, 20, 10);
        Rectangle Inva5 = new Rectangle(510, 155, 20, 10);
        Rectangle Inva6 = new Rectangle(580, 220, 15, 30);
        Rectangle Inva7 = new Rectangle(550, 270, 30, 10);
        Rectangle Inva8 = new Rectangle(505, 260, 15, 40);
        Rectangle Inva9 = new Rectangle(590, 300, 45, 10);


        //points
        List<Rectangle> points = new List<Rectangle>();

        Rectangle P1= new Rectangle(20, 300,10,10);//row 1
        Rectangle P2 = new Rectangle(100, 300, 10, 10);
        Rectangle P3 = new Rectangle(180, 300, 10, 10);
        Rectangle P4 = new Rectangle(270, 300, 10, 10);
        Rectangle P5 = new Rectangle(320, 300, 10, 10);
        Rectangle P6 = new Rectangle(400, 300, 10, 10);
        Rectangle P7 = new Rectangle(480, 300, 10, 10);

        Rectangle P8= new Rectangle(20, 250, 10, 10);//row2
        Rectangle P9 = new Rectangle(100, 250, 10, 10);
        Rectangle P10= new Rectangle(180, 250, 10, 10);
        Rectangle P11= new Rectangle(250, 250, 10, 10);
        Rectangle P12= new Rectangle(320, 250, 10, 10);
        Rectangle P13= new Rectangle(400, 250, 10, 10);
        Rectangle P14= new Rectangle(480, 250, 10, 10);

        Rectangle P15= new Rectangle(20, 200, 10, 10);//row3
        Rectangle P16= new Rectangle(100, 200, 10, 10);
        Rectangle P17 = new Rectangle(180, 200, 10, 10);
        Rectangle P18 = new Rectangle(250, 200, 10, 10);
        Rectangle P19 = new Rectangle(320, 205,10, 10);
        Rectangle P20 = new Rectangle(400, 205, 10, 10);
        Rectangle P21 = new Rectangle(480, 205, 10, 10);

        Rectangle P22 = new Rectangle(20, 150, 10, 10);//row4
        Rectangle P23 = new Rectangle(100, 150, 10, 10);
        Rectangle P24 = new Rectangle(180, 150, 10, 10);
        Rectangle P25 = new Rectangle(250, 150, 10, 10);
        Rectangle P26 = new Rectangle(340, 160, 10, 10);
        Rectangle P27 = new Rectangle(400, 160, 10, 10);
        Rectangle P28 = new Rectangle(480, 170, 10, 10);

        Rectangle P29 = new Rectangle(20, 105, 10, 10);//row5
        Rectangle P30 = new Rectangle(100, 105, 10, 10);
        Rectangle P31 = new Rectangle(180, 105, 10, 10);
        Rectangle P32 = new Rectangle(250, 105, 10, 10);
        Rectangle P33 = new Rectangle(300, 105, 10, 10);
        Rectangle P34 = new Rectangle(400, 105, 10, 10);
        Rectangle P35 = new Rectangle(480, 115, 10, 10);

        Rectangle P36= new Rectangle(20, 60, 10, 10);//row6
        Rectangle P37 = new Rectangle(100, 60, 10, 10);
        Rectangle P38 = new Rectangle(180, 60, 10, 10);
        Rectangle P39 = new Rectangle(250, 60, 10, 10);
        Rectangle P40 = new Rectangle(340, 60, 10, 10);
        Rectangle P41 = new Rectangle(400, 60, 10, 10);
        Rectangle P42 = new Rectangle(480, 60, 10, 10);

        Rectangle P43 = new Rectangle(20, 10, 10, 10);//row7
        Rectangle P44 = new Rectangle(100, 10, 10, 10);
        Rectangle P45 = new Rectangle(180, 10, 10, 10);
        Rectangle P46 = new Rectangle(260, 10, 10, 10);
        Rectangle P47 = new Rectangle(340, 10, 10, 10);
        Rectangle P48 = new Rectangle(400, 10, 10, 10);
        Rectangle P49 = new Rectangle(480, 10, 10, 10);

        Rectangle P50 = new Rectangle(570, 10, 10, 10);//vertical row right
        Rectangle P51 = new Rectangle(570, 60, 10, 10);
        Rectangle P52 = new Rectangle(570, 105, 10, 10);
        Rectangle P53 = new Rectangle(570, 160, 10, 10);
        Rectangle P54 = new Rectangle(570, 210, 10, 10);
        Rectangle P55 = new Rectangle(570, 250, 10, 10);
        Rectangle P56 = new Rectangle(570, 300, 10, 10);

        Rectangle P57 = new Rectangle(520, 10, 10, 10);//random
        Rectangle P58 = new Rectangle(520, 60, 10, 10);
        Rectangle P59 = new Rectangle(520, 115, 10, 10);
        Rectangle P60 = new Rectangle(520, 160, 10, 10);
        Rectangle P61 = new Rectangle(520, 210, 10, 10);
        Rectangle P62 = new Rectangle(520, 250, 10, 10);
        Rectangle P63 = new Rectangle(520, 300, 10, 10);
        Rectangle P64 = new Rectangle(150, 35, 10, 10);
        Rectangle P65 = new Rectangle(290, 35, 10, 10);
        Rectangle P66 = new Rectangle(425, 35, 10, 10);
        Rectangle P67 = new Rectangle(300, 150, 10, 10);
        Rectangle P68 = new Rectangle(360, 105, 10, 10);



        public PacMan()
        {
            InitializeComponent();
        }
        public void GameInitialize()
        {
            playerscore = 0;
            playerlife = 3;
            playerlifelable.Visible = true;
            Scorelable.Visible = true;
            Titlelable.Visible = false;
            Subtitlelable1.Visible = false;
            Subtitlelable2.Visible = false;
            Titlelable.Text = "";
            Subtitlelable1.Text = "";
            Subtitlelable2.Text = "";
            Scorelable.Text = $"{playerscore}";
            playerlifelable.Text = $"{playerlife}";

            pacmantimer.Enabled = true;
            playerDirection = "right";
            ghost1Direction = "right";
            ghost2Direction = "down";
            ghost3Direction = "right";
            mainmenue = "running";
            player.X = 300;
            player.Y = 300;

            //WALLS
            walls.Clear();
            walls.Add(W1);
            walls.Add(W2);
            walls.Add(W3);
            walls.Add(W4);
            walls.Add(W5);
            walls.Add(W6);
            walls.Add(W7);
            walls.Add(W8);
            walls.Add(W9);
            walls.Add(W10);
            walls.Add(W11);
            walls.Add(W12);
            walls.Add(W13);
            walls.Add(W14);
            walls.Add(W15);
            walls.Add(W16);
            walls.Add(W17);
            walls.Add(W18);
            walls.Add(W19);
            walls.Add(W20);
            walls.Add(W21);
            walls.Add(W22);
            walls.Add(W23);
            walls.Add(W24);
            walls.Add(W25);
            walls.Add(W26);
            walls.Add(W27);
            walls.Add(W28);
            walls.Add(W29);
            walls.Add(W30);
            walls.Add(W31);
            walls.Add(W32);
            walls.Add(W33);
            walls.Add(W34);
            walls.Add(W35);
          //POINTS
            points.Clear();
            points.Add(P1);
            points.Add(P2);
            points.Add(P3);
            points.Add(P4);
            points.Add(P5);
            points.Add(P6);
            points.Add(P7);
            points.Add(P8);
            points.Add(P9);
            points.Add(P10);
            points.Add(P11);
            points.Add(P12);
            points.Add(P13);
            points.Add(P14);
            points.Add(P15);
            points.Add(P16);
            points.Add(P17);
            points.Add(P18);
            points.Add(P19);
            points.Add(P20);
            points.Add(P21);
            points.Add(P22);
            points.Add(P23);
            points.Add(P24);
            points.Add(P25);
            points.Add(P26);
            points.Add(P27);
            points.Add(P28);
            points.Add(P29);
            points.Add(P30);
            points.Add(P31);
            points.Add(P32);
            points.Add(P33);
            points.Add(P34);
            points.Add(P35);
            points.Add(P36);
            points.Add(P37);
            points.Add(P38);
            points.Add(P39);
            points.Add(P40);
            points.Add(P41);
            points.Add(P42);
            points.Add(P43);
            points.Add(P44);
            points.Add(P45);
            points.Add(P46);
            points.Add(P47);
            points.Add(P48);
            points.Add(P49);
            points.Add(P50);
            points.Add(P51);
            points.Add(P52);
            points.Add(P53);
            points.Add(P54);
            points.Add(P55);
            points.Add(P56);
            points.Add(P57);
            points.Add(P58);
            points.Add(P59);
            points.Add(P60);
            points.Add(P61);
            points.Add(P62);
            points.Add(P63);
            points.Add(P64);
            points.Add(P65);
            points.Add(P66);
            points.Add(P67);
            points.Add(P68);

           
        }

        private void PacMan_Paint(object sender, PaintEventArgs e)
        {

            if (mainmenue == "waiting")
            {

                //Score1lable.Text = "";

                Titlelable.Text = "WELCOME PLAYER";
                Subtitlelable1.Text = "               PRESS SPACE TO PLAY";
                Subtitlelable2.Text = "            OR ESC TO EXIT";
                Scorelable.Text = "";
                playerlifelable.Text = "";
                playerlifelable.Visible = false;
                Scorelable.Visible = false;
                e.Graphics.FillEllipse(yellowBrush, homepm1);
                //e.Graphics.FillPie(whiteBrush, h1M);
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

            //player
                e.Graphics.FillEllipse(yellowBrush, player);
            // ghosts 
                e.Graphics.FillEllipse(blueBrush, ghost1);
                e.Graphics.FillEllipse(redBrush, ghost2);
                e.Graphics.FillEllipse(orangeBrush, ghost3);
            //inviable points
                e.Graphics.FillRectangle(transparentBrush,Inva1);
                e.Graphics.FillRectangle(transparentBrush, Inva2);
                e.Graphics.FillRectangle(transparentBrush, Inva3);
                e.Graphics.FillRectangle(transparentBrush, Inva4);
                e.Graphics.FillRectangle(transparentBrush, Inva5);
                e.Graphics.FillRectangle(transparentBrush, Inva6);
                e.Graphics.FillRectangle(transparentBrush, Inva7);
                e.Graphics.FillRectangle(transparentBrush, Inva8);
                e.Graphics.FillRectangle(transparentBrush, Inva9);
               //points
                for (int i = 0; i < points.Count; i++)
                {
                    e.Graphics.FillEllipse(whiteBrush, points[i]);
                }
                for (int i = 0; i < walls.Count; i++)
                {
                    e.Graphics.FillRectangle(blackBrush, walls[i]);
                }
            }
            else if (mainmenue =="playerlost")
            {
                playerlifelable.Visible = false;
                Scorelable.Visible = false;
                Titlelable.Visible = true;
                Subtitlelable1.Visible = true;
                Subtitlelable2.Visible = true;
                Titlelable.Text = "YOU LOST";
                Subtitlelable1.Text = "                PRESS SPACE TO PLAY AGAIN";
                Subtitlelable2.Text = "           OR ESC TO EXIT ";
                e.Graphics.FillEllipse(yellowBrush, homepm1);
                e.Graphics.FillEllipse(yellowBrush, homepm2);

            }
            else if (mainmenue == "playerwon")
            {
                Titlelable.Text = "YOU WIN";
                Subtitlelable1.Text = "                PRESS SPACE TO PLAY AGAIN";
                Subtitlelable2.Text = "           OR ESC TO EXIT ";
                Scorelable.Text = $"{playerscore}";
                playerlifelable.Text = $"{playerlife}";
                playerlifelable.Visible = false;
                Scorelable.Visible = false;
                Titlelable.Visible = true;
                Subtitlelable1.Visible = true;
                Subtitlelable2.Visible = true;
                e.Graphics.FillEllipse(yellowBrush, homepm1);
                e.Graphics.FillEllipse(yellowBrush, homepm2);


            }
        }




        private void timer1_Tick(object sender, EventArgs e)
        {
           
            if (playerDirection == "up")
            {
                player.Y -= playerSpeed;

            }

            if (playerDirection == "down")
            {
                player.Y += playerSpeed;

            }

            if (playerDirection == "right")
            {
                player.X += playerSpeed;
            }

            if (playerDirection == "left")
            {
                player.X -= playerSpeed;
            }

            // pac man appears on otherside of screen once gone over boundries 
            if (player.Y > this.Height)
            {
                player.Y = player.Y - this.Height;
            }
            if (player.Y < 0)
            {
                player.Y = player.Y + this.Height;
            }
            if (player.X > this.Width)
            {
                player.X = player.X - this.Width;
            }
            if (player.X < 0)
            {
                player.X = player.X + this.Width;
            }

            //player lifes
            if (playerlife < 0)
            {
                mainmenue = "playerlost";
            }
            if (player.IntersectsWith(ghost1))
            {
                playerlife--;
                player.X = 300;
                player.Y = 300;
                playerDirection = "right";
                sp = new SoundPlayer(Properties.Resources.lose_a_life);
                sp.Play();
            }
            if (player.IntersectsWith(ghost2))
            {
                playerlife--;
                player.X = 300;
                player.Y = 300;
                sp = new SoundPlayer(Properties.Resources.lose_a_life);
                sp.Play();
            }
            if (player.IntersectsWith(ghost3))
            {
                playerlife--;
                player.X = 300;
                player.Y = 300;
                sp = new SoundPlayer(Properties.Resources.lose_a_life);
                sp.Play();
            }
            if (playerscore < 0)
            {
                playerlife--;
                player.X = 300;
                player.Y = 300;
                playerDirection = "right";
            }

           // player points
            for (int i = 0; i < points.Count; i++)
            {
                if (player.IntersectsWith(points[i]))
                {
                    playerscore++;
                    points.RemoveAt(i);
                    sp = new SoundPlayer(Properties.Resources.coins_1);
                    sp.Play();
                    break; 
                   
                }
            }
            if(playerscore>29 && playerlife>0)
            {
                mainmenue = "playerwon";
            }
           //player intersects with walls
            for (int i = 0; i < walls.Count; i++)
            {
                if (player.IntersectsWith(walls[i]))
                {
                    playerscore--;
                    player.X = 300;
                    player.Y = 300;
                    playerDirection = "right";
                    sp = new SoundPlayer(Properties.Resources.wall_colition);
                    sp.Play();
                    break;

                }
            }


            

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
            if ((ghost2.X >515 && ghost2Direction == "right"))
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
            if (/*ghost3.X >= 570 && */ghost3.IntersectsWith(Inva9) && ghost3Direction == "right")
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
            if (ghost3.IntersectsWith(Inva4)&& ghost3Direction == "left")
            {
                ghost3Direction = "down";
            }
            if ( ghost3.IntersectsWith(Inva3) && ghost3Direction == "down")
            {
                ghost3Direction = "right";
            }
            if (ghost3.IntersectsWith (Inva2)&& ghost3Direction == "right")
            {
                ghost3Direction = "up";

            }
            if (ghost3.Y >= 150 && ghost3.IntersectsWith(Inva1) && ghost3Direction == "up")//enter
            {
                ghost3Direction = "right";

            }
            if (ghost3.X >= 510 && ghost3.IntersectsWith(Inva5) && ghost3Direction == "right")
            {
                ghost3Direction = "down";
            }
            if (ghost3.Y >= 210 && ghost3Direction == "down")
            {
                ghost3Direction = "right";
            }
            if (ghost3.X >= 207 && ghost3.X >= 520 && ghost3.IntersectsWith(Inva6) && ghost3Direction == "right")
            {
                ghost3Direction = "down";
            }
            if (ghost3.Y <= 300 && ghost3.X >= 520 && ghost3.IntersectsWith(Inva7) && ghost3Direction == "down")
            {
                ghost3Direction = "left";
            }
            if (ghost3.IntersectsWith(Inva8))
            {
                ghost3Direction = "down";
            }


            Refresh();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    playerDirection = "up";

                    break;
                case Keys.S:
                    playerDirection = "down";
                    break;

                case Keys.D:
                    playerDirection = "right";
                    break;

                case Keys.A:
                    playerDirection = "left";
                    break;

                case Keys.Up:
                    playerDirection = "up";
                    break;

                case Keys.Down:
                    playerDirection = "down";
                    break;

                case Keys.Right:
                    playerDirection = "right";
                    break;

                case Keys.Left:
                    playerDirection = "left";
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
                    playerDirection = "up";

                    break;
                case Keys.S:
                    playerDirection = "down";
                    break;

                case Keys.D:
                    playerDirection = "right";
                    break;

                case Keys.A:
                    playerDirection = "left";
                    break;

                case Keys.Up:
                    playerDirection = "up";
                    break;

                case Keys.Down:
                    playerDirection = "down";
                    break;

                case Keys.Right:
                    playerDirection = "right";
                    break;

                case Keys.Left:
                    playerDirection = "left";
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

