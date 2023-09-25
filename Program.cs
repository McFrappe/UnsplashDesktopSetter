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
        public static string apiAccessKey = null;

        private static void SetupProcess()
        {
            apiAccessKey = Environment.GetEnvironmentVariable("UWS_API_KEY", EnvironmentVariableTarget.User);
            if (apiAccessKey != null)
            {
                Console.WriteLine("API Access key was found. Skipping setup process.");
                return;
            }

            var setupWindow = new SetupWindow();
            while (!setupWindow.submissionWasCorrect)
            {
                Application.Run(setupWindow);
            }

            Console.WriteLine($"API Access key registered to {Environment.UserName} (USER) environment variables.");
        }

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
            
            SetupProcess();
            Application.Run(new MainWindow());
        }
    }
}
