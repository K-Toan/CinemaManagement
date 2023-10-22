using Microsoft.Extensions.Configuration;
using SE1735_Group6_A2.DTL;
using SE1735_Group6_A2.GUI;
using System.Configuration;

namespace SE1735_Group6_A2
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
            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            // Read ConnectionString and bind AppSettings
            AppSettings.ConnectionString = configuration.GetConnectionString("DbConnection");
            AppSettings.AdminUsername = configuration["AdminAccount:Username"];
            AppSettings.AdminPassword = configuration["AdminAccount:Password"];


            ApplicationConfiguration.Initialize();
            Application.Run(new ShowGUI());
        }
    }
}