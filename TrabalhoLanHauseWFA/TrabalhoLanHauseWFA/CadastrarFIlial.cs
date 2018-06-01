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
    public partial class CadastrarFIlial : Form
    {
        private int posicao = -1;
        public CadastrarFIlial()
        {
            InitializeComponent();
        }
        public CadastrarFIlial(Filial filial,int posicao)
        {
            this.posicao = posicao;
            txtNomeDaFilial.Text = filial.NomeFilial;
            txtBairro.Text = filial.Bairro;
            cbPais.SelectedItem = filial.Pais;
            mtbTelefone.Text = filial.Telefone;
            txtEmail.Text = filial.Email;
            txtResponsavel.Text = filial.Responsavel;
            txtCNPJ.Text = filial.CNPJ;
            txtCEp.Text = filial.CEP;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuFilialcs menufilial = new MenuFilialcs();
            menufilial.Show();


            if (txtNomeDaFilial.Text.Length < 5)
            {
                MessageBox.Show("Nome da filial deve ter no minimo cinco(5) letras");
                txtNomeDaFilial.Focus();
                return;
            }
            if (txtBairro.Text.Length < 5)
            {
                MessageBox.Show("Bairro deve conter no  minimo cinco(5) letras");
                txtBairro.Focus();
                return;
            }
            if (cbPais.SelectedIndex < 0)
            {
                MessageBox.Show("Celecione a cidade onde se localiza sua filial");
                cbPais.DroppedDown = true;
                return;
            }
            
            if(txtEmail.Text.Length < 7)
            {
                MessageBox.Show("Email deve conter mais do que sete(7) caracteres");
                txtEmail.Focus();
                return;
            }
            if(txtResponsavel.Text.Length < 5) 
            {
                MessageBox.Show("Responsavel deve conter mais de 5 caracteres.");
                txtResponsavel.Focus();
                return;
            }
            if(txtEndereco.Text.Length <5) 
            {
                MessageBox.Show("Endereço deve conter mais de 5 letras");
                txtEndereco.Focus();
                return;
            }
            if (txtCNPJ.Text.Length == 0)
            {
                MessageBox.Show("CNPJ deve conter apenas numeros");
                txtCNPJ.Focus();
                return;
            }
            if (txtCEp.Text.Length == 0)
            {
                MessageBox.Show("CEP deve comter apenas numeros");
                txtCEp.Focus();
                return;
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void txtNomeDaFilial_TextChanged(object sender, EventArgs e)
        {

            if (txtNomeDaFilial.Text.Length < 5)
            {
                MessageBox.Show("Nome da filial deve ter no minimo cinco(5) letras");
                txtNomeDaFilial.Focus();
                return;
            }
        }

        private void txtBairro_TextChanged(object sender, EventArgs e)
        {
            if (txtBairro.Text.Length < 5)
            {
                MessageBox.Show("Bairro deve conter no  minimo cinco(5) letras");
                txtBairro.Focus();
                return;
            }
        }

        private void cbPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPais.SelectedIndex < 0)
            {
                MessageBox.Show()
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        public string NomeFilial { get; set; }

        public string Bairro { get; set; }

        public object Pais { get; set; }

        public bool telefone { get; set; }
    }
}
