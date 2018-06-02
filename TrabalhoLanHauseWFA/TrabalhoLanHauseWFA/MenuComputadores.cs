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
    public partial class MenuComputadores : Form
    {
        public MenuComputadores()
        {
            InitializeComponent();
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            new TelaCadastrar().ShowDialog();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Não tem nenhum Nome selecionado");
                return;
            }
            int linhaSelecionada = dataGridView1.CurrentRow.Index;

            JogosDeTabuleiro jogosTabuleiros = Program.jogosTabuleiros[linhaSelecionada];
            DialogResult resultado = MessageBox.Show("Deseja apagar " +   " o registro?", "AVISO", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {

                Program.jogosTabuleiros.RemoveAt(linhaSelecionada);
                MessageBox.Show("Registro apagado com seucesso");
            }
            else
            {
                MessageBox.Show("Sue registro foi salvo.");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuLoja loja = new MenuLoja();
            loja.Show();
        }
        

      

       

      
    }
}
