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
    public partial class CadastrarCliente : Form
    {
        private int posicao = -1;
        public CadastrarCliente()
        {
            InitializeComponent();
        }

        public CadastrarCliente(Cliente cliente, int posicao)
        {
            this.posicao = posicao;
            txtNome.Text = cliente.Nome;
            txtSobrenome.Text = cliente.Sobrenome;
            txtNomeUsuario.Text = cliente.NomeDeUsuario;
            txtSenha.Text = cliente.Senha;
            txtComfirmarSenha.Text = cliente.ConfirmarSenha;
            cbSexo.SelectedItem = cliente.Sexo;
            txtLogradouro.Text = cliente.Logradouro;
            txtNumero.Text = Convert.ToString(cliente.Numero);
            txtComplemento.Text = cliente.Complemento;
            mbCEP.Text = Convert.ToString(cliente.CEP);
            txtBairro.Text = cliente.Bairro;
            txtCidade.Text = cliente.Cidade;
            mbUF.Text = cliente.UF;
            txtReferencias.Text = cliente.Referencias;
            mbRG.Text = Convert.ToString(cliente.RG);
            mbCPF.Text = cliente.CPF;
            txtEmail.Text = cliente.Email;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(txtNome.Text.Length < 1)
            {
                MessageBox.Show("Nome não informado");
                txtNome.Focus();
                return;
            }

            if(txtSobrenome.Text.Length < 1)
            {
                MessageBox.Show("Sobrenome Nâo informado");
                txtSobrenome.Focus();
                return;
            }

            if(txtNomeUsuario.Text.Length < 1)
            {
                MessageBox.Show("Nome de usuário nao informado");
                txtNomeUsuario.Focus();
                return;
            }

            if(txtSenha.Text.Length < 8)
            {
                MessageBox.Show("A senha deve ter no mínimo 8 caracteres");
                txtSenha.Focus();
                return;
            }

            if(txtComfirmarSenha.Text != txtSenha.Text)
            {
                MessageBox.Show("As senhas nao coincidem");
                txtComfirmarSenha.Focus();
                return;
            }

            if(cbSexo.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione um sexo");
                cbSexo.Focus();
                return;
            }

            if(txtLogradouro.Text.Length < 1)
            {
                MessageBox.Show("Informe um logradouro");
                txtLogradouro.Focus();
                return;
            }

            if(txtNumero.Text.Length < 1)
            {
                MessageBox.Show("Infome o numero da casa");
                txtNumero.Focus();
                return;
            }

            if(mbCEP.Text.Length < 8)
            {
                MessageBox.Show("Cep inválido");
                mbCEP.Focus();
                return;
            }

            if(txtBairro.Text.Length < 1)
            {
                MessageBox.Show("Informe um bairro");
                txtBairro.Focus();
                return;
            }

            if (txtCidade.Text.Length < 1)
            {
                MessageBox.Show("Informe uma cidade");
                txtCidade.Focus();
                return;
            }

            if(mbUF.Text.Length < 2)
            {
                MessageBox.Show("UF inválido");
                mbUF.Focus();
                return;
            }

            if (mbRG.Text.Length < 8)
            {
                MessageBox.Show("RG inválido");
                mbRG.Focus();
                return;
            }

            if(mbCPF.Text.Length < 11)
            {
                MessageBox.Show("CPF inválido");
                mbCPF.Focus();
                return;
            }


            

            

            Cliente cliente = new Cliente()
            {
                Nome = txtNome.Text,
                Sobrenome = txtSobrenome.Text,
                NomeDeUsuario = txtNomeUsuario.Text,
                Senha = txtSenha.Text,
                ConfirmarSenha = txtComfirmarSenha.Text,
                Sexo = cbSexo.SelectedItem.ToString(),
                Logradouro = txtLogradouro.Text,
                Numero = Convert.ToInt32(txtNumero.Text),
                Complemento = txtComplemento.Text,
                CEP = Convert.ToDouble(mbCEP.Text),
                Bairro = txtBairro.Text,
                Cidade = txtCidade.Text,
                UF = mbUF.Text,
                Referencias = txtReferencias.Text,
                RG = Convert.ToDouble(mbRG.Text),
                CPF = mbCPF.Text,              
                Email = txtEmail.Text
            };

            if (posicao >= 0)
            {
                Program.clientes[posicao] = cliente;
                MessageBox.Show("Cadastro realizado com sucesso");
            }
            else
            {
                Program.clientes.Add(cliente);
                MessageBox.Show("Cadastro realizado com sucesso");
            }

            LimparCampos();
        }
        private void LimparCampos()
        {
                txtNome.Text = "";
                txtSobrenome.Text = "";
                txtNomeUsuario.Text = "";
                txtSenha.Text = "";
                txtComfirmarSenha.Text = "";
                cbSexo.SelectedItem = -1;
                txtLogradouro.Text = "";
                txtNumero.Text = "";
                txtComplemento.Text = "";
                mbCEP.Text = "";
                txtBairro.Text = "";
                txtCidade.Text = "";
                mbUF.Text = "";
                txtReferencias.Text = "";
                mbRG.Text = "";
                mbCPF.Text = "";
                txtEmail.Text = "";
        }

        private void CadastrarCliente_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

      

        
      
    }
}
