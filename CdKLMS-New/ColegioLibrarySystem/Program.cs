using System;
using System.Windows.Forms;
using ColegioLibrarySystem;

namespace ColegioLibrarySystem
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new librarymanagement.LoginForm());
        }
    }
}