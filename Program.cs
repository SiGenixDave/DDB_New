using System;
using System.Windows.Forms;

namespace DDB
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            bool createdNew;
            System.Threading.Mutex m = new System.Threading.Mutex(true, "Bombardier DDB", out createdNew);

            if (!createdNew)
            {
                MessageBox.Show("Another instance of the Bombardier Data Dictionary Builder is already running. Can't execute " +
                                "more than 1 instance of the Bombardier Data Dictionary Builder simultaneously.",
                                "Bombardier DDB Startup Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain(args));
        }

        //TODO Tool strip should be disabled when selecting individual cell, only enable when row selected

    }
}