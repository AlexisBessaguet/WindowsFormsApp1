using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.App_primaire.MathsCP.EX2;

namespace WindowsFormsApp1
{
    public partial class NiveauMathsCP : Form
    {
        public NiveauMathsCP()
        {
            InitializeComponent();
			this.WindowState = FormWindowState.Maximized;	
		}


		private void Retour_Choix_Click(object sender, EventArgs e)
        {
            this.Close();
            ChoixNiveau choixNiveau = new ChoixNiveau();
            choixNiveau.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            EX1MathsCP eX1MathsCP  = new EX1MathsCP();
            eX1MathsCP.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            EX2MathsCP eX2MathsCP = new EX2MathsCP();
            eX2MathsCP.Show();
        }
    }
}
