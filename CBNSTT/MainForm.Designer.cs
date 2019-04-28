﻿namespace CBNSTT
{
    partial class MainForm
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
            this.PackerBtn = new System.Windows.Forms.Button();
            this.TextEditBtn = new System.Windows.Forms.Button();
            this.TextureBtn = new System.Windows.Forms.Button();
            this.sndBtn = new System.Windows.Forms.Button();
            this.AboutBtn = new System.Windows.Forms.Button();
            this.FontEdBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PackerBtn
            // 
            this.PackerBtn.Location = new System.Drawing.Point(32, 25);
            this.PackerBtn.Margin = new System.Windows.Forms.Padding(2);
            this.PackerBtn.Name = "PackerBtn";
            this.PackerBtn.Size = new System.Drawing.Size(104, 19);
            this.PackerBtn.TabIndex = 0;
            this.PackerBtn.Text = "Packer tool";
            this.PackerBtn.UseVisualStyleBackColor = true;
            this.PackerBtn.Click += new System.EventHandler(this.PackerBtn_Click);
            // 
            // TextEditBtn
            // 
            this.TextEditBtn.Location = new System.Drawing.Point(176, 25);
            this.TextEditBtn.Margin = new System.Windows.Forms.Padding(2);
            this.TextEditBtn.Name = "TextEditBtn";
            this.TextEditBtn.Size = new System.Drawing.Size(106, 19);
            this.TextEditBtn.TabIndex = 1;
            this.TextEditBtn.Text = "Text Editor";
            this.TextEditBtn.UseVisualStyleBackColor = true;
            this.TextEditBtn.Click += new System.EventHandler(this.TextEditBtn_Click);
            // 
            // TextureBtn
            // 
            this.TextureBtn.Location = new System.Drawing.Point(96, 74);
            this.TextureBtn.Margin = new System.Windows.Forms.Padding(2);
            this.TextureBtn.Name = "TextureBtn";
            this.TextureBtn.Size = new System.Drawing.Size(106, 19);
            this.TextureBtn.TabIndex = 3;
            this.TextureBtn.Text = "Texture Tool";
            this.TextureBtn.UseVisualStyleBackColor = true;
            this.TextureBtn.Click += new System.EventHandler(this.TextureBtn_Click);
            // 
            // sndBtn
            // 
            this.sndBtn.Location = new System.Drawing.Point(257, 74);
            this.sndBtn.Margin = new System.Windows.Forms.Padding(2);
            this.sndBtn.Name = "sndBtn";
            this.sndBtn.Size = new System.Drawing.Size(106, 19);
            this.sndBtn.TabIndex = 4;
            this.sndBtn.Text = "Sound Tool";
            this.sndBtn.UseVisualStyleBackColor = true;
            this.sndBtn.Click += new System.EventHandler(this.sndBtn_Click);
            // 
            // AboutBtn
            // 
            this.AboutBtn.Location = new System.Drawing.Point(187, 116);
            this.AboutBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AboutBtn.Name = "AboutBtn";
            this.AboutBtn.Size = new System.Drawing.Size(81, 19);
            this.AboutBtn.TabIndex = 5;
            this.AboutBtn.Text = "About";
            this.AboutBtn.UseVisualStyleBackColor = true;
            this.AboutBtn.Click += new System.EventHandler(this.AboutBtn_Click);
            // 
            // FontEdBtn
            // 
            this.FontEdBtn.Location = new System.Drawing.Point(316, 25);
            this.FontEdBtn.Name = "FontEdBtn";
            this.FontEdBtn.Size = new System.Drawing.Size(106, 19);
            this.FontEdBtn.TabIndex = 6;
            this.FontEdBtn.Text = "Font Editor";
            this.FontEdBtn.UseVisualStyleBackColor = true;
            this.FontEdBtn.Click += new System.EventHandler(this.FontEdBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 162);
            this.Controls.Add(this.FontEdBtn);
            this.Controls.Add(this.AboutBtn);
            this.Controls.Add(this.sndBtn);
            this.Controls.Add(this.TextureBtn);
            this.Controls.Add(this.TextEditBtn);
            this.Controls.Add(this.PackerBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Crash Bandicoot Tool";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PackerBtn;
        private System.Windows.Forms.Button TextEditBtn;
        private System.Windows.Forms.Button TextureBtn;
        private System.Windows.Forms.Button sndBtn;
        private System.Windows.Forms.Button AboutBtn;
        private System.Windows.Forms.Button FontEdBtn;
    }
}

