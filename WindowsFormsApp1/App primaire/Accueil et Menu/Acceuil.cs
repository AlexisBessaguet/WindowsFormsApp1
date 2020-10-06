using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Acceuil : Form
    {
        public Acceuil()
        {
            InitializeComponent();
			this.WindowState = FormWindowState.Maximized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Option Op = new Option();
            Op.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChoixNiveau CN = new ChoixNiveau();
            CN.Show();
        }

		private void Acceuil_Load(object sender, EventArgs e)
		{

		}
	}
}
