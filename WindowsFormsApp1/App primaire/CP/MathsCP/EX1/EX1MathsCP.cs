using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.App_primaire.MathsCP.EX1;
using WindowsFormsApp1.App_primaire.MathsCP.EX2;

namespace WindowsFormsApp1
{
    public partial class EX1MathsCP : Form
    {
        public EX1MathsCP()
        {
            InitializeComponent();
			this.WindowState = FormWindowState.Maximized;
		}



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (AideEx1 aideEx1 = new AideEx1())
            {
                aideEx1.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            ChoixNiveau choixNiveau = new ChoixNiveau();
            choixNiveau.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            EX2MathsCP eX2MathsCP = new EX2MathsCP();
            eX2MathsCP.Show();
        }
    }
}
