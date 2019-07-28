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

            if(e.X >= 0 && e.X <= 82 && e.Y >= 244 && e.Y <= 447)
            {
                this.Cursor = Cursors.Hand;
                label1.Visible = true;
                label1.Text = "SOL";
                label1.Location = new Point(e.X + 25, e.Y + 25);
            }
            else if (e.X >= 138 && e.X <= 171 && e.Y >= 350 && e.Y <= 375)
            {
                this.Cursor = Cursors.Hand;
                label1.Visible = true;
                label1.Text = "MERCURIO";
                label1.Location = new Point(e.X + 25, e.Y + 25);
            }
            else if (e.X >= 198 && e.X <= 255 && e.Y >= 340 && e.Y <= 383)
            {
                this.Cursor = Cursors.Hand;
                label1.Visible = true;
                label1.Text = "VENUS";
                label1.Location = new Point(e.X + 25, e.Y + 25);
            }
            else if (e.X >= 288 && e.X <= 355 && e.Y >= 336 && e.Y <= 384)
            {
                this.Cursor = Cursors.Hand;
                label1.Visible = true;
                label1.Text = "TIERRA";
                label1.Location = new Point(e.X + 25, e.Y + 25);
            }
            else if (e.X >= 380 && e.X <= 430 && e.Y >= 345 && e.Y <= 380)
            {
                this.Cursor = Cursors.Hand;
                label1.Visible = true;
                label1.Text = "MARTE";
                label1.Location = new Point(e.X + 25, e.Y + 25);
            }
            else if (e.X >= 508 && e.X <= 665 && e.Y >= 285 && e.Y <= 400)
            {
                this.Cursor = Cursors.Hand;
                label1.Visible = true;
                label1.Text = "JUPITER";
                label1.Location = new Point(e.X + 25, e.Y + 25);
            }
            else if (e.X >= 765 && e.X <= 906 && e.Y >= 297 && e.Y <= 403)
            {
                this.Cursor = Cursors.Hand;
                label1.Visible = true;
                label1.Text = "SATURNO";
                label1.Location = new Point(e.X + 25, e.Y + 25);
            }
            else if (e.X >= 1022 && e.X <= 1124 && e.Y >= 315 && e.Y <= 387)
            {
                this.Cursor = Cursors.Hand;
                label1.Visible = true;
                label1.Text = "URANO";
                label1.Location = new Point(e.X + 25, e.Y + 25);
            }
            else if (e.X >= 1176 && e.X <= 1268 && e.Y >= 309 && e.Y <= 381)
            {
                this.Cursor = Cursors.Hand;
                label1.Visible = true;
                label1.Text = "NEPTUNO";
                label1.Location = new Point(e.X + 25, e.Y + 25);
            }
            else
            {
                this.Cursor = Cursors.Default;
                label1.Visible = false;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            
        }
    }
}
