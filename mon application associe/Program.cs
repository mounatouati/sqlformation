using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace mon_application_associe
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MENU_GENERAL.MENU_GENERAL());
           // MENU_GENERAL.MENU_GENERAL M=new MENU_GENERAL.MENU_GENERAL();
           // M.Visible=true;
        }
    }
}
