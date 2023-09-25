using Microsoft.Extensions.Configuration;

using System;
using System.IO;
using System.Windows.Forms;

namespace UnsplashDesktopSetter
{
    internal static class Program
    {
        private static IConfigurationRoot config;
        public static readonly string apiUrl = "https://api.unsplash.com/";
        public static readonly string verificationEndpoint = "stats/month";
        public static readonly string wallpaperQueryEndpoint = "photos/random?query=wallpaper&count=1&";
        
        public static string url; 

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();
            var key = config.GetSection("APIConfig:AccessKey").Value;
            url = apiUrl + wallpaperQueryEndpoint + "client_id=" + key;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var setupWindow = new SetupWindow();
            while (!setupWindow.submissionWasCorrect)
            {
                Application.Run(setupWindow);
            }
            Application.Run(new MainWindow());
        }
    }
}
