/// \file Program.cs
/// \brief Start of the program
/// \author Vyskarka M.
/// \version 1.00

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organizer
{

    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UI_Greeting());
            Controller_Forms Controller = new Controller_Forms();
        }
    }
}
