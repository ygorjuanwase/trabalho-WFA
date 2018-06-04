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
        
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            MenuComputadores computadores = new MenuComputadores();
            computadores.Show();
            if (txtMarca.Text.Length < 5)
            {
                MessageBox.Show("Marca deve conter mais de 5 letras");
                txtMarca.Focus();
                return;
            }
            if (txtTamanhoDoCpu.Text.Length <= 5)
            {
                MessageBox.Show("Tamanho da Cpu deve conter mais de 5 leras");
                txtTamanhoDoCpu.Focus();
                return;
            }
            if (cbMemoriaRan.SelectedIndex < 0)
            {
                MessageBox.Show("Memoria RAN Deve ser preenchido.");
                cbMemoriaRan.Focus();
                return;
            }
            if (txtProcessador.Text.Length < 4)
            {
                MessageBox.Show("processador deve conter mais de 4 letras");
                txtProcessador.Focus();
                return;
            }
            if (txtPlacaDeVideo.Text.Length < 4)
            {
                MessageBox.Show("placa de video deve conter mais de 4 letras");
                
                return;
            }

            JogosDeTabuleiro jogostabuleiro = new JogosDeTabuleiro()
            {
              
            };
            if (posicao >= 0)
            {
                Program.jogosTabuleiros[posicao] = jogostabuleiro;
                MessageBox.Show("Cadastro realizado com sucesso");
            }
            else
            {
                Program.jogosTabuleiros.Add(jogostabuleiro);
                MessageBox.Show("Cadastro realizado com sucesso");
            }

            LimparCampos();
            
        }

        private void txtMarca_TextChanged_1(object sender, EventArgs e)
        {
            MenuComputadores computadores = new MenuComputadores();
            computadores.Show();
            Dispose();
        }

       

       

    }
}
