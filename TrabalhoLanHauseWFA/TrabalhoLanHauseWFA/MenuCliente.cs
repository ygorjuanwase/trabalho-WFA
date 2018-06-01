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
    public partial class MenuCliente : Form
    {
        public MenuCliente()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastrarCliente cadastrar = new CadastrarCliente();
            cadastrar.Show();
        }
        private void AtualizarLista()
        {
            dataGridView1.Rows.Clear();
            string busca = txtBuscar.Text.ToLower().Trim();
            for (int i = 0; i < Program.clientes.Count; i++)
            {
                Cliente clinete = Program.clientes[i];
                if (clinete.Nome.Contains(busca) && (clinete.NomeDeUsuario.Contains(busca) || (clinete.Senha.Contains(busca))))
                {

                    dataGridView1.Rows.Add(new object[]{
                    clinete.Nome, clinete.NomeDeUsuario, clinete.NomeDeUsuario, 

                });
                }
            }
        }
    
   
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Não tem nenhuma peça seleciona");
                return;
            }

            int linhaSelecionada = dataGridView1.CurrentRow.Index;
            Cliente cliente = Program.clientes[linhaSelecionada];
            new CadastrarCliente(cliente, linhaSelecionada).ShowDialog();
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AtualizarLista();
            }
        }

      
    }
}
