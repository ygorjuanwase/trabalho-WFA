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
    public partial class MenuFuncionario : Form
    {
        public MenuFuncionario()
        {
            InitializeComponent();
        }

        private void MenuFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TelaCadastrarFuncionario telaCadastrarFuncionario = new TelaCadastrarFuncionario();
            telaCadastrarFuncionario.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TelaCadastrarFuncionario telacadastrar = new TelaCadastrarFuncionario();
            telacadastrar.Show();
        }

        private void AtualizarLista()
        {
            dtgFuncionario.Rows.Clear();
            string busca = txtBusca.Text.ToLower().Trim();
            for(int i = 0; i < Program.funcionario.Count; i++)
            {
                Funcionario funcionario = Program.funcionario[i];
                if(funcionario.ativo == true &&(funcionario.)
            }
        }
    }
}
