
namespace DoordashWebscraper
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.goButton = new System.Windows.Forms.Button();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.downloadButton = new System.Windows.Forms.Button();
            this.startdateTextbox = new System.Windows.Forms.TextBox();
            this.startLabel = new System.Windows.Forms.Label();
            this.enddateTextbox = new System.Windows.Forms.TextBox();
            this.enddateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(32, 46);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(152, 41);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(511, 46);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(143, 41);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password";
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(439, 329);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(112, 58);
            this.goButton.TabIndex = 2;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Location = new System.Drawing.Point(178, 46);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(250, 47);
            this.usernameTextbox.TabIndex = 3;
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(660, 46);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '*';
            this.passwordTextbox.Size = new System.Drawing.Size(250, 47);
            this.passwordTextbox.TabIndex = 4;
            // 
            // downloadButton
            // 
            this.downloadButton.Location = new System.Drawing.Point(392, 462);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(228, 58);
            this.downloadButton.TabIndex = 5;
            this.downloadButton.Text = "Download";
            this.downloadButton.UseVisualStyleBackColor = true;
            // 
            // startdateTextbox
            // 
            this.startdateTextbox.Location = new System.Drawing.Point(190, 179);
            this.startdateTextbox.Name = "startdateTextbox";
            this.startdateTextbox.Size = new System.Drawing.Size(250, 47);
            this.startdateTextbox.TabIndex = 7;
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Location = new System.Drawing.Point(44, 179);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(148, 41);
            this.startLabel.TabIndex = 6;
            this.startLabel.Text = "Start Date";
            // 
            // enddateTextbox
            // 
            this.enddateTextbox.Location = new System.Drawing.Point(660, 179);
            this.enddateTextbox.Name = "enddateTextbox";
            this.enddateTextbox.Size = new System.Drawing.Size(250, 47);
            this.enddateTextbox.TabIndex = 9;
            // 
            // enddateLabel
            // 
            this.enddateLabel.AutoSize = true;
            this.enddateLabel.Location = new System.Drawing.Point(514, 179);
            this.enddateLabel.Name = "enddateLabel";
            this.enddateLabel.Size = new System.Drawing.Size(138, 41);
            this.enddateLabel.TabIndex = 8;
            this.enddateLabel.Text = "End Date";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 804);
            this.Controls.Add(this.enddateTextbox);
            this.Controls.Add(this.enddateLabel);
            this.Controls.Add(this.startdateTextbox);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.usernameTextbox);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.TextBox startdateTextbox;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.TextBox enddateTextbox;
        private System.Windows.Forms.Label enddateLabel;
    }
}

