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
            TelaCadastrar cadastrar = new TelaCadastrar();
            cadastrar.Show();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            TelaEditar editar = new TelaEditar();
            editar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuLoja loja = new MenuLoja();
            loja.Show();
        }
        

      

       

      
    }
}
