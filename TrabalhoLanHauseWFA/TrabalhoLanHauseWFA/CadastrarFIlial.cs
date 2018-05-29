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
        public CadastrarFIlial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuFilialcs menufilial = new MenuFilialcs();
            menufilial.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void txtNomeDaFilial_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
