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
    public partial class TelaCadastrarFuncionario : Form
    {
        public TelaCadastrarFuncionario()
        {
            InitializeComponent();
        }
     public TelaCadastrarFuncionario(Funcionario funcionario, int posicao)
        {
            txtNome.Text = funcionario.Nome;
            txtSobrenome.Text = funcionario.Sobrenome;
            txtIdade.Text = Convert.ToString(funcionario.Idade);
            mtbCPF.Text = Convert.ToString(funcionario.CPF);
            mtbRG.Text = Convert.ToString(funcionario.RG);
            cbNascionalidade.SelectedItem = funcionario.Nascionalidade;
            txtEndereco.Text = funcionario.Endereco;
            cbCargoPretendido.SelectedItem = funcionario.CargoPretendido;
            cbEscolaridade.SelectedItem = funcionario.Ecolaridade;
            mtbDatadenascimento.Text = Convert.ToString(funcionario.DataDeNascimento);
            cbEstadeoCivil.SelectedItem = funcionario.EstadoCivil;

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        if(txtNome.Text.Length <= 4)
        {
            MessageBox.Show("Nome DEVE Conter Mais e Quatro Letras.");
            txtNome.Focus();
            return;
        }
            if(txtIdade.Text.Length == 14)
            {
                MessageBox.Show("Você sera Nosso Menor Aprendiz");
            }
            else if(txtIdade.Text.Length > 14 && txtIdade.Text.Length < 40)
            {
                MessageBox.Show("Você é nosso Abigo Trabalhador");
            }
            else if(txtIdade.Text.Length >=40 && txtIdade.Text.Length <= 80 )
            {
                MessageBox.Show("VOCÊ È NOSSO ANCIÂO MAIS SABIO.");
            }
            if(txtSobrenome.Text.Length <= 4)
            {
                MessageBox.Show("Sobrenome deve Conter Mais de Quatro(4) letras.");
                txtSobrenome.Focus();
                return;
            }
            if(mtbRG.MaskFull ) 
            { 

            }
            if(mtbCPF.MaskFull )
            {

            }
            if(cbNascionalidade.SelectedIndex < 0)
            {
                MessageBox.Show("Não ten nenhuma Nascionalidade Selecionada.");
                    return;
            }
            if(mtbCEP.MaskFull )
            {

            }

            
        }
    }
}
