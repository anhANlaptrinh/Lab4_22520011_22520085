using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;

namespace Bai06
{
    public partial class Bai06Form : Form
    {
        public Bai06Form()
        {
            InitializeComponent();
            urlTextBox.Text = "https://nt106.uitiot.vn/auth/token";
            nameTextBox.Text = "an";
            passwdTextBox.Text = "1";
        }

        private async void loginButton_Click(object sender, EventArgs e)
        {
            var url = urlTextBox.Text;
            var username = nameTextBox.Text; // Thay thế bằng tên người dùng của bạn
            var password = passwdTextBox.Text; // Thay thế bằng mật khẩu của bạn

            using (var client = new HttpClient())
            {
                // Lấy access token
                var content = new MultipartFormDataContent
                    {
                        { new StringContent(username), "username" },
                        { new StringContent(password), "password" }
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

                    // Sử dụng access token để xác thực yêu cầu GET
                    client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(tokenType, accessToken);
                    var getUserUrl = "https://nt106.uitiot.vn/api/v1/user/me";
                    var getUserResponse = await client.GetAsync(getUserUrl);
                    var getUserResponseString = await getUserResponse.Content.ReadAsStringAsync();

                    if (getUserResponse.IsSuccessStatusCode)
                    {
                        var userObject = JObject.Parse(getUserResponseString);
                        var id = userObject["id"].ToString();
                        var userName = userObject["username"].ToString();
                        var email = userObject["email"].ToString();
                        var firstName = userObject["first_name"].ToString();
                        var lastName = userObject["last_name"].ToString();
                        var avatar = userObject["avatar"].ToString();
                        var sex = userObject["sex"].ToString();
                        var birthday = userObject["birthday"].ToString();
                        var language = userObject["language"].ToString();
                        var phone = userObject["phone"].ToString();
                        var phoneVerified = userObject["phone_verified"].ToString();
                        var isActive = userObject["is_active"].ToString();
                        var isSuperuser = userObject["is_superuser"].ToString();

                        contentRichTextBox.AppendText($"ID: {id}\n");
                        contentRichTextBox.AppendText($"User Name: {userName}\n");
                        contentRichTextBox.AppendText($"Email: {email}\n");
                        contentRichTextBox.AppendText($"First Name: {firstName}\n");
                        contentRichTextBox.AppendText($"Last Name: {lastName}\n");
                        contentRichTextBox.AppendText($"Avatar: {avatar}\n");
                        contentRichTextBox.AppendText($"Sex: {sex}\n");
                        contentRichTextBox.AppendText($"Birthday: {birthday}\n");
                        contentRichTextBox.AppendText($"Language: {language}\n");
                        contentRichTextBox.AppendText($"Phone: {phone}\n");
                        contentRichTextBox.AppendText($"Phone Verified: {phoneVerified}\n");
                        contentRichTextBox.AppendText($"Active: {isActive}\n");
                        contentRichTextBox.AppendText($"Superuser: {isSuperuser}\n");

                    }
                    else
                    {
                        var detail = responseObject["detail"].ToString();
                        contentRichTextBox.AppendText($"Detail: {detail}\n\n");
                    }
                }
                catch (HttpRequestException httpExp)
                {
                    contentRichTextBox.AppendText($"Lỗi kết nối: {httpExp.Message}\n\n");
                }
            }
        }
    }
}