using System;
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
    public partial class TelaCadastrar : Form
    {
        public TelaCadastrar()
        {
            
            InitializeComponent();
        }

        private void AtualizarLista()
        {
            AtualizarLista();
        }
        private void txtMarca_TextChanged(object sender, EventArgs e)
        {
            string Marca = txtMarca.Text;
            Marca = txtMarca.Text;
        }

        private void txtTamanhoDoCpu_TextChanged(object sender, EventArgs e)
        {
            int tamanhoCpu = 0;
            try
            {
                tamanhoCpu = Convert.ToInt32(txtTamanhoDoCpu.Text);

            }
            catch
            {
                MessageBox.Show("TAmanho do CPU deve conter samente numeros reais.");
                txtTamanhoDoCpu.Focus();
                return;
            }
        }

        private void txtProcessador_TextChanged(object sender, EventArgs e)
        {
            string processador = txtProcessador.Text;
            processador = txtProcessador.Text;
        }

        private void txtPlacaDeVideo_TextChanged(object sender, EventArgs e)
        {
            string placaDeVideo = txtPlacaDeVideo.Text;
            placaDeVideo = txtPlacaDeVideo.Text;
        }

        private void txtPlacaMae_TextChanged(object sender, EventArgs e)
        {
            string placaMae = txtPlacaMae.Text;
            placaMae = txtPlacaMae.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuComputadores computadores = new MenuComputadores();
            computadores.Show();
            Dispose();
        }

        private void txtMarca_TextChanged_1(object sender, EventArgs e)
        {
            MenuComputadores computadores = new MenuComputadores();
            computadores.Show();
            Dispose();
        }

       

       

    }
}
