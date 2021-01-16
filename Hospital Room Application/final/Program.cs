using System;
using System.Windows.Forms;

namespace final
{
    static class Program
    {
        /// <summary>
        /// Database's connection string
        /// </summary>
        public const string ConnectionString = "Data Source = roomdb.cqqrtfvavnxp.us - east - 2.rds.amazonaws.com,1433; Initial Catalog = Room_datasheet; User ID = clinical; Password=321654987";
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginScreen());
        }
    }
}
