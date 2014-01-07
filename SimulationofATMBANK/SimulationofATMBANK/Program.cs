using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulationofATMBANK
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Kullanıcı Kullanıcı1 = new Kullanıcı("Boğaçhan", "Gençtürk", 123456, 6110, 200, 111111, 222222);
            //Kullanıcı Kullanıcı2 = new Kullanıcı("Merve", "Şensoy", 060606, 1234, 500, 333333, 444444);
            //Kullanıcı Kullanıcı3 = new Kullanıcı("Ekrem", "Aksoy", 987654, 4321, 2000, 555555, 666666);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ATMArayüzSON());
        }
    }
}
