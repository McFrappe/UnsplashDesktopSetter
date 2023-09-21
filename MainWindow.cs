using System;
using System.Drawing;
using System.Windows.Forms;

namespace UnsplashDesktopSetter
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
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
        }

        private void SetWallpaperButton_Click(object sender, EventArgs e)
        {
            // TODO: set wallpaper logic
        }
    }
}
