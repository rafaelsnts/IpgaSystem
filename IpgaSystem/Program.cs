using System;
using System.Windows.Forms;

namespace IpgaSystem
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //form_Login teste = new form_Login();
            //teste.ShowDialog();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new form_MenuPrincipal());
        }
    }
}
