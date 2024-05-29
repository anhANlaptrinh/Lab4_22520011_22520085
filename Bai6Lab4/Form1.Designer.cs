namespace Bai06
{
    partial class Bai06Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.passwdTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.contentRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(174, 91);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(298, 34);
            this.nameTextBox.TabIndex = 3;
            // 
            // urlTextBox
            // 
            this.urlTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlTextBox.Location = new System.Drawing.Point(174, 33);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.ReadOnly = true;
            this.urlTextBox.Size = new System.Drawing.Size(547, 34);
            this.urlTextBox.TabIndex = 4;
            // 
            // passwdTextBox
            // 
            this.passwdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwdTextBox.Location = new System.Drawing.Point(174, 144);
            this.passwdTextBox.Name = "passwdTextBox";
            this.passwdTextBox.ReadOnly = true;
            this.passwdTextBox.Size = new System.Drawing.Size(298, 34);
            this.passwdTextBox.TabIndex = 5;
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(513, 91);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(208, 87);
            this.loginButton.TabIndex = 6;
            this.loginButton.Text = "LOG IN";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // contentRichTextBox
            // 
            this.contentRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contentRichTextBox.Location = new System.Drawing.Point(28, 201);
            this.contentRichTextBox.Name = "contentRichTextBox";
            this.contentRichTextBox.Size = new System.Drawing.Size(693, 463);
            this.contentRichTextBox.TabIndex = 8;
            this.contentRichTextBox.Text = "";
            // 
            // Bai06Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 693);
            this.Controls.Add(this.contentRichTextBox);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwdTextBox);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bai06Form";
            this.Text = "BAI06";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.TextBox passwdTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.RichTextBox contentRichTextBox;
    }
}

