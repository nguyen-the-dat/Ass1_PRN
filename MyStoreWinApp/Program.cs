using System.Configuration;
using System;
using System.Windows.Forms;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace MyStoreWinApp
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var builder = new ConfigurationBuilder()
                            .SetBasePath(Directory.GetCurrentDirectory())
                            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfiguration config = builder.Build();

            string email = config["DefaultCredentials:Email"];
            string password = config["DefaultCredentials:Password"];
            //Application.Run(new frmMemberManager());
            Application.Run(new frmLogin(email,password));
        }
    }
}