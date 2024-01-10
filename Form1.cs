using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pac_Man
{
    public partial class PacMan : Form
    {
        string mainmenue = "waiting";
        public PacMan()
        {
            InitializeComponent();
        }


        private void PacMan_Paint(object sender, PaintEventArgs e)
        {
            if (mainmenue == "waiting")
            {

                //Score1lable.Text = "";

                //Titlelable.Text = "SPACE RACER";
                //Subtitlelable.Text = "Press Space to start or Esc to exit";

            }
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

        }

    }
}
