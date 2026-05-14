using System;
using System.Windows.Forms;

namespace Ejercicio3_Refactorizacion
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormRefactorizacion());
        }
    }
}
