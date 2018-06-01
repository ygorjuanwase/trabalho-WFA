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
        public static List<Jogos> jogos = new List<Jogos>();
        public static List<Funcionario> funcionario = new List<Funcionario>();
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
