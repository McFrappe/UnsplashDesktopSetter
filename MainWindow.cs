using Microsoft.Extensions.Configuration;
using Microsoft.Win32;

using Newtonsoft.Json;

using System;
using System.IO;
using System.Drawing;
using System.Net.Http;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace UnsplashDesktopSetter
{
    // TODO refactor
    // TODO check how to prevent from sending api keys to the cloud
    public partial class MainWindow : Form
    {
        private HttpClient client = new HttpClient();
        private IConfigurationRoot config;

        private string api_url = "https://api.unsplash.com/";
        private const int SPI_SETDESKWALLPAPER = 0x14;
        private const int SPIF_UPDATEINIFILE = 0x1;
        private const int SPIF_SENDWININICHANGE = 0x02;


        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SystemParametersInfo(
            int uAction,
            int uParam,
            string lpvParam,
            int fuWinIni);

        public enum WallpaperStyle : int
        {
            Tile,
            Center,
            Stretch,
            Fit,
            Span
        }

        public MainWindow()
        {
            InitializeComponent();

            config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();

            pictureBox1.Image = null;
        }

        private async void ShowAPictureButtonClick(object sender, EventArgs e)
        {
            string key = config.GetSection("APIConfig:AccessKey").Value;
            string url = api_url + "photos/random/" + "?client_id=" + key;
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responseBody);

            var content = JsonConvert.DeserializeObject<ImageContent>(responseBody);

            pictureBox1.Load(content.urls.full);
            Bitmap bitmapImage = (Bitmap)pictureBox1.Image;
            bitmapImage.Save(Path.Combine(Path.GetTempPath() + "UWSFetchedWallpaper.jpg"));

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void SetRegistryValuesForWallpaperStyle()
        {
            var style = (WallpaperStyle)Enum.Parse(
                typeof(WallpaperStyle),
                WallpaperStyleSelector.SelectedItem.ToString());

            var key = Registry.CurrentUser.OpenSubKey(
                @"Control Panel\Desktop",
                true);

            if (style == WallpaperStyle.Fit)
            {
                key.SetValue(@"WallpaperStyle", 6.ToString());
                key.SetValue(@"TileWallpaper", 0.ToString());
            } 
            else if (style == WallpaperStyle.Span)
            {
                key.SetValue(@"WallpaperStyle", 22.ToString());
                key.SetValue(@"TileWallpaper", 0.ToString());
            }
            else if (style == WallpaperStyle.Stretch)
            {
                key.SetValue(@"WallpaperStyle", 2.ToString());
                key.SetValue(@"TileWallpaper", 0.ToString());
            }
            else if (style == WallpaperStyle.Center)
            {
                key.SetValue(@"WallpaperStyle", 1.ToString());
                key.SetValue(@"TileWallpaper", 0.ToString());
            }
            else if (style == WallpaperStyle.Tile)
            {
                key.SetValue(@"WallpaperStyle", 1.ToString());
                key.SetValue(@"TileWallpaper", 1.ToString());
            }
        }

        public static int SetDesktopWallpaper()
        {
            string tempPath = Path.Combine(Path.GetTempPath() + "UWSFetchedWallpaper.jpg");

            return SystemParametersInfo(
                SPI_SETDESKWALLPAPER,
                0,
                tempPath,
                SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
        }

        private void SetWallpaperButtonClick(object sender, EventArgs e)
        {
            // TODO: handle if image not in tempPath

            if (WallpaperStyleSelector.SelectedIndex < 0) return;

            SetRegistryValuesForWallpaperStyle();
            if (SetDesktopWallpaper() != 0)
            {
                Console.WriteLine("Wallpaper set successfully.");
            }
            else
            {
                Console.WriteLine("Failed to set wallpaper.");
            }
        }
    }
}
