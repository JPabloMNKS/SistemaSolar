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
    public partial class Sol : Form
    {
        public Sol()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Mercurio(object sender, EventArgs e)
        {
            Mercurio mercurio = new Mercurio();
            mercurio.Show();
            this.Close();
        }

        private void Venus(object sender, EventArgs e)
        {
            Venus venus = new Venus();
            venus.Show();
            this.Close();
        }

        private void Tierra(object sender, EventArgs e)
        {
            Tierra tierra = new Tierra();
            tierra.Show();
            this.Close();
        }
    }
}
