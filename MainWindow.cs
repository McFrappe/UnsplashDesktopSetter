using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace UnsplashDesktopSetter
{
    public partial class MainWindow : Form
    {
        private readonly string tempPath = Path.Combine(Path.GetTempPath() + "UWSFetchedWallpaper.jpg");
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
            PictureBox.Image = null;
        }

        private async void FetchNewPictureButtonClick(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response;
                try
                {
                    response = await client.GetAsync(Program.url);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.ToString());
                }

                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                var content = JsonConvert.DeserializeObject<List<ImageContent>>(responseBody);

                PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                PictureBox.Load(content[0].urls.SelectedResolution(ResolutionSelector.SelectedItem.ToString()));
            }

            PictureBox.Image.Save(Path.Combine(Path.GetTempPath() + "UWSFetchedWallpaper.jpg"));
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

        private void SetWallpaperButtonClick(object sender, EventArgs e)
        {
            if (!File.Exists(tempPath))
            {
                Console.WriteLine("Could not set wallpaper, no wallpaper fetched from Unsplash.");
                return;
            }

            if (WallpaperStyleSelector.SelectedIndex < 0)
            {
                Console.WriteLine("Could not set wallpaper; Select a fit for the wallpaper.");
                return;
            }

            try
            {
                SetRegistryValuesForWallpaperStyle();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

            int res = SystemParametersInfo(
                SPI_SETDESKWALLPAPER,
                0,
                tempPath,
                SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);

            if (res == 0)
            {
                Console.WriteLine("Failed to set wallpaper.");
                return;
            }

            Console.WriteLine("Wallpaper set successfully.");
        }
    }
}
