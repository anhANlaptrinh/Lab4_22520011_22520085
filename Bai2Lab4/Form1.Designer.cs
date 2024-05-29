namespace Bai02
{
    partial class Bai02Form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.downloadTextBox = new System.Windows.Forms.TextBox();
            this.webInputTextBox = new System.Windows.Forms.TextBox();
            this.downloadButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.contentRichTextBox = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.webInputTextBox, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.downloadButton, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.downloadTextBox, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.contentRichTextBox, 0, 4);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 5;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.tableLayoutPanel.SetColumnSpan(this.label1, 2);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập URL:";
            // 
            // downloadTextBox
            // 
            this.downloadTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.downloadTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadTextBox.Location = new System.Drawing.Point(3, 141);
            this.downloadTextBox.Name = "downloadTextBox";
            this.downloadTextBox.Text = "D:\\index.html";
            this.downloadTextBox.Size = new System.Drawing.Size(554, 34);
            this.downloadTextBox.TabIndex = 1;
            // 
            // webInputTextBox
            // 
            this.webInputTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.webInputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.webInputTextBox.Location = new System.Drawing.Point(3, 50);
            this.webInputTextBox.Name = "webInputTextBox";
            this.webInputTextBox.Size = new System.Drawing.Size(554, 34);
            this.webInputTextBox.TabIndex = 2;
            // 
            // downloadButton
            // 
            this.downloadButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.downloadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.downloadButton.Location = new System.Drawing.Point(585, 42);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(181, 50);
            this.downloadButton.TabIndex = 3;
            this.downloadButton.Text = "Tải xuống";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.tableLayoutPanel.SetColumnSpan(this.label2, 2);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lưu tại:";
            // 
            // contentRichTextBox
            // 
            this.tableLayoutPanel.SetColumnSpan(this.contentRichTextBox, 2);
            this.contentRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentRichTextBox.Location = new System.Drawing.Point(3, 183);
            this.contentRichTextBox.Name = "contentRichTextBox";
            this.contentRichTextBox.Size = new System.Drawing.Size(794, 264);
            this.contentRichTextBox.TabIndex = 5;
            this.contentRichTextBox.Text = "";
            // 
            // Bai02Form
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "Bai02Form";
            this.Text = "Biểu mẫu tải xuống";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox downloadTextBox;
        private System.Windows.Forms.TextBox webInputTextBox;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox contentRichTextBox;
    }
}
