using System;
using System.Net.Http;
using System.Windows.Forms;

namespace UnsplashDesktopSetter
{
    public partial class SetupWindow : Form
    {
        public bool submissionWasCorrect = false;

        public SetupWindow()
        {
            InitializeComponent();
        }

        private async void APIKeySubmitButtonClick(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(
                    Program.apiUrl +
                    Program.verificationEndpoint +
                    "?client_id=" +
                    APIKeyInputTextBox.Text);

                if (!response.IsSuccessStatusCode)
                {
                    IncorrectAPIKey.Visible = true;
                    System.Media.SystemSounds.Hand.Play();
                    return;
                }

                Environment.SetEnvironmentVariable("UWS_API_KEY", APIKeyInputTextBox.Text, EnvironmentVariableTarget.User);
                submissionWasCorrect = true;
                Dispose();
            }
        }
    }
}
