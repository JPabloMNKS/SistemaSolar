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
    public partial class Tierra : Form
    {
        public Tierra()
        {
            InitializeComponent();
            if (Program.ProbarConexion() == false)
            {
                webBrowser1.Visible = false;
                btn.Visible = false;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Sol(object sender, EventArgs e)
        {
            Sol sol = new Sol();
            sol.Show();
            this.Close();
        }
        private void Venus(object sender, EventArgs e)
        {
            Venus venus = new Venus();
            venus.Show();
            this.Close();
        }
        private void Marte(object sender, EventArgs e)
        {
            Marte marte = new Marte();
            marte.Show();
            this.Close();
        }
        private void Jupiter(object sender, EventArgs e)
        {
            Jupiter jupiter = new Jupiter();
            jupiter.Show();
            this.Close();
        }
        private void Saturno(object sender, EventArgs e)
        {
            Saturno saturno = new Saturno();
            saturno.Show();
            this.Close();
        }
        private void Urano(object sender, EventArgs e)
        {
            Urano urano = new Urano();
            urano.Show();
            this.Close();
        }
        private void Neptuno(object sender, EventArgs e)
        {
            Neptuno neptuno = new Neptuno();
            neptuno.Show();
            this.Close();
        }
        private void Mercurio(object sender, EventArgs e)
        {
            Mercurio mercurio = new Mercurio();
            mercurio.Show();
            this.Close();
        }
    }
}
