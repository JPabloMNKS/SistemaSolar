using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaSolar
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }

        public static bool ProbarConexion()
        {
            System.Uri Url = new System.Uri("http://www.google.com/");
            System.Net.WebRequest webRequest;
            webRequest = System.Net.WebRequest.Create(Url);
            System.Net.WebResponse objResp;
            try
            {
                objResp = webRequest.GetResponse();
                objResp.Close();
                webRequest = null;
                return true;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
                webRequest = null;
                return false;
            }

        }
    }
}
