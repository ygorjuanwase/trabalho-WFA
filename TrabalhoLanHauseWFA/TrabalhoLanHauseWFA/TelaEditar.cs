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
    public partial class TelaEditar : Form
    {
        public TelaEditar()
        {
            InitializeComponent();
        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string marca = txtMarca.Text;
            marca = txtMarca.Text;
        }

        private void txtTamanhoCPU_TextChanged(object sender, EventArgs e)
        {
            int tamanhoCpu = 0;
            try
            {
                tamanhoCpu = Convert.ToInt32(txtTamanhoCPU.Text);

            }
            catch
            {
                MessageBox.Show("Tamanho do Cpu deve Conter somente numeros reais.");
                txtTamanhoCPU.Focus();
                return;
            }
        }

        private void txtProcessador_TextChanged(object sender, EventArgs e)
        {
            string processador = txtProcessador.Text;
            processador = txtProcessador.Text;
        }

        
    }
}
