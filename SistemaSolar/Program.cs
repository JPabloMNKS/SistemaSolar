using System;
using System.Windows.Forms;
using System.Media;

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
            ProbarConexion();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        public static string conectado;
        
        public static void ProbarConexion()
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
                conectado = "si";
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
                webRequest = null;
                conectado = "no";
            }
        }

        public static void reproducir(string nombre)
        {
            SoundPlayer sps = new SoundPlayer();
            sps.SoundLocation = nombre + "w.wav";
            sps.Play();
        }
    }
}
