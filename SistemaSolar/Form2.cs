using System;
using System.Windows.Forms;

namespace SistemaSolar
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Sol sol = new Sol();
            sol.Show();
            this.Close();
        }
    }
}
