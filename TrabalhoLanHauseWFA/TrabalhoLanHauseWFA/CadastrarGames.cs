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
        public CadastrarGames()
        {
            InitializeComponent();
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
                MessageBox.Show("Informa uma classificação");
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
            try
            {

                if (txtPreco.Text.Length < 0)
                {
                    MessageBox.Show("Informe um preço");
                    txtPreco.Focus();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Infome um preço valido");
                txtPreco.Focus();
                return;
            }


        }
    }
}
