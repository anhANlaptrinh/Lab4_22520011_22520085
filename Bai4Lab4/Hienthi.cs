namespace Lab04Bai4
{
    public partial class Hienthi : Form
    {
        public Hienthi()
        {
            InitializeComponent();
        }
        public void Hienthiwweb(string s)
        {
            string url = s;
            webView21.Source = new Uri(url);
        }
    }
}
