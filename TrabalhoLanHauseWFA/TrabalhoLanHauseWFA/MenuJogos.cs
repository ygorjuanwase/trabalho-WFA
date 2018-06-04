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
    public partial class MenuJogos : Form
    {
        public MenuJogos()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastrarGames games = new CadastrarGames();
            games.Show();
            

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Não tem nenhum usuario selecionado");
                return;
            }

            int linhaSelecionada = dataGridView1.CurrentRow.Index;
            Jogos jogo = Program.jogos[linhaSelecionada];
            new CadastrarGames(jogo, linhaSelecionada).ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Não tem nenhum Jogos selecionado");
                return;
            }
            int linhaSelecionada = dataGridView1.CurrentRow.Index;

            Jogos jogos = Program.jogos[linhaSelecionada];
            DialogResult resultado = MessageBox.Show("Deseja apagar " + jogos.Nome + " o registro?", "AVISO", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {

                Program.jogos.RemoveAt(linhaSelecionada);
                AtualizarLista();
                MessageBox.Show("Registro apagado com seucesso");
            }
            else
            {
                MessageBox.Show("Quase fez M#@$! né");
            }
        }
        private void AtualizarLista()
        {
            dataGridView1.Rows.Clear();
            string busca = txtBuscar.Text.ToLower().Trim();
            for (int i = 0; i < Program.jogos.Count; i++)
            {
                Jogos jogos = Program.jogos[i];
                if (jogos.Nome.ToLower().Trim().Contains(busca) || (jogos.Valor.ToString().Contains(busca) || (jogos.QuantidadeEstoque.ToString().Contains(busca))))
                {

                    dataGridView1.Rows.Add(new object[]{
                    jogos.Nome, jogos.Valor, jogos.QuantidadeEstoque, 

                });
                }
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                AtualizarLista();
            }
        }
    }
}
