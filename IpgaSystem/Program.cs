using System;
using System.Windows.Forms;
using DevExpress.Xpo.DB;
using IpgaSystem.XPO.IpgaDB;

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

            ConnectionHelper.Connect(AutoCreateOption.None);

            Application.Run(new form_MenuPrincipal());
        }
    }
}
