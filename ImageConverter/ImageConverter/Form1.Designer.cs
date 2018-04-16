namespace ImageConverter
{
    partial class Form1
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
            this.SelectImageBtn = new System.Windows.Forms.Button();
            this.ResizeBtn = new System.Windows.Forms.Button();
            this.AndroidBtn = new System.Windows.Forms.Button();
            this.IosBtn = new System.Windows.Forms.Button();
            this.WidthLbl = new System.Windows.Forms.Label();
            this.HeightLbl = new System.Windows.Forms.Label();
            this.VerticleDpiLbl = new System.Windows.Forms.Label();
            this.HorizontalDpiLbl = new System.Windows.Forms.Label();
            this.Width = new System.Windows.Forms.Label();
            this.Height = new System.Windows.Forms.Label();
            this.VerticleDpi = new System.Windows.Forms.Label();
            this.HorizontalDpi = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ResizeText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectImageBtn
            // 
            this.SelectImageBtn.Location = new System.Drawing.Point(140, 355);
            this.SelectImageBtn.Name = "SelectImageBtn";
            this.SelectImageBtn.Size = new System.Drawing.Size(134, 23);
            this.SelectImageBtn.TabIndex = 0;
            this.SelectImageBtn.Text = "Select Image";
            this.SelectImageBtn.UseVisualStyleBackColor = true;
            this.SelectImageBtn.Click += new System.EventHandler(this.SelectImageBtn_Click);
            // 
            // ResizeBtn
            // 
            this.ResizeBtn.Enabled = false;
            this.ResizeBtn.Location = new System.Drawing.Point(447, 364);
            this.ResizeBtn.Name = "ResizeBtn";
            this.ResizeBtn.Size = new System.Drawing.Size(75, 23);
            this.ResizeBtn.TabIndex = 1;
            this.ResizeBtn.Text = "Resize";
            this.ResizeBtn.UseVisualStyleBackColor = true;
            this.ResizeBtn.Click += new System.EventHandler(this.ResizeBtn_Click);
            // 
            // AndroidBtn
            // 
            this.AndroidBtn.Enabled = false;
            this.AndroidBtn.Location = new System.Drawing.Point(782, 318);
            this.AndroidBtn.Name = "AndroidBtn";
            this.AndroidBtn.Size = new System.Drawing.Size(75, 23);
            this.AndroidBtn.TabIndex = 2;
            this.AndroidBtn.Text = "Android";
            this.AndroidBtn.UseVisualStyleBackColor = true;
            this.AndroidBtn.Click += new System.EventHandler(this.AndroidBtn_Click);
            // 
            // IosBtn
            // 
            this.IosBtn.Enabled = false;
            this.IosBtn.Location = new System.Drawing.Point(782, 384);
            this.IosBtn.Name = "IosBtn";
            this.IosBtn.Size = new System.Drawing.Size(75, 23);
            this.IosBtn.TabIndex = 3;
            this.IosBtn.Text = "IOS";
            this.IosBtn.UseVisualStyleBackColor = true;
            this.IosBtn.Click += new System.EventHandler(this.IosBtn_Click);
            // 
            // WidthLbl
            // 
            this.WidthLbl.AutoSize = true;
            this.WidthLbl.Location = new System.Drawing.Point(714, 102);
            this.WidthLbl.Name = "WidthLbl";
            this.WidthLbl.Size = new System.Drawing.Size(35, 13);
            this.WidthLbl.TabIndex = 4;
            this.WidthLbl.Text = "Width";
            // 
            // HeightLbl
            // 
            this.HeightLbl.AutoSize = true;
            this.HeightLbl.Location = new System.Drawing.Point(711, 133);
            this.HeightLbl.Name = "HeightLbl";
            this.HeightLbl.Size = new System.Drawing.Size(38, 13);
            this.HeightLbl.TabIndex = 5;
            this.HeightLbl.Text = "Height";
            // 
            // VerticleDpiLbl
            // 
            this.VerticleDpiLbl.AutoSize = true;
            this.VerticleDpiLbl.Location = new System.Drawing.Point(711, 170);
            this.VerticleDpiLbl.Name = "VerticleDpiLbl";
            this.VerticleDpiLbl.Size = new System.Drawing.Size(63, 13);
            this.VerticleDpiLbl.TabIndex = 6;
            this.VerticleDpiLbl.Text = "Verticle DPI";
            // 
            // HorizontalDpiLbl
            // 
            this.HorizontalDpiLbl.AutoSize = true;
            this.HorizontalDpiLbl.Location = new System.Drawing.Point(714, 215);
            this.HorizontalDpiLbl.Name = "HorizontalDpiLbl";
            this.HorizontalDpiLbl.Size = new System.Drawing.Size(75, 13);
            this.HorizontalDpiLbl.TabIndex = 7;
            this.HorizontalDpiLbl.Text = "Horizontal DPI";
            // 
            // Width
            // 
            this.Width.AutoSize = true;
            this.Width.Location = new System.Drawing.Point(844, 102);
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(13, 13);
            this.Width.TabIndex = 8;
            this.Width.Text = "0";
            // 
            // Height
            // 
            this.Height.AutoSize = true;
            this.Height.Location = new System.Drawing.Point(844, 133);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(13, 13);
            this.Height.TabIndex = 9;
            this.Height.Text = "0";
            // 
            // VerticleDpi
            // 
            this.VerticleDpi.AutoSize = true;
            this.VerticleDpi.Location = new System.Drawing.Point(844, 170);
            this.VerticleDpi.Name = "VerticleDpi";
            this.VerticleDpi.Size = new System.Drawing.Size(13, 13);
            this.VerticleDpi.TabIndex = 10;
            this.VerticleDpi.Text = "0";
            // 
            // HorizontalDpi
            // 
            this.HorizontalDpi.AutoSize = true;
            this.HorizontalDpi.Location = new System.Drawing.Point(844, 215);
            this.HorizontalDpi.Name = "HorizontalDpi";
            this.HorizontalDpi.Size = new System.Drawing.Size(13, 13);
            this.HorizontalDpi.TabIndex = 11;
            this.HorizontalDpi.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox1.Location = new System.Drawing.Point(323, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(401, 307);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "New Size (%100 is original version)";
            // 
            // ResizeText
            // 
            this.ResizeText.Location = new System.Drawing.Point(404, 338);
            this.ResizeText.Name = "ResizeText";
            this.ResizeText.Size = new System.Drawing.Size(163, 20);
            this.ResizeText.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 560);
            this.Controls.Add(this.ResizeText);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.HorizontalDpi);
            this.Controls.Add(this.VerticleDpi);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.Width);
            this.Controls.Add(this.HorizontalDpiLbl);
            this.Controls.Add(this.VerticleDpiLbl);
            this.Controls.Add(this.HeightLbl);
            this.Controls.Add(this.WidthLbl);
            this.Controls.Add(this.IosBtn);
            this.Controls.Add(this.AndroidBtn);
            this.Controls.Add(this.ResizeBtn);
            this.Controls.Add(this.SelectImageBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SelectImageBtn;
        private System.Windows.Forms.Button ResizeBtn;
        private System.Windows.Forms.Button AndroidBtn;
        private System.Windows.Forms.Button IosBtn;
        private System.Windows.Forms.Label WidthLbl;
        private System.Windows.Forms.Label HeightLbl;
        private System.Windows.Forms.Label VerticleDpiLbl;
        private System.Windows.Forms.Label HorizontalDpiLbl;
        private System.Windows.Forms.Label Width;
        private System.Windows.Forms.Label Height;
        private System.Windows.Forms.Label VerticleDpi;
        private System.Windows.Forms.Label HorizontalDpi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ResizeText;
    }
}

