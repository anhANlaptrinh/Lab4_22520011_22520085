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
using Newtonsoft.Json;

namespace Lab04Bai7
{
    public partial class Form1 : Form
    {
        private string receivedTokenType;
        private string receivedAccessToken;
        private int count = 0;
        public Form1(string tokentype, string accesstoken)
        {
            InitializeComponent();
            flowLayoutPanel1.AutoScroll = true; // Bật thanh cuộn tự động
            flowLayoutPanel1.WrapContents = false; // Không tự động xuống dòng
            receivedTokenType = tokentype;
            receivedAccessToken = accesstoken;
            Hienthimonan();
        }
        private readonly HttpClient httpClient = new HttpClient
        {
            BaseAddress = new Uri(@"https://nt106.uitiot.vn")
        };

        public async void Hienthimonan()
        {
            string apiUrl = "https://nt106.uitiot.vn/api/v1/monan/all";
            var requestData = new
            {
                current = 1,
                pageSize = 5
            };

            string jsonData = JsonConvert.SerializeObject(requestData);
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            // Gửi yêu cầu POST đến API và nhận phản hồi
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, apiUrl);
            request.Content = content;
            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(receivedTokenType, receivedAccessToken);

            HttpResponseMessage responses = await httpClient.SendAsync(request);

            if (responses.IsSuccessStatusCode)
            {
                string responseContent = await responses.Content.ReadAsStringAsync();
                MonAnResponse responseObject = JsonConvert.DeserializeObject<MonAnResponse>(responseContent);

                foreach (var monAn in responseObject.Data)
                {
                    string monan = monAn.TenMonAn;
                    string gia = monAn.Gia.ToString();
                    string diachi = monAn.DiaChi;
                    string nguoidonggop = monAn.NguoiDongGop;
                    string imgurl = monAn.HinhAnh;
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Load(imgurl);
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    // Thêm ProgressBarWithLabel vào FlowLayoutPanel với tên phim và hình ảnh tương ứng
                    Addprogressbar(monan, gia, diachi, nguoidonggop, pictureBox);
                }
            }

        }
        public class MonAnResponse
        {
            public List<MonAn> Data { get; set; }
        }
        private void Addprogressbar(string monan, string gia, string diachi, string nguoidonggop, PictureBox pictureBox)
        {
            Hienthimonan hienthi = new Hienthimonan();
            hienthi.Settenmonan(monan);
            hienthi.Setgiamonan(gia);
            hienthi.Setdiachi(diachi);
            hienthi.Setnguoidonggop(nguoidonggop);
            hienthi.SetPictureBox(pictureBox);
            flowLayoutPanel1.Controls.Add(hienthi);
        }
        public class MonAn
        {
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("ten_mon_an")]
            public string TenMonAn { get; set; }

            [JsonProperty("gia")]
            public decimal Gia { get; set; }

            [JsonProperty("mo_ta")]
            public string MoTa { get; set; }

            [JsonProperty("hinh_anh")]
            public string HinhAnh { get; set; }

            [JsonProperty("dia_chi")]
            public string DiaChi { get; set; }

