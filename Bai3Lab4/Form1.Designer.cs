using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Bai03
{
    partial class Bai03Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            urlTextBox = new TextBox();
            loadButton = new Button();
            fileDownLoadButton = new Button();
            webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)webView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 52);
            label1.Name = "label1";
            label1.Size = new Size(242, 29);
            label1.TabIndex = 0;
            label1.Text = "NHẬP URL CỦA BẠN";
            // 
            // urlTextBox
            // 
            urlTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            urlTextBox.Location = new Point(23, 92);
            urlTextBox.Margin = new Padding(3, 4, 3, 4);
            urlTextBox.Name = "urlTextBox";
            urlTextBox.Size = new Size(294, 34);
            urlTextBox.TabIndex = 1;
            // 
            // loadButton
            // 
            loadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loadButton.Location = new Point(323, 32);
            loadButton.Margin = new Padding(3, 4, 3, 4);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(96, 140);
            loadButton.TabIndex = 2;
            loadButton.Text = "TẢI";
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += loadButton_Click;
            // 
            // fileDownLoadButton
            // 
            fileDownLoadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fileDownLoadButton.Location = new Point(424, 67);
            fileDownLoadButton.Margin = new Padding(3, 4, 3, 4);
            fileDownLoadButton.Name = "fileDownLoadButton";
            fileDownLoadButton.Size = new Size(308, 59);
            fileDownLoadButton.TabIndex = 3;
            fileDownLoadButton.Text = "TẢI TỆP TIN";
            fileDownLoadButton.UseVisualStyleBackColor = true;
            fileDownLoadButton.Click += fileDownLoadButton_Click;
            // 
            // webView
            // 
            webView.AllowExternalDrop = true;
            webView.CreationProperties = null;
            webView.DefaultBackgroundColor = Color.White;
            webView.Location = new Point(23, 202);
            webView.Margin = new Padding(3, 4, 3, 4);
            webView.Name = "webView";
            webView.Size = new Size(710, 704);
            webView.TabIndex = 5;
            webView.ZoomFactor = 1D;
            // 
            // Bai03Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 921);
            Controls.Add(webView);
            Controls.Add(fileDownLoadButton);
            Controls.Add(loadButton);
            Controls.Add(urlTextBox);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Bai03Form";
            Text = "BÀI 03";
            ((System.ComponentModel.ISupportInitialize)webView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button fileDownLoadButton;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
    }
}
