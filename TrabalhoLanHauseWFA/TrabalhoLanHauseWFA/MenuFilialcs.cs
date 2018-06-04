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
    public partial class MenuFilialcs : Form
    {
        public MenuFilialcs()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CadastrarFIlial CadastrarFilial = new CadastrarFIlial();
            CadastrarFilial.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CadastrarFIlial CadastrarFilial = new CadastrarFIlial();
            CadastrarFilial.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AtualizarLista();
        }
        private void AtualizarLista()
        {
            dataGridView1.Rows.Clear();
            string busca = txtBuscar.Text.ToLower().Trim();
            for (int i = 0; i < Program.filial.Count; i++)
            {
                Filial filial = Program.filial[i];
                if ((filial.NomeFilial.Contains(busca) || (filial.Endereco.Contains(busca))))
                {

                    dataGridView1.Rows.Add(new object[]{
                    filial.NomeFilial, filial.Endereco, filial.Responsavel

                });
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Não tem nenhuma peça seleciona");
                return;
            }
            int linhaSelecionada = dataGridView1.CurrentRow.Index;

            Filial filial = Program.filial[linhaSelecionada];
            DialogResult resultado = MessageBox.Show("Deseja apagar " + filial.NomeFilial + " o registro?", "AVISO", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {

                Program.filial.RemoveAt(linhaSelecionada);
                AtualizarLista();
                MessageBox.Show("Registro apagado com seucesso");
            }
            else
            {
                MessageBox.Show("Ta salvo o seu registro jovem");
            }

        }
    }
}
