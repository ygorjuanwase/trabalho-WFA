﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoLanHauseWFA
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int valor = new Random().Next(1, 8);
            if (progressBar1.Value + valor < 100)
            {
                progressBar1.Value = progressBar1.Value + valor;
            }
            else if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + (100 - progressBar1.Value);
            }
            else
            {
                timer1.Enabled = false; // encerra o timer




                this.Hide();
                new MenuLoja().ShowDialog();
                this.Close();
            }
        }
    }
}
