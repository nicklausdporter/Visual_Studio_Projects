using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace NickMenu
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            NickMenu nickMenu = new NickMenu();
            nickMenu.CustomerName = Interaction.InputBox("Enter your name", "Identification");
            Application.Run(new frmNickMenu(nickMenu));
        }
    }
}
