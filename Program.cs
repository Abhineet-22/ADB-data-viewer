using System;
using System.Windows.Forms;

namespace AdbDataViewer
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // Initialize the application and run the main form
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
