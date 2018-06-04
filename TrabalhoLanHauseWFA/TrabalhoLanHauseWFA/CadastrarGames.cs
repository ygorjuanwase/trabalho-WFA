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
    public partial class CadastrarGames : Form
    {
        public int posicao = -1;

        public CadastrarGames()
        {
            InitializeComponent();
        }

        public CadastrarGames(Jogos jogo, int posicao)
        {
            this.posicao = posicao;
            InitializeComponent();
            txtNomeDoJogo.Text = jogo.Nome;
            txtGenero.Text = jogo.Genero;
            txtPlataforma.Text = jogo.Plataforma;
            txtDescricao.Text = jogo.Descricao;
            cbClassificacao.SelectedIndex = jogo.Classificacao;
            txtPlayers.Text = Convert.ToString(jogo.Players);
            txtPreco.Text = Convert.ToString(jogo.Valor);
            textBox1.Text = Convert.ToString(jogo.QuantidadeEstoque);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNomeDoJogo.Text.Length < 0)
            {
                MessageBox.Show("Informe um nome");
                txtNomeDoJogo.Focus();
                return;
            }

            if (cbClassificacao.SelectedIndex < 0)
            {
                MessageBox.Show("Informe uma classificação");
                cbClassificacao.DroppedDown = true;
                return;
            }

            if (txtGenero.Text.Length < 0)
            {
                MessageBox.Show("Informe um gênero");
                txtGenero.Focus();
                return;
            }

            if (txtPlayers.Text.Length < 0)
            {
                MessageBox.Show("Qual a quantidade de players?");
                txtPlayers.Focus();
                return;
            }

            if (txtPlataforma.Text.Length < 0)
            {
                MessageBox.Show("Informe a plataforma");
                txtPlataforma.Focus();
                return;
            }

            if (txtPreco.Text.Length < 0)
            {
                MessageBox.Show("Informe um preço");
                txtPreco.Focus();
                return;
            }
            try
            {
                double preco = Convert.ToDouble(txtPreco.Text);
            }
            catch
            {
                MessageBox.Show("O preço deve apresentar apenas números reais");
                txtPreco.Focus();
                return;
            }


            Jogos jogo = new Jogos()
            {
                Nome = txtNomeDoJogo.Text,
                Genero = txtGenero.Text,
                Plataforma = txtPlataforma.Text,
                Descricao = txtDescricao.Text,
                Classificacao = cbClassificacao.SelectedIndex,
                Players = Convert.ToInt32(txtPlayers.Text),
                Valor = Convert.ToDouble(txtPreco.Text),
                QuantidadeEstoque = Convert.ToInt32(textBox1.Text),
            };

            if (posicao >= 0)
            {
                Program.jogos[posicao] = jogo;
                MessageBox.Show("Cadastro realizado com sucesso");
            }
            else
            {
                Program.jogos.Add(jogo);
                MessageBox.Show("Cadastro realizado com sucesso");
            }

            LimparCampos();


        }
        private void LimparCampos()
        {
            txtNomeDoJogo.Text = "";
            txtGenero.Text = "";
            txtPlataforma.Text = "";
            txtDescricao.Text = "";
            cbClassificacao.SelectedIndex = -1;
            txtPlayers.Text = "";
            txtPreco.Text = "";
            textBox1.Text = "";
            dtpDataLancamento.Value = DateTime.Now;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
