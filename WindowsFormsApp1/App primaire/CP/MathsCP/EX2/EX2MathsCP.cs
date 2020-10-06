using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.App_primaire.MathsCP.EX2
{
    public partial class EX2MathsCP : Form
    {
        public EX2MathsCP()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            using (AideEx2 aideEx2 = new AideEx2())
            {
                aideEx2.ShowDialog();
            }
        }
    }
}
