using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.App_primaire.CP.FrançaisCP;

namespace WindowsFormsApp1
{
    public partial class ChoixNiveau : Form
    {
        public ChoixNiveau()
        {
            InitializeComponent();
			this.WindowState = FormWindowState.Maximized;
			MathématiquesCP.Hide();
			MathématiquesCE1.Hide();
			MathématiquesCE2.Hide();
			MathématiquesCM1.Hide();
			MathématiquesCM2.Hide();

			FrançaisCP.Hide();
			FrançaisCE1.Hide();
			FrançaisCE2.Hide();
			FrançaisCM1.Hide();
			FrançaisCM2.Hide();

			AnglaisCE2.Hide();
			AnglaisCM1.Hide();
			AnglaisCM2.Hide();

			HistoireCM1.Hide();
			HistoireCM2.Hide();

			GéographieCM1.Hide();
			GéographieCM2.Hide();
		}
        private void Retour(object sender, EventArgs e)
        {
            this.Close();
            Acceuil acceuil = new Acceuil();
            acceuil.Show();
        }


		private void BoutonCP_Click(object sender, EventArgs e)
        {
			MathématiquesCP.Show();
			MathématiquesCE1.Hide();
			MathématiquesCE2.Hide();
			MathématiquesCM1.Hide();
			MathématiquesCM2.Hide();

			FrançaisCP.Show();
			FrançaisCE1.Hide();
			FrançaisCE2.Hide();
			FrançaisCM1.Hide();
			FrançaisCM2.Hide();

			AnglaisCE2.Hide();
			AnglaisCM1.Hide();
			AnglaisCM2.Hide();

			HistoireCM1.Hide();
			HistoireCM2.Hide();

			GéographieCM1.Hide();
			GéographieCM2.Hide();
		}
		private void MathématiquesCP_Click(object sender, EventArgs e)
		{
			this.Close();
			NiveauMathsCP niveauMathsCP = new NiveauMathsCP();
			niveauMathsCP.Show();
		}
		private void FrançaisCP_Click(object sender, EventArgs e)
		{
			this.Close();
			NiveauFrançaisCP niveauFrançaisCP = new NiveauFrançaisCP();
			niveauFrançaisCP.Show();
		}


		private void BoutonCE1_Click(object sender, EventArgs e)
		{
			MathématiquesCP.Hide();
			MathématiquesCE1.Show();
			MathématiquesCE2.Hide();
			MathématiquesCM1.Hide();
			MathématiquesCM2.Hide();

			FrançaisCP.Hide();
			FrançaisCE1.Show();
			FrançaisCE2.Hide();
			FrançaisCM1.Hide();
			FrançaisCM2.Hide();

			AnglaisCE2.Hide();
			AnglaisCM1.Hide();
			AnglaisCM2.Hide();

			HistoireCM1.Hide();
			HistoireCM2.Hide();

			GéographieCM1.Hide();
			GéographieCM2.Hide();
		}
		private void MathématiquesCE1_Click(object sender, EventArgs e)
		{
			this.Close();
			NiveauMathsCP niveauMathsCP = new NiveauMathsCP();
			niveauMathsCP.Show();
		}
		private void FrançaisCE1_Click(object sender, EventArgs e)
		{
			this.Close();
		}


		private void BoutonCE2_Click(object sender, EventArgs e)
		{
			MathématiquesCP.Hide();
			MathématiquesCE1.Hide();
			MathématiquesCE2.Show();
			MathématiquesCM1.Hide();
			MathématiquesCM2.Hide();

			FrançaisCP.Hide();
			FrançaisCE1.Hide();
			FrançaisCE2.Show();
			FrançaisCM1.Hide();
			FrançaisCM2.Hide();

			AnglaisCE2.Show();
			AnglaisCM1.Hide();
			AnglaisCM2.Hide();

			HistoireCM1.Hide();
			HistoireCM2.Hide();

			GéographieCM1.Hide();
			GéographieCM2.Hide();
		}
		private void MathématiquesCE2_Click(object sender, EventArgs e)
		{
			this.Close();
			NiveauMathsCP niveauMathsCP = new NiveauMathsCP();
			niveauMathsCP.Show();
		}
		private void FrançaisCE2_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void AnglaisCE2_Click(object sender, EventArgs e)
		{
			this.Close();
		}


		private void BoutonCM1_Click(object sender, EventArgs e)
		{
			MathématiquesCP.Hide();
			MathématiquesCE1.Hide();
			MathématiquesCE2.Hide();
			MathématiquesCM1.Show();
			MathématiquesCM2.Hide();

			FrançaisCP.Hide();
			FrançaisCE1.Hide();
			FrançaisCE2.Hide();
			FrançaisCM1.Show();
			FrançaisCM2.Hide();

			AnglaisCE2.Hide();
			AnglaisCM1.Show();
			AnglaisCM2.Hide();

			HistoireCM1.Show();
			HistoireCM2.Hide();

			GéographieCM1.Show();
			GéographieCM2.Hide();
		}
		private void MathématiquesCM1_Click(object sender, EventArgs e)
		{
			this.Close();
			NiveauMathsCP niveauMathsCP = new NiveauMathsCP();
			niveauMathsCP.Show();
		}
		private void FrançaisCM1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void AnglaisCM1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void HistoireCM1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void GéographieCM1_Click(object sender, EventArgs e)
		{
			this.Close();
		}


		private void BoutonCM2_Click(object sender, EventArgs e)
		{
			MathématiquesCP.Hide();
			MathématiquesCE1.Hide();
			MathématiquesCE2.Hide();
			MathématiquesCM1.Hide();
			MathématiquesCM2.Show();

			FrançaisCP.Hide();
			FrançaisCE1.Hide();
			FrançaisCE2.Hide();
			FrançaisCM1.Hide();
			FrançaisCM2.Show();

			AnglaisCE2.Hide();
			AnglaisCM1.Hide();
			AnglaisCM2.Show();

			HistoireCM1.Hide();
			HistoireCM2.Show();

			GéographieCM1.Hide();
			GéographieCM2.Show();
		}
		private void MathématiquesCM2_Click(object sender, EventArgs e)
		{
			this.Close();
			NiveauMathsCP niveauMathsCP = new NiveauMathsCP();
			niveauMathsCP.Show();
		}
		private void FrançaisCM2_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void AnglaisCM2_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void HistoireCM2_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void GéographieCM2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		
	}
}
