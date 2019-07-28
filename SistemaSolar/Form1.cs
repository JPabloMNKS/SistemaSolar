using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            textBox1.Text = e.X.ToString();
            textBox2.Text = e.Y.ToString();

            if(e.X >= 47 && e.X <= 131 && e.Y >= 183 && e.Y <= 256)
            {
                this.Cursor = Cursors.Hand;
                label1.Visible = true;
                label1.Text = "SOL";
                label1.Location = new Point(e.X + 25, e.Y + 25);
            }
            else if (e.X >= 153 && e.X <= 171 && e.Y >= 215 && e.Y <= 230)
            {
                this.Cursor = Cursors.Hand;
                label1.Visible = true;
                label1.Text = "MERCURIO";
                label1.Location = new Point(e.X + 25, e.Y + 25);
            }
            else if (e.X >= 193 && e.X <= 232 && e.Y >= 207 && e.Y <= 236)
            {
                this.Cursor = Cursors.Hand;
                label1.Visible = true;
                label1.Text = "VENUS";
                label1.Location = new Point(e.X + 25, e.Y + 25);
            }
            else if (e.X >= 256 && e.X <= 301 && e.Y >= 203 && e.Y <= 236)
            {
                this.Cursor = Cursors.Hand;
                label1.Visible = true;
                label1.Text = "TIERRA";
                label1.Location = new Point(e.X + 25, e.Y + 25);
            }
            else if (e.X >= 322 && e.X <= 361 && e.Y >= 207 && e.Y <= 235)
            {
                this.Cursor = Cursors.Hand;
                label1.Visible = true;
                label1.Text = "MARTE";
                label1.Location = new Point(e.X + 25, e.Y + 25);
            }
            else if (e.X >= 386 && e.X <= 473 && e.Y >= 188 && e.Y <= 255)
            {
                this.Cursor = Cursors.Hand;
                label1.Visible = true;
                label1.Text = "JUPITER";
                label1.Location = new Point(e.X + 25, e.Y + 25);
            }
            else if (e.X >= 510 && e.X <= 584 && e.Y >= 197 && e.Y <= 251)
            {
                this.Cursor = Cursors.Hand;
                label1.Visible = true;
                label1.Text = "SATURNO";
                label1.Location = new Point(e.X + 25, e.Y + 25);
            }
            else if (e.X >= 616 && e.X <= 668 && e.Y >= 201 && e.Y <= 241)
            {
                this.Cursor = Cursors.Hand;
                label1.Visible = true;
                label1.Text = "URANO";
                label1.Location = new Point(e.X + 25, e.Y + 25);
            }
            else if (e.X >= 693 && e.X <= 736 && e.Y >= 206 && e.Y <= 240)
            {
                this.Cursor = Cursors.Hand;
                label1.Visible = true;
                label1.Text = "NEPTUNO";
                label1.Location = new Point(e.X - 25, e.Y - 25);
            }
            else if (e.X >= 765 && e.X <= 785 && e.Y >= 210 && e.Y <= 230)
            {
                this.Cursor = Cursors.Hand;
                label1.Visible = true;
                label1.Text = "PLUTON";
                label1.Location = new Point(e.X - 25, e.Y - 25);
            }
            else
            {
                this.Cursor = Cursors.Default;
                label1.Visible = false;
            }
        }


    }
}
