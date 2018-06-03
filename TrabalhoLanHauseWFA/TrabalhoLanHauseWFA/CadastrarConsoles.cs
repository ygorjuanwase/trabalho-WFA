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
    public partial class CadastrarConsoles : Form
    {
        public int posicao = -1;
        public CadastrarConsoles()
        {
            InitializeComponent();
        }

        public CadastrarConsoles(Consoles console, int posicao)
        {
            this.posicao = posicao;
            InitializeComponent();
            txtNomeConsole.Text = console.NomeConsole;
            cbCor.SelectedItem = console.Cor;
            txtAcessorios.Text = console.Acessorios;
            txtPreco.Text = Convert.ToString(console.Preco);
            txtEstoque.Text = Convert.ToString(console.Estoque);
            txtGarantia.Text = Convert.ToString(console.Garantia);
            txtCaracteristcas.Text = console.Caracteristicas;

        }

        private void txtPreco_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNomeConsole.Text.Length < 0)
            {
                MessageBox.Show("Informe o nome do console");
                txtNomeConsole.Focus();
                return;
            }
            if (cbCor.SelectedIndex < 0)
            {
                MessageBox.Show("Informe a cor do produto");
                cbCor.DroppedDown = true;
                return;
            }

            if (txtAcessorios.Text.Length < 0)
            {
                MessageBox.Show("Informe os acessorios");
                txtAcessorios.Focus();
                return;
            }

            if (txtPreco.Text.Length <= 0)
            {
                MessageBox.Show("Informe o preço válido");
                txtPreco.Focus();
                return;
            }
            try
            {
                double valor = Convert.ToDouble(txtPreco.Text);
            }
            catch
            {
                MessageBox.Show("O Preço deve conter apenas números reais");
                txtPreco.Focus();
                return;
            }

            if (txtGarantia.Text.Length < 0)
            {
                MessageBox.Show("Informe o tempo de garantia");
                txtGarantia.Focus();
                return;
            }
            try
            {
                double garantia = Convert.ToDouble(txtGarantia.Text);
            }
            catch
            {
                MessageBox.Show("A garantia deve conter apenas números reais");
                txtGarantia.Focus();
                return;
            }

            if (txtEstoque.Text.Length < 0)
            {
                MessageBox.Show("Informe a qantidade em estóque");
                txtPreco.Focus();
                return;
            }
            try
            {
                double garantia = Convert.ToDouble(txtEstoque.Text);
            }
            catch
            {
                MessageBox.Show("A quantiade em estóque deve apresentar apenas numeros reais animal");
                txtEstoque.Focus();
                return;
            }

            Consoles console = new Consoles()
            {
                NomeConsole = txtNomeConsole.Text,
                Cor = cbCor.SelectedItem.ToString(),
                Acessorios = txtAcessorios.Text,
                Preco = Convert.ToDouble(txtPreco.Text),
                Garantia = Convert.ToDouble(txtGarantia.Text),
                Descricao = txtDescricao.Text,
                Estoque = Convert.ToInt32(txtEstoque.Text),
                DataLancamneto = dtpDataLancamento.Value,
                Caracteristicas = txtCaracteristcas.Text

            };

            if (posicao >= 0)
            {
                Program.consoles[posicao] = console;
                MessageBox.Show("Cadastro realizado com sucesso");
            }
            else
            {
                Program.consoles.Add(console);
                MessageBox.Show("Cadastro realizado com sucesso");
            }

            Limparcampos();
        }
        public void Limparcampos()
        {
            txtNomeConsole.Text = "";
            cbCor.SelectedItem = -1;
            txtAcessorios.Text = "";
            txtPreco.Text = "";
            txtGarantia.Text = "";
            txtDescricao.Text = "";
            txtEstoque.Text = "";
            txtCaracteristcas.Text = "";
        }

        private void cbCor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCor.SelectedItem.ToString() == "Branco")
            {
                pTroca.BackColor = Color.White;
            }
            if (cbCor.SelectedItem.ToString() == "Preto")
            {
                pTroca.BackColor = Color.Black;
            }
            if (cbCor.SelectedItem.ToString() == "Azul")
            {
                pTroca.BackColor = Color.DarkBlue;
            }
            if (cbCor.SelectedItem.ToString() == "Verde")
            {
                pTroca.BackColor = Color.Green;
            }
            if (cbCor.SelectedItem.ToString() == "Amarelo")
            {
                pTroca.BackColor = Color.Yellow;
            }
            if (cbCor.SelectedItem.ToString() == "Cinza")
            {
                pTroca.BackColor = Color.Gray;
            }
        }
    }
}
