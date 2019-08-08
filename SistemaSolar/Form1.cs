using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaSolar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X >= 0 && e.X <= 82 && e.Y >= 244 && e.Y <= 447)
            {
                this.Cursor = Cursors.Hand;
                label1.Visible = true;
                label1.Text = "SOL";
                label1.Location = new Point(e.X + 25, e.Y + 25);
                pictureBox2.Visible = true;
                pictureBox2.Load("sol09.gif");
            }
            else if (e.X >= 138 && e.X <= 171 && e.Y >= 350 && e.Y <= 375)
            {
                this.Cursor = Cursors.Hand;
                label1.Visible = true;
                label1.Text = "MERCURIO";
                label1.Location = new Point(e.X + 25, e.Y + 25);
                pictureBox2.Visible = true;
                pictureBox2.Load("mercurio01.gif");
            }
            else if (e.X >= 198 && e.X <= 255 && e.Y >= 340 && e.Y <= 383)
            {
                this.Cursor = Cursors.Hand;
                label1.Visible = true;
                label1.Text = "VENUS";
                label1.Location = new Point(e.X + 25, e.Y + 25);
                pictureBox2.Visible = true;
                pictureBox2.Load("venus03.gif");
            }
            else if (e.X >= 288 && e.X <= 355 && e.Y >= 336 && e.Y <= 384)
            {
                this.Cursor = Cursors.Hand;
                label1.Visible = true;
                label1.Text = "TIERRA";
                label1.Location = new Point(e.X + 25, e.Y + 25);
                pictureBox2.Visible = true;
                pictureBox2.Load("tierra01.gif");
            }
            else if (e.X >= 380 && e.X <= 430 && e.Y >= 345 && e.Y <= 380)
            {
                this.Cursor = Cursors.Hand;
                label1.Visible = true;
                label1.Text = "MARTE";
                label1.Location = new Point(e.X + 25, e.Y + 25);
                pictureBox2.Visible = true;
                pictureBox2.Load("marte01.gif");
            }
            else if (e.X >= 508 && e.X <= 665 && e.Y >= 285 && e.Y <= 400)
            {
                this.Cursor = Cursors.Hand;
                label1.Visible = true;
                label1.Text = "JUPITER";
                label1.Location = new Point(e.X + 25, e.Y + 25);
                pictureBox2.Visible = true;
                pictureBox2.Load("jupiter01.gif");
            }
            else if (e.X >= 765 && e.X <= 906 && e.Y >= 297 && e.Y <= 403)
            {
                this.Cursor = Cursors.Hand;
                label1.Visible = true;
                label1.Text = "SATURNO";
                label1.Location = new Point(e.X + 25, e.Y + 25);
                pictureBox2.Visible = true;
                pictureBox2.Load("saturno01.gif");
            }
            else if (e.X >= 1022 && e.X <= 1124 && e.Y >= 315 && e.Y <= 387)
            {
                this.Cursor = Cursors.Hand;
                label1.Visible = true;
                label1.Text = "URANO";
                label1.Location = new Point(e.X + 25, e.Y + 25);
                pictureBox2.Visible = true;
                pictureBox2.Load("urano01.gif");
            }
            else if (e.X >= 1176 && e.X <= 1268 && e.Y >= 309 && e.Y <= 381)
            {
                this.Cursor = Cursors.Hand;
                label1.Visible = true;
                label1.Text = "NEPTUNO";
                label1.Location = new Point(e.X + 25, e.Y + 25);
                pictureBox2.Visible = true;
                pictureBox2.Load("neptuno02.gif");
            }
            else
            {
                this.Cursor = Cursors.Default;
                label1.Visible = false;
                pictureBox2.Visible = false;
            }
        }

        private void PictureBox1_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (e.X >= 0 && e.X <= 82 && e.Y >= 244 && e.Y <= 447)
            {
                Sol sol = new Sol();
                sol.Show();
            }
            else if (e.X >= 138 && e.X <= 171 && e.Y >= 350 && e.Y <= 375)
            {
                Mercurio mercurio = new Mercurio();
                mercurio.Show();
            }
            else if (e.X >= 198 && e.X <= 255 && e.Y >= 340 && e.Y <= 383)
            {
                Venus venus = new Venus();
                venus.Show();
            }
            else if (e.X >= 288 && e.X <= 355 && e.Y >= 336 && e.Y <= 384)
            {
                Tierra tierra = new Tierra();
                tierra.Show();
            }
            else if (e.X >= 380 && e.X <= 430 && e.Y >= 345 && e.Y <= 380)
            {
                Marte marte = new Marte();
                marte.Show();
            }
            else if (e.X >= 508 && e.X <= 665 && e.Y >= 285 && e.Y <= 400)
            {
                Jupiter jupiter = new Jupiter();
                jupiter.Show();
            }
            else if (e.X >= 765 && e.X <= 906 && e.Y >= 297 && e.Y <= 403)
            {
                Saturno saturno = new Saturno();
                saturno.Show();
            }
            else if (e.X >= 1022 && e.X <= 1124 && e.Y >= 315 && e.Y <= 387)
            {
                Urano urano = new Urano();
                urano.Show();
            }
            else if (e.X >= 1176 && e.X <= 1268 && e.Y >= 309 && e.Y <= 381)
            {
                Neptuno neptuno = new Neptuno();
                neptuno.Show();
            }
        }
    }
}
