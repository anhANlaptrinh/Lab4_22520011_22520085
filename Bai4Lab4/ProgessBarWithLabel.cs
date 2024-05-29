﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04Bai4
{
    public partial class ProgressBarWithLabel : UserControl
    {
        public ProgressBarWithLabel()
        {
            InitializeComponent();
            this.progressBar.Click += ProgressBar_Click;
        }
        public event EventHandler ProgressBarClick;
        public void SetProgress(int value)
        {
            progressBar.Value = value;
        }

        public void SetLabelText(string text)
        {
            label.Text = text;
        }
        public void SetPictureBox(PictureBox picturebox)
        {
            if (picturebox.Image != null)
            {
                pictureBox.Image = (Image)picturebox.Image.Clone();
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Visible = true; // Đảm bảo PictureBox được hiển thị
            }
        }
        public void SetLabellinkText(string text)
        {
            label1.Text = text;
        }

        private void ProgressBar_Click(object sender, EventArgs e)
        {
            ProgressBarClick?.Invoke(this, e);
        }
        public string LinkLabelText
        {
            get { return label1.Text; }
        }
    }
}
