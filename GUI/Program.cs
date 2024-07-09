using BUI;
using DALs4;

namespace GUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var dal = new Repo4();
            var bui = new Service4(dal);
            Application.Run(new Form1(bui));
        }
    }
}