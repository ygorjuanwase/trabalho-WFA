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
    public partial class MenuJogosDeTabuleiro : Form
    {
        public MenuJogosDeTabuleiro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Cadastrarjogosdetabuleiro().ShowDialog();
        }
        private void AtualizarLista()
        {
            dataGridView1.Rows.Clear();
            string busca  = textBox1.Text.ToLower().Trim();
            for (int i = 0; i < Program.jogosTabuleiros.Count; i++)
            {
                JogosDeTabuleiro jogosTabuleiros = Program.jogosTabuleiros[i];
                if (jogosTabuleiros.sim == true && (jogosTabuleiros.NomeDoJogo.Contains(busca) || (jogosTabuleiros.CriadorDoJogo.Contains( busca))))
                {

                dataGridView1.Rows.Add(new object[]{
                   jogosTabuleiros.NomeDoJogo,jogosTabuleiros.CriadorDoJogo, jogosTabuleiros.QuantidadeDeJogadores 

                });
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Não tem nenhum Nome selecionado");
                return;
            }
            int linhaSelecionada = dataGridView1.CurrentRow.Index;

            JogosDeTabuleiro jogosTabuleiros = Program.jogosTabuleiros[linhaSelecionada];
            DialogResult resultado = MessageBox.Show("Deseja apagar " + jogosTabuleiros.NomeDoJogo + " o registro?", "AVISO", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {

                Program.jogosTabuleiros.RemoveAt(linhaSelecionada);
                AtualizarLista();
                MessageBox.Show("Registro apagado com seucesso");
            }
            else
            {
                MessageBox.Show("Sue registro foi salvo.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             if(dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Não tem nenhum Nome selecionado");
                return;
            }

            int linhaSelecionada = dataGridView1.CurrentRow.Index;
            JogosDeTabuleiro jogosTabuleiros = Program.jogosTabuleiros[linhaSelecionada];
            new (jogosTabuleiros, linhaSelecionada).ShowDialog();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AtualizarLista();
            }
        }
    }
}
