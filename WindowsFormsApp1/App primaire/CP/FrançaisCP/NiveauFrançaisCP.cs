using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.App_primaire.CP.FrançaisCP.EX1;

namespace WindowsFormsApp1.App_primaire.CP.FrançaisCP
{
    public partial class NiveauFrançaisCP : Form
    {
        public NiveauFrançaisCP()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            EX1FrançaisCP eX1FrançaisCP = new EX1FrançaisCP();
            eX1FrançaisCP.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.Close();
            ChoixNiveau choixNiveau = new ChoixNiveau();
            choixNiveau.Show();
        }
    }
}
