using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10A02app
{
    internal static class Program
    {
        public static int c;
        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine("10A02 APP : CONNECTING TO SERVER...10A02WEB \n C#");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new login(args));

            Application.Run(new APp());
        }
    }
}
