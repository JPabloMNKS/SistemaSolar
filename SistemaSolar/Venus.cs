﻿using System;
using System.Windows.Forms;

namespace SistemaSolar
{
    public partial class Venus : Form
    {
        public Venus()
        {
            InitializeComponent();
            Program.reproducir("venus");
            if (Program.conectado == "no")
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
        private void Mercurio(object sender, EventArgs e)
        {
            Mercurio mercurio = new Mercurio();
            mercurio.Show();
            this.Close();
        }
        private void Tierra(object sender, EventArgs e)
        {
            Tierra tierra = new Tierra();
            tierra.Show();
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
    }
}
