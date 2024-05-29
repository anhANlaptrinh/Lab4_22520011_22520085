using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai02
{
    public partial class Bai02Form : Form
    {
        public Bai02Form()
        {
            InitializeComponent();
        }

        private async void downloadButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(webInputTextBox.Text))
            {
                MessageBox.Show("Bạn cần nhập URL.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(downloadTextBox.Text))
            {
                MessageBox.Show("Bạn cần nhập đường dẫn tệp.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                await DownloadFileAsync(webInputTextBox.Text, downloadTextBox.Text);
                string result = await File.ReadAllTextAsync(downloadTextBox.Text);
                contentRichTextBox.Text = result;
                MessageBox.Show("Tải xuống và lưu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải nội dung: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task DownloadFileAsync(string url, string filePath)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                byte[] content = await response.Content.ReadAsByteArrayAsync();
                await File.WriteAllBytesAsync(filePath, content);
            }
        }
    }
}
