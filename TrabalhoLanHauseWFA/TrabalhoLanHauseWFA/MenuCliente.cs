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
        private void AtualizarLista();

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string busca = txtBuscar.Text.ToLower().Trim();
            for (int i = 0; i < Program.clientes.Count; i++)
            {
                Cliente clinete = Program.clientes[i];
                if (clinete.NomeDeUsuario.Contains(busca) && (clinete..Contains(busca) || (clinete.Marca.Contains(busca))))
                {

                    dataGridView1.Rows.Add(new object[]{
                    clinete.Nome, clinete.Cor, clinete.Marca, clinete.Valor

                });
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

      
    }
}
