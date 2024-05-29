using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04Bai4
{
    public partial class Form1 : Form
    {
        private readonly string websiteUrl = "https://betacinemas.vn/phim.htm";
        public Form1()
        {
            InitializeComponent();
            flowLayoutPanel1.AutoScroll = true; // Bật thanh cuộn tự động
            flowLayoutPanel1.WrapContents = false; // Không tự động xuống dòng
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // Tải nội dung HTML từ URL
                HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
                HtmlAgilityPack.HtmlDocument htmlDoc = web.Load(websiteUrl);
                List<string> tenPhimList = new List<string>();
                List<string> imageUrls = new List<string>();
                List<string> links = new List<string>();
                // Trích xuất tên của bộ phim từ cấu trúc HTML
                var h3Nodes = htmlDoc.DocumentNode.SelectNodes("//div[@class='film-info film-xs-info']/h3/a");
                if (h3Nodes != null)
                {
                    foreach (var node in h3Nodes)
                    {
                        string tenBoPhim = node.InnerText.Trim();
                        tenPhimList.Add(tenBoPhim);
                    }
                }

                // Trích xuất URL của tất cả các hình ảnh và thêm chúng vào danh sách
                // Trích xuất URL của hình ảnh từ HTML
                var imgNodes = htmlDoc.DocumentNode.SelectNodes("//div[@class='pi-img-wrapper']/img[@src]");
                if (imgNodes != null)
                {
                    foreach (var imgNode in imgNodes)
                    {
                        string imageUrl = imgNode.GetAttributeValue("src", "");
                        imageUrls.Add(imageUrl);
                    }
                }


                // Trích đường dẫn của bộ phim từ cấu trúc HTML
                var linkNodes = htmlDoc.DocumentNode.SelectNodes("//div[@class='film-info film-xs-info']/h3/a");
                if (linkNodes != null)
                {
                    foreach (var linkNode in linkNodes)
                    {
                        string linkUrl = linkNode.GetAttributeValue("href", "");
                        links.Add(linkUrl);
                    }
                }

                if (tenPhimList.Count > 0 && imageUrls.Count > 0 && links.Count > 0)
                {
                    // Lặp qua các cặp tên phim và URL hình ảnh và đường dẫn
                    int minCount = Math.Min(tenPhimList.Count, Math.Min(imageUrls.Count, links.Count));
                    for (int i = 0; i < minCount; i++)
                    {
                        string tenPhim = tenPhimList[i];
                        string imageUrl = imageUrls[i];
                        string link = links[i];
                        link = "https://betacinemas.vn/" + link;
                        // Tạo PictureBox cho hình ảnh từ URL
                        PictureBox pictureBox = new PictureBox();
                        pictureBox.Load(imageUrl);
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        // Thêm ProgressBarWithLabel vào FlowLayoutPanel với tên phim và hình ảnh tương ứng
                        AddProgressBar(tenPhim, pictureBox, link);
                    }
                }
                else
                {
                    MessageBox.Show("Không có thông tin về các bộ phim hoặc hình ảnh trên trang web.");
                }
            }
            catch (WebException ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tải nội dung HTML từ URL: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
        private void AddProgressBar(string tenPhim, PictureBox pictureBox, string link)
        {
            // Tạo một thể hiện mới của UserControl ProgressBarWithLabel
            ProgressBarWithLabel progressBarWithLabel = new ProgressBarWithLabel();
            progressBarWithLabel.SetLabelText(tenPhim);
            // Thiết lập PictureBox trong ProgressBarWithLabel
            progressBarWithLabel.SetPictureBox(pictureBox);
            progressBarWithLabel.SetLabellinkText(link);
            progressBarWithLabel.ProgressBarClick += ProgressBarWithLabel_Click;
            // Thêm ProgressBarWithLabel vào FlowLayoutPanel
            flowLayoutPanel1.Controls.Add(progressBarWithLabel);
        }
        private void ProgressBarWithLabel_Click(object sender, EventArgs e)
        {
            ProgressBarWithLabel progressBarWithLabel = sender as ProgressBarWithLabel;
            Hienthi hienthi = new Hienthi();
            string s = progressBarWithLabel.LinkLabelText;
            hienthi.Hienthiwweb(s);
            hienthi.Show();
        }
    }
}
