using System;
using System.IO;
using System.Net.Http;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Bai01
{
    public partial class Bai1Form : Form
    {
        public Bai1Form()
        {
            InitializeComponent();
        }

        private async void getButton_Click(object sender, EventArgs e)
        {
            try
            {
                string result = await GetHTMLAsync(webInputTextBox.Text);
                answerRichTextBox.Text = result;
            }
            catch (Exception ex)
            {
                answerRichTextBox.Text = "Lỗi: " + ex.Message;
            }
        }

        private async Task<string> GetHTMLAsync(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                return responseBody;
            }
        }
    }
}
