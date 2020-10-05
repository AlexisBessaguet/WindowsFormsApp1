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
    public partial class NiveauMathsCP : Form
    {
        public NiveauMathsCP()
        {
            InitializeComponent();
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
    }
}
