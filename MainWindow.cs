using Microsoft.Win32;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace UnsplashDesktopSetter
{
    public partial class MainWindow : Form
    {
        Image _CurrentImage = null;
        string _FullPathToImage = null;
        private const int SPI_SETDESKWALLPAPER = 20;
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
            pictureBox1.Image = _CurrentImage;
        }

        private void ShowAPictureButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                Console.WriteLine("Could not show dialog");
                return;
            }

            pictureBox1.Load(openFileDialog1.FileName);

            if (pictureBox1.Image == null)
            {
                Console.WriteLine("Could not show image, image value is null");
                return;
            }

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            _FullPathToImage = pictureBox1.ImageLocation;
        }

        private void SetWallpaperButton_Click(object sender, EventArgs e)
        {
            if (_FullPathToImage == null)
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

            SystemParametersInfo(SPI_SETDESKWALLPAPER,
                0,
                _FullPathToImage,
                SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
        }
    }
}
