﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.App_primaire.CP.FrançaisCP.EX1
{
    public partial class EX1FrançaisCP : Form
    {
        public EX1FrançaisCP()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            NiveauFrançaisCP niveauFrançaisCP = new NiveauFrançaisCP();
            niveauFrançaisCP.Show();
        }
    }
}
