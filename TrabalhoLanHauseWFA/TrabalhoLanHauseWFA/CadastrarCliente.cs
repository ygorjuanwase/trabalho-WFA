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
                txtNome.Focus();
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
                MessageBox.Show("As senhas nao coinciden");
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

            if(mbCEP.Text.Length < 7)
            {
                MessageBox.Show("Cep invalido");
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
                CEP = Convert.ToInt32(mbCEP.Text),
                Bairro = txtBairro.Text,
                Cidade = txtCidade.Text,
                UF = mbUF.Text,
                Referencias = txtReferencias.Text,
                RG = Convert.ToInt32(mbRG.Text),
                CPF = Convert.ToInt32(mbCPF.Text),
                DataDeNascimento = Convert.ToInt32(mbDataDeNascimento.Text),
                TelefoneResidencial = Convert.ToInt32(mbTelefoneResidencial.Text),
                TelefoneCelular = Convert.ToInt32(mbTelefoneCelular.Text),
                TelefoneComercial = Convert.ToInt32(mbTelefoneComercial.Text),
                DataDoCadastro = Convert.ToInt32(mbDataDoCadastro.Text),
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
        }

      

        
      
    }
}
