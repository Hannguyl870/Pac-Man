namespace Pac_Man
{
    partial class PacMan
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
            this.Titlelable = new System.Windows.Forms.Label();
            this.Subtitlelable1 = new System.Windows.Forms.Label();
            this.Subtitlelable2 = new System.Windows.Forms.Label();
            this.pacmantimer = new System.Windows.Forms.Timer(this.components);
            this.Scorelable = new System.Windows.Forms.Label();
            this.playerlifelable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Titlelable
            // 
            this.Titlelable.BackColor = System.Drawing.Color.Transparent;
            this.Titlelable.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlelable.Location = new System.Drawing.Point(8, -2);
            this.Titlelable.Name = "Titlelable";
            this.Titlelable.Size = new System.Drawing.Size(780, 101);
            this.Titlelable.TabIndex = 0;
            this.Titlelable.Text = "Titlelable";
            this.Titlelable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Subtitlelable1
            // 
            this.Subtitlelable1.BackColor = System.Drawing.Color.Transparent;
            this.Subtitlelable1.Font = new System.Drawing.Font("Algerian", 16F);
            this.Subtitlelable1.Location = new System.Drawing.Point(10, 142);
            this.Subtitlelable1.Name = "Subtitlelable1";
            this.Subtitlelable1.Size = new System.Drawing.Size(783, 42);
            this.Subtitlelable1.TabIndex = 1;
            this.Subtitlelable1.Text = "Subtitlelable1";
            // 
            // Subtitlelable2
            // 
            this.Subtitlelable2.BackColor = System.Drawing.Color.Transparent;
            this.Subtitlelable2.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtitlelable2.Location = new System.Drawing.Point(9, 214);
            this.Subtitlelable2.Name = "Subtitlelable2";
            this.Subtitlelable2.Size = new System.Drawing.Size(783, 42);
            this.Subtitlelable2.TabIndex = 2;
            this.Subtitlelable2.Text = "Subtitlelable2";
            this.Subtitlelable2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // pacmantimer
            // 
            this.pacmantimer.Interval = 20;
            this.pacmantimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Scorelable
            // 
            this.Scorelable.BackColor = System.Drawing.Color.Transparent;
            this.Scorelable.Font = new System.Drawing.Font("Algerian", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scorelable.Location = new System.Drawing.Point(41, 9);
            this.Scorelable.Name = "Scorelable";
            this.Scorelable.Size = new System.Drawing.Size(114, 19);
            this.Scorelable.TabIndex = 3;
            this.Scorelable.Text = "Scorelable";
            this.Scorelable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerlifelable
            // 
            this.playerlifelable.BackColor = System.Drawing.Color.Transparent;
            this.playerlifelable.Font = new System.Drawing.Font("Algerian", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerlifelable.Location = new System.Drawing.Point(617, 9);
            this.playerlifelable.Name = "playerlifelable";
            this.playerlifelable.Size = new System.Drawing.Size(176, 23);
            this.playerlifelable.TabIndex = 4;
            this.playerlifelable.Text = "playerlifelable";
            // 
            // PacMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.playerlifelable);
            this.Controls.Add(this.Scorelable);
            this.Controls.Add(this.Subtitlelable2);
            this.Controls.Add(this.Subtitlelable1);
            this.Controls.Add(this.Titlelable);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PacMan";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PacMan_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Titlelable;
        private System.Windows.Forms.Label Subtitlelable1;
        private System.Windows.Forms.Label Subtitlelable2;
        private System.Windows.Forms.Timer pacmantimer;
        private System.Windows.Forms.Label Scorelable;
        private System.Windows.Forms.Label playerlifelable;
    }
}

