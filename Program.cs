using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Havan_Projeto
{
    static class Program
    {
        private static readonly 
            string pathMoedas = $"{Application.StartupPath}//Moedas.json";
        private static readonly 
            string pathClientes = $"{Application.StartupPath}//Clientes.json";

        [STAThread]
        static void Main()
        {
            if (!File.Exists(pathMoedas))
            {
                using (FileStream MoedasStream =
                    File.Create(pathMoedas))
                {
                    using (StreamWriter MoedasWriter = new StreamWriter(MoedasStream))
                    {
                        MoedasWriter.WriteLine("[]");
                    }
                }
            }

            if (!File.Exists(pathClientes))
            {
                using (FileStream ClientesStream =
                    File.Create(pathClientes))
                {
                    using (StreamWriter ClientesWriter = new StreamWriter(ClientesStream))
                    {
                        ClientesWriter.WriteLine("[]");
                    }
                }
            }

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
