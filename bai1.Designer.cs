namespace Bai01
{
    partial class Bai1Form
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
            this.webInputTextBox = new System.Windows.Forms.TextBox();
            this.getButton = new System.Windows.Forms.Button();
            this.answerRichTextBox = new System.Windows.Forms.RichTextBox();
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
            this.tableLayoutPanel.Controls.Add(this.getButton, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.answerRichTextBox, 0, 2);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.tableLayoutPanel.SetColumnSpan(this.label1, 2);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập URL của bạn:";
            // 
            // webInputTextBox
            // 
            this.webInputTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.webInputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.webInputTextBox.Location = new System.Drawing.Point(3, 50);
            this.webInputTextBox.Name = "webInputTextBox";
            this.webInputTextBox.Size = new System.Drawing.Size(554, 34);
            this.webInputTextBox.TabIndex = 1;
            // 
            // getButton
            // 
            this.getButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.getButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getButton.Location = new System.Drawing.Point(585, 49);
            this.getButton.Name = "getButton";
            this.getButton.Size = new System.Drawing.Size(133, 36);
            this.getButton.TabIndex = 2;
            this.getButton.Text = "Lấy";
            this.getButton.UseVisualStyleBackColor = true;
            this.getButton.Click += new System.EventHandler(this.getButton_Click);
            // 
            // answerRichTextBox
            // 
            this.tableLayoutPanel.SetColumnSpan(this.answerRichTextBox, 2);
            this.answerRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.answerRichTextBox.Location = new System.Drawing.Point(3, 93);
            this.answerRichTextBox.Name = "answerRichTextBox";
            this.answerRichTextBox.Size = new System.Drawing.Size(794, 354);
            this.answerRichTextBox.TabIndex = 3;
            this.answerRichTextBox.Text = "";
            // 
            // Bai1Form
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "Bai1Form";
            this.Text = "Bài 1 - Lấy HTML";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox webInputTextBox;
        private System.Windows.Forms.Button getButton;
        private System.Windows.Forms.RichTextBox answerRichTextBox;
    }
}
