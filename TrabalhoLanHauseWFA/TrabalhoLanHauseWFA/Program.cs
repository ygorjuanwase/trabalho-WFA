using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoLanHauseWFA
{
    static class Program
    {
        public static List<Cliente> clientes = new List<Cliente>();
        public static List<Funcionario> funcionario = new List<Funcionario>();
        public static List<Filial> filial = new List<Filial>();
        public static List<JogosDeTabuleiro> jogosTabuleiros = new List<JogosDeTabuleiro>();
        public static List<Computadores> computadore = new List<Computadores>();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TelaInicial());
        }
    }
}
