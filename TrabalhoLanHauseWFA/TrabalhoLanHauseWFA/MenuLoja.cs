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
    public partial class MenuLoja : Form
    {
        public MenuLoja()
        {
            InitializeComponent();
        }

        

        private void btnComputadores_Click(object sender, EventArgs e)
        {
            MenuComputadores computadores = new MenuComputadores();
            computadores.Show();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            MenuFuncionario funcionario = new MenuFuncionario();
            funcionario.Show();
            
        }

        private void btnConsoles_Click(object sender, EventArgs e)
        {
            MenuConsoles consoles = new MenuConsoles();
            consoles.Show();
        }

        private void btnFiliais_Click(object sender, EventArgs e)
        {
            MenuFilialcs filiais = new MenuFilialcs();
            filiais.Show();
        }

        private void btnMangas_Click(object sender, EventArgs e)
        {
            MenuManga manga = new MenuManga();
            manga.Show();
        }

        private void btnTabuleiros_Click(object sender, EventArgs e)
        {
            MenuJogosDeTabuleiro tabuleiros = new MenuJogosDeTabuleiro();
            tabuleiros.Show();
        }

        private void btnGames_Click(object sender, EventArgs e)
        {
            MenuJogos games = new MenuJogos();
            games.Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            MenuCliente cliente = new MenuCliente();
            cliente.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

  
       
    }
}
