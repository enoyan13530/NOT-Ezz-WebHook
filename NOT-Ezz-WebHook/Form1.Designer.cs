namespace NOT_Ezz_WebHook
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WebhookUrl = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.message = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ImagePath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EmbedCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FooterEmbed = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ColorEmbedText = new System.Windows.Forms.TextBox();
            this.ColorEmbedButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.DescriptionEmbed = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.EmbedTitle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ColorEmbed = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // WebhookUrl
            // 
            this.WebhookUrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.WebhookUrl.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.WebhookUrl, "WebhookUrl");
            this.WebhookUrl.Name = "WebhookUrl";
            this.WebhookUrl.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            resources.ApplyResources(this.button1, "button1");
            this.button1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // message
            // 
            this.message.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.message.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.message, "message");
            this.message.Name = "message";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.name.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.name, "name");
            this.name.Name = "name";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // ImagePath
            // 
            this.ImagePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ImagePath.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.ImagePath, "ImagePath");
            this.ImagePath.Name = "ImagePath";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // EmbedCheckbox
            // 
            resources.ApplyResources(this.EmbedCheckbox, "EmbedCheckbox");
            this.EmbedCheckbox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.EmbedCheckbox.Name = "EmbedCheckbox";
            this.EmbedCheckbox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FooterEmbed);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.ColorEmbedText);
            this.groupBox1.Controls.Add(this.ColorEmbedButton);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.DescriptionEmbed);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.EmbedTitle);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // FooterEmbed
            // 
            this.FooterEmbed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.FooterEmbed.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.FooterEmbed, "FooterEmbed");
            this.FooterEmbed.Name = "FooterEmbed";
            this.FooterEmbed.TextChanged += new System.EventHandler(this.FooterEmbed_TextChanged);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // ColorEmbedText
            // 
            this.ColorEmbedText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ColorEmbedText.Cursor = System.Windows.Forms.Cursors.No;
            resources.ApplyResources(this.ColorEmbedText, "ColorEmbedText");
            this.ColorEmbedText.ForeColor = System.Drawing.Color.White;
            this.ColorEmbedText.Name = "ColorEmbedText";
            this.ColorEmbedText.TextChanged += new System.EventHandler(this.ColorEmbedText_TextChanged);
            // 
            // ColorEmbedButton
            // 
            this.ColorEmbedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ColorEmbedButton.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.ColorEmbedButton, "ColorEmbedButton");
            this.ColorEmbedButton.Name = "ColorEmbedButton";
            this.ColorEmbedButton.UseVisualStyleBackColor = false;
            this.ColorEmbedButton.Click += new System.EventHandler(this.ColorEmbedButton_Click);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // DescriptionEmbed
            // 
            this.DescriptionEmbed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.DescriptionEmbed.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.DescriptionEmbed, "DescriptionEmbed");
            this.DescriptionEmbed.Name = "DescriptionEmbed";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // EmbedTitle
            // 
            this.EmbedTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.EmbedTitle.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.EmbedTitle, "EmbedTitle");
            this.EmbedTitle.Name = "EmbedTitle";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.EmbedCheckbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ImagePath);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.message);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.WebhookUrl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox WebhookUrl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ImagePath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox EmbedCheckbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ColorEmbedButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox DescriptionEmbed;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox EmbedTitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColorDialog ColorEmbed;
        private System.Windows.Forms.TextBox ColorEmbedText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox FooterEmbed;
    }
}