            [JsonProperty("nguoi_dong_gop")]
            public string NguoiDongGop { get; set; }
        }

        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra nếu comboBox2 chưa được chọn thì không thực hiện gì
            if (comboBox2.SelectedItem == null)
                return;

            int currentPage = int.Parse(comboBox1.SelectedItem.ToString());
            int pageSize = int.Parse(comboBox2.SelectedItem.ToString());
            if (count == 0)
            {
                await SendRequest(currentPage, pageSize);
            }
            else if (count == 1)
            {
                await SendRequest1(currentPage, pageSize);
            }
        }

        private async void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
                return;

            int currentPage = int.Parse(comboBox1.SelectedItem.ToString());
            int pageSize = int.Parse(comboBox2.SelectedItem.ToString());
            if (count == 0)
            {
                await SendRequest(currentPage, pageSize);
            }
            else if (count == 1)
            {
                await SendRequest1(currentPage, pageSize);
            }
        }
        private async Task SendRequest(int currentPage, int pageSize)
        {
            string apiUrl = "https://nt106.uitiot.vn/api/v1/monan/all";
            var requestData = new
            {
                current = currentPage,
                pageSize = pageSize,
            };

            string jsonData = JsonConvert.SerializeObject(requestData);
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            // Gửi yêu cầu POST đến API và nhận phản hồi
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, apiUrl);
            request.Content = content;
            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(receivedTokenType, receivedAccessToken);

            HttpResponseMessage responses = await httpClient.SendAsync(request);

            if (responses.IsSuccessStatusCode)
            {
                string responseContent = await responses.Content.ReadAsStringAsync();
                MonAnResponse responseObject = JsonConvert.DeserializeObject<MonAnResponse>(responseContent);

                // Xóa tất cả các controls trong flowLayoutPanel1
                flowLayoutPanel1.Controls.Clear();

                // Hiển thị dữ liệu mới từ phản hồi
                foreach (var monAn in responseObject.Data)
                {
                    string monan = monAn.TenMonAn;
                    string gia = monAn.Gia.ToString();
                    string diachi = monAn.DiaChi;
                    string nguoidonggop = monAn.NguoiDongGop;
                    string imgurl = monAn.HinhAnh;
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Load(imgurl);
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    // Thêm Hienthimonan vào flowLayoutPanel1 với các giá trị tương ứng
                    Addprogressbar(monan, gia, diachi, nguoidonggop, pictureBox);
                }
            }
        }
        private async Task SendRequest1(int currentPage, int pageSize)
        {
            string apiUrl = "https://nt106.uitiot.vn/api/v1/monan/my-dishes";
            var requestData = new
            {
                current = currentPage,
                pageSize = pageSize,
            };

            string jsonData = JsonConvert.SerializeObject(requestData);
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            // Gửi yêu cầu POST đến API và nhận phản hồi
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, apiUrl);
            request.Content = content;
            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(receivedTokenType, receivedAccessToken);

            HttpResponseMessage responses = await httpClient.SendAsync(request);

            if (responses.IsSuccessStatusCode)
            {
                string responseContent = await responses.Content.ReadAsStringAsync();
                MonAnResponse responseObject = JsonConvert.DeserializeObject<MonAnResponse>(responseContent);

                // Xóa tất cả các controls trong flowLayoutPanel1
                flowLayoutPanel1.Controls.Clear();

                // Hiển thị dữ liệu mới từ phản hồi
                foreach (var monAn in responseObject.Data)
                {
                    string monan = monAn.TenMonAn;
                    string gia = monAn.Gia.ToString();
                    string diachi = monAn.DiaChi;
                    string nguoidonggop = monAn.NguoiDongGop;
                    string imgurl = monAn.HinhAnh;
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Load(imgurl);
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    // Thêm Hienthimonan vào flowLayoutPanel1 với các giá trị tương ứng
                    Addprogressbar(monan, gia, diachi, nguoidonggop, pictureBox);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Themmonan them = new Themmonan(receivedTokenType, receivedAccessToken);
            them.Show();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            count = 0;
            if (comboBox2.SelectedItem == null || comboBox1.SelectedItem == null)
                return;

            int currentPage = int.Parse(comboBox1.SelectedItem.ToString());
            int pageSize = int.Parse(comboBox2.SelectedItem.ToString());
            if (count == 0)
            {
                await SendRequest(currentPage, pageSize);
            }
            else if (count == 1)
            {
                await SendRequest1(currentPage, pageSize);
            }
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            count = 1;
            if (comboBox2.SelectedItem == null || comboBox1.SelectedItem == null)
                return;

            int currentPage = int.Parse(comboBox1.SelectedItem.ToString());
            int pageSize = int.Parse(comboBox2.SelectedItem.ToString());
            if (count == 0)
            {
                await SendRequest(currentPage, pageSize);
            }
            else if (count == 1)
            {
                await SendRequest1(currentPage, pageSize);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Control randomControl = GetRandomControl();
            if (randomControl != null)
            {
                // Gửi control đã chọn đến Form2
                Hienthiketquamonan form2 = new Hienthiketquamonan(randomControl);
                form2.Show();
            }
            else
            {
                MessageBox.Show("Không có control nào để hiển thị.");
            }
        }
        public Control GetRandomControl()
        {
            Control randomControl = null;
            List<Control> allControls = flowLayoutPanel1.Controls.Cast<Control>().ToList();

            if (allControls.Count > 0)
            {
                Random random = new Random();
                int randomIndex = random.Next(0, allControls.Count);
                randomControl = allControls[randomIndex];
            }

            return randomControl;
        }
    }
}
