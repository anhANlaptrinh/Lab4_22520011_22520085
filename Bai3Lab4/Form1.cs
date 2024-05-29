using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using System.Net.Http;
using System.Net;
using System.IO;
using HtmlAgilityPack;

namespace Bai03
{
    public partial class Bai03Form : Form
    {
        public Bai03Form()
        {
            InitializeComponent();
            InitializeWebView();
        }
        private string filePath = "D:\\bai3.html";
        private string saveDirectory = "D:\\";
        private async void InitializeWebView()
        {
            // Kiểm tra và đảm bảo WebView2 đã được cài đặt
            await webView.EnsureCoreWebView2Async(null);
        }

        private void Checking(string URL)
        {
            if (string.IsNullOrEmpty(urlTextBox.Text))
            {
                MessageBox.Show("BẠN CẦN NHẬP URL!!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            Checking(urlTextBox.Text);
            try
            {
                // Kiểm tra nếu CoreWebView2 đã khởi tạo
                if (webView.CoreWebView2 != null)
                {
                    // Load trang web trong WebView
                    webView.CoreWebView2.Navigate(urlTextBox.Text);
                }
                else
                {
                    MessageBox.Show("WebView chưa được khởi tạo. Vui lòng thử lại sau.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải trang web: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fileDownLoadButton_Click(object sender, EventArgs e)
        {
            Checking(urlTextBox.Text);
            WebClient webClient = new WebClient();
            Stream response = webClient.OpenRead(urlTextBox.Text);
            webClient.DownloadFile(urlTextBox.Text, filePath);
            MessageBox.Show("TẢI VÀ LƯU THÀNH CÔNG!", "THÀNH CÔNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
