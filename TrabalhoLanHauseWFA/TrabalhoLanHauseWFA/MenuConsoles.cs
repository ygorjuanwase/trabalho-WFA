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
    public partial class MenuConsoles : Form
    {
        public MenuConsoles()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastrarConsoles consoles = new CadastrarConsoles();
            consoles.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Não tem nenhum usuario selecionado");
                return;
            }

            int linhaSelecionada = dataGridView1.CurrentRow.Index;
            Consoles console = Program.consoles[linhaSelecionada];
            new CadastrarConsoles(console, linhaSelecionada).ShowDialog();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void AtualizarLista()
        {
            dataGridView1.Rows.Clear();
            string busca = txtBuscar.Text.ToLower().Trim();
            for (int i = 0; i < Program.clientes.Count; i++)
            {
                Consoles console = Program.consoles[i];
                if (console.NomeConsole.ToLower().Trim().Contains(busca) || (console.Preco.ToString().Contains(busca) || (console.Estoque.ToString().Contains(busca))))
                {

                    dataGridView1.Rows.Add(new object[]{
                    console.NomeConsole, console.Preco, console.Estoque, 

                });
                }
            }

        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                AtualizarLista();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Não tem nenhum cliente selecionado");
                return;
            }
            int linhaSelecionada = dataGridView1.CurrentRow.Index;

            Consoles console = Program.consoles[linhaSelecionada];
            DialogResult resultado = MessageBox.Show("Deseja apagar " + console.NomeConsole + " o registro?", "AVISO", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {

                Program.consoles.RemoveAt(linhaSelecionada);
                AtualizarLista();
                MessageBox.Show("Registro apagado com seucesso");
            }
            else
            {
                MessageBox.Show("Quase fez M#@$! né");
            }
            AtualizarLista();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

       
    }
}
