using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
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

namespace Lab04Bai7
{
    public partial class Themmonan : Form
    {
        private string tokentype;
        private string accesstoken;
        public Themmonan(string tokenType, string accessToken)
        {
            InitializeComponent();
            tokentype = tokenType;
            accesstoken = accessToken;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtgia.Clear();
            txtdiachi.Clear();
            txthinhanh.Clear();
            txtmota.Clear();
        }
        private readonly HttpClient httpClient = new HttpClient
        {
            BaseAddress = new Uri(@"https://nt106.uitiot.vn")
        };
        private async void button2_Click(object sender, EventArgs e)
        {
            string apiUrl = "https://nt106.uitiot.vn/api/v1/monan/add";
            var requestData = new
            {
                ten_mon_an = txtname.Text,
                gia = txtgia.Text,
                mo_ta = txtmota.Text,
                hinh_anh = txthinhanh.Text,
                dia_chi = txtdiachi.Text
            };

            string jsonData = JsonConvert.SerializeObject(requestData);
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            // Gửi yêu cầu POST đến API và nhận phản hồi
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, apiUrl);
            request.Content = content;
            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(tokentype, accesstoken);

            HttpResponseMessage responses = await httpClient.SendAsync(request);

            if (responses.IsSuccessStatusCode)
            {
                MessageBox.Show("Bạn đã thêm món ăn thành công");
            }
        }
    }
}
