using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Net;

namespace Bai05
{
    public partial class Bai05Form : Form
    {
        public Bai05Form()
        {
            InitializeComponent();
            urlTextBox.Text = "https://nt106.uitiot.vn/auth/token";
        }
        private async void loginButton_Click(object sender, EventArgs e)
        {
            var url = urlTextBox.Text;
            var username = nameTextBox.Text;
            var password = passwdTextBox.Text;

            using (var client = new HttpClient())
            {
                // Lấy access token
                var content = new MultipartFormDataContent
            {
                { new StringContent(username), "an" },
                { new StringContent(password), "1" }
            };

                try
                {
                    var response = await client.PostAsync(url, content);
                    var responseString = await response.Content.ReadAsStringAsync();
                    var responseObject = JObject.Parse(responseString);

                    if (!response.IsSuccessStatusCode)
                    {
                        var detail = responseObject["detail"].ToString();
                        contentRichTextBox.AppendText($"Detail: {detail}\n\n");
                        return;
                    }

                    var tokenType = responseObject["token_type"].ToString();
                    var accessToken = responseObject["access_token"].ToString();
                    contentRichTextBox.AppendText($"Token type: {tokenType}\n");
                    contentRichTextBox.AppendText($"Access token: {accessToken}\n\n");
                    client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
                    var getUserUrl = "https://nt106.uitiot.vn/api/v1/user/me";
                    var getUserResponse = await client.GetAsync(getUserUrl);
                    var getUserResponseString = await getUserResponse.Content.ReadAsStringAsync();
                    contentRichTextBox.AppendText(getUserResponseString);
                }
                catch (HttpRequestException httpExp)
                {
                    contentRichTextBox.AppendText($"Lỗi kết nối: {httpExp.Message}\n\n");
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Clear();
            passwdTextBox.Clear();
            contentRichTextBox.Clear();
        }
    }
}