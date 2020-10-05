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
    public partial class ChoixNiveau : Form
    {
        public ChoixNiveau()
        {
            InitializeComponent();
        }

        private void BoutonCP_Click(object sender, EventArgs e)
        {
            this.Close();
            NiveauMathsCP niveauMathsCP = new NiveauMathsCP();
            niveauMathsCP.Show();
        }

        private void Retour(object sender, EventArgs e)
        {
            this.Close();
            Acceuil acceuil = new Acceuil();
            acceuil.Show();
        }
    }
}
