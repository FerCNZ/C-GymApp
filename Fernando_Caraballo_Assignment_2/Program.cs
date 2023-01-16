using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fernando_Caraballo_Assignment_2
{
    static class Program
    {
        /// <summary>C:\Users\Admin\source\repos\Fernando_Caraballo_Assignment_2\Fernando_Caraballo_Assignment_2\Database1.mdf
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
        }
    }
}
