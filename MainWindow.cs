using Microsoft.Extensions.Configuration;
using Microsoft.Win32;

using Newtonsoft.Json;

using System;
using System.IO;
using System.Net;
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
        Image currentImage = null;
        HttpClient client = new HttpClient();
        private IConfigurationRoot config;
        private Bitmap bitmapImage = null;


        private string fullPathToImage = null;
        private string API_URL = "https://api.unsplash.com/";
        private const int SPI_SETDESKWALLPAPER = 0x14;
        private const int SPIF_UPDATEINIFILE = 0x1;
        private const int SPIF_SENDWININICHANGE = 0x02;


        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

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

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            config = builder.Build();

            pictureBox1.Image = currentImage;
        }

        private async void ShowAPictureButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image?.Dispose();
            pictureBox1.Image = null;

            string key = config.GetSection("APIConfig:AccessKey").Value;
            string url = API_URL + "photos/random/" + "?client_id=" + key;
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responseBody);

            var content = JsonConvert.DeserializeObject<ImageContent>(responseBody);

            pictureBox1.Load(content.urls.full);
            bitmapImage = (Bitmap)pictureBox1.Image;
            // TODO: better storing of this my god
            bitmapImage.Save(Application.StartupPath + "\\image.jpg");

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void SetWallpaperButton_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
            {
                return;
            }

            if (WallpaperStyleSelector.SelectedIndex == -1)
            {
                return;
            }

            WallpaperStyle style = (WallpaperStyle)Enum.Parse(
                typeof(WallpaperStyle),
                WallpaperStyleSelector.SelectedItem.ToString());

            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true);
            if (style == WallpaperStyle.Fit)
            {
                key.SetValue(@"WallpaperStyle", 6.ToString());
                key.SetValue(@"TileWallpaper", 0.ToString());
            }

            if (style == WallpaperStyle.Span)
            {
                key.SetValue(@"WallpaperStyle", 22.ToString());
                key.SetValue(@"TileWallpaper", 0.ToString());
            }

            if (style == WallpaperStyle.Stretch)
            {
                key.SetValue(@"WallpaperStyle", 2.ToString());
                key.SetValue(@"TileWallpaper", 0.ToString());
            }

            if (style == WallpaperStyle.Center)
            {
                key.SetValue(@"WallpaperStyle", 1.ToString());
                key.SetValue(@"TileWallpaper", 0.ToString());
            }

            if (style == WallpaperStyle.Tile)
            {
                key.SetValue(@"WallpaperStyle", 1.ToString());
                key.SetValue(@"TileWallpaper", 1.ToString());
            }

            int result = SystemParametersInfo(SPI_SETDESKWALLPAPER,
                0,
                Application.StartupPath + "\\image.jpg",
                SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);

            if (result != 0)
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
