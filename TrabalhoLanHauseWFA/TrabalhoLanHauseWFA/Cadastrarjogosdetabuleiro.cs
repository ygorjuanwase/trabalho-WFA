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
    public partial class Cadastrarjogosdetabuleiro : Form
    {
        private int posicao = -1;
        public Cadastrarjogosdetabuleiro()
        {
            InitializeComponent();
        }
        private Cadastrarjogosdetabuleiro (JogosDeTabuleiro jogotabuleiro, int posicao)
        {
            this.posicao = posicao;
            InitializeComponent();
            txtNomeDoJogo.Text = jogotabuleiro.NomeDoJogo;
            mtbAnoFabricacao.Text = jogotabuleiro.AnoDeFabricacao;
            txtCriadorJogo.Text = jogotabuleiro.CriadorDoJogo;
            txtQuantidadeJogadores.Text = Convert.ToString(txtQuantidadeJogadores.Text);
            cbEstiloJogo.SelectedItem = jogotabuleiro.EstilodoJogo;
            cbEstiloTAbuleiro.SelectedItem = jogotabuleiro.EstiloDoTabuleiro;
            

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtNomeDoJogo.Text.Length < 5)
            {
                MessageBox.Show("Nome deve apresentar mais de 5 letras");
                txtNomeDoJogo.Focus();
                return;
            }
            if (txtCriadorJogo.Text.Length <= 5)
            {
                MessageBox.Show("Nome do criador deve conter mais de 5 leras");
                txtCriadorJogo.Focus();
                return;
            }
            if (txtQuantidadeJogadores.Text.Length == 0)
            {
                MessageBox.Show("Quantidade de jogadores Deve ser preenchido.");
                txtQuantidadeJogadores.Focus();
                return;
            }
            if (cbEstiloJogo.SelectedIndex < 0)
            {
                MessageBox.Show("Estilo do jogo deve ser preenchido");
                cbEstiloJogo.DroppedDown = true;
                return;
            }
            if (cbEstiloTAbuleiro.SelectedIndex < 0)
            {
                MessageBox.Show("estilo de tabuleiro deve ser preenchido");
                cbEstiloTAbuleiro.DroppedDown = true;
                return;
            }

            JogosDeTabuleiro jogostabuleiro = new JogosDeTabuleiro()
            {
                NomeDoJogo = txtNomeDoJogo.Text.ToLower(),
                AnoDeFabricacao = mtbAnoFabricacao.Text,
                CriadorDoJogo = txtCriadorJogo.Text.ToLower(),
                QuantidadeDeJogadores = Convert.ToInt32(txtQuantidadeJogadores.Text),
                EstilodoJogo = cbEstiloJogo.SelectedItem.ToString(),
                EstiloDoTabuleiro = cbEstiloTAbuleiro.SelectedItem.ToString(),
                sim = radioButton1.Checked
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

        private void LimparCampos()
        {
            txtNomeDoJogo.Text = "";
            mtbAnoFabricacao.Text = "";
            txtCriadorJogo.Text = "";
            txtQuantidadeJogadores.Text = "";
            cbEstiloJogo.SelectedIndex = -1;
            cbEstiloTAbuleiro.SelectedIndex = -1;

              
               
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

    }
}
