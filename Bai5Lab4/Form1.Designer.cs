namespace Bai05
{
    partial class Bai05Form
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.passwdTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.contentRichTextBox = new System.Windows.Forms.RichTextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Username";
            // 
            // urlTextBox
            // 
            this.urlTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlTextBox.Location = new System.Drawing.Point(170, 50);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.ReadOnly = true;
            this.urlTextBox.Size = new System.Drawing.Size(603, 34);
            this.urlTextBox.TabIndex = 4;
            // 
            // passwdTextBox
            // 
            this.passwdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwdTextBox.Location = new System.Drawing.Point(170, 166);
            this.passwdTextBox.Name = "passwdTextBox";
            this.passwdTextBox.PasswordChar = '*';
            this.passwdTextBox.Size = new System.Drawing.Size(292, 34);
            this.passwdTextBox.TabIndex = 5;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(170, 107);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(292, 34);
            this.nameTextBox.TabIndex = 6;
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(483, 97);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(134, 103);
            this.loginButton.TabIndex = 7;
            this.loginButton.Text = "LOGIN";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // contentRichTextBox
            // 
            this.contentRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contentRichTextBox.Location = new System.Drawing.Point(38, 233);
            this.contentRichTextBox.Name = "contentRichTextBox";
            this.contentRichTextBox.ReadOnly = true;
            this.contentRichTextBox.Size = new System.Drawing.Size(735, 251);
            this.contentRichTextBox.TabIndex = 8;
            this.contentRichTextBox.Text = "";
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(639, 97);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(134, 103);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Bai05Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 521);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.contentRichTextBox);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.passwdTextBox);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Bai05Form";
            this.Text = "BAI05";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.TextBox passwdTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.RichTextBox contentRichTextBox;
        private System.Windows.Forms.Button clearButton;
    }
}