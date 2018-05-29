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
    }
}
