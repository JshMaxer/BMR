namespace MovieRecommendationApp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lblmonthgenre = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtmovietitle = new ZBobb.AlphaBlendTextBox();
            this.txtoverview = new ZBobb.AlphaBlendTextBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnrating = new Guna.UI2.WinForms.Guna2Button();
            this.btngenre = new Guna.UI2.WinForms.Guna2Button();
            this.btnexit = new Guna.UI2.WinForms.Guna2Button();
            this.btnnext = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // lblmonthgenre
            // 
            this.lblmonthgenre.AutoSize = true;
            this.lblmonthgenre.BackColor = System.Drawing.Color.Transparent;
            this.lblmonthgenre.Font = new System.Drawing.Font("JetBrains Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmonthgenre.ForeColor = System.Drawing.Color.White;
            this.lblmonthgenre.Location = new System.Drawing.Point(444, 541);
            this.lblmonthgenre.Name = "lblmonthgenre";
            this.lblmonthgenre.Size = new System.Drawing.Size(181, 27);
            this.lblmonthgenre.TabIndex = 5;
            this.lblmonthgenre.Text = "MONTH - GENRE";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.txtmovietitle);
            this.guna2Panel1.Controls.Add(this.txtoverview);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Controls.Add(this.btnrating);
            this.guna2Panel1.Controls.Add(this.btngenre);
            this.guna2Panel1.Location = new System.Drawing.Point(161, 26);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Enabled = true;
            this.guna2Panel1.Size = new System.Drawing.Size(747, 506);
            this.guna2Panel1.TabIndex = 8;
            // 
            // txtmovietitle
            // 
            this.txtmovietitle.BackAlpha = 0;
            this.txtmovietitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtmovietitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmovietitle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtmovietitle.Font = new System.Drawing.Font("JetBrains Mono", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmovietitle.ForeColor = System.Drawing.Color.White;
            this.txtmovietitle.Location = new System.Drawing.Point(328, 8);
            this.txtmovietitle.Multiline = true;
            this.txtmovietitle.Name = "txtmovietitle";
            this.txtmovietitle.ReadOnly = true;
            this.txtmovietitle.ShortcutsEnabled = false;
            this.txtmovietitle.Size = new System.Drawing.Size(416, 63);
            this.txtmovietitle.TabIndex = 1;
            this.txtmovietitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtoverview
            // 
            this.txtoverview.BackAlpha = 0;
            this.txtoverview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtoverview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtoverview.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtoverview.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtoverview.ForeColor = System.Drawing.Color.White;
            this.txtoverview.Location = new System.Drawing.Point(328, 75);
            this.txtoverview.Multiline = true;
            this.txtoverview.Name = "txtoverview";
            this.txtoverview.ReadOnly = true;
            this.txtoverview.ShortcutsEnabled = false;
            this.txtoverview.Size = new System.Drawing.Size(416, 342);
            this.txtoverview.TabIndex = 2;
            this.txtoverview.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::MovieRecommendationApp.Properties.Resources._8_anWV14FKHc9ht1p;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(14, 14);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(308, 477);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 12;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btnrating
            // 
            this.btnrating.BackColor = System.Drawing.Color.Transparent;
            this.btnrating.BorderColor = System.Drawing.Color.White;
            this.btnrating.BorderThickness = 2;
            this.btnrating.FillColor = System.Drawing.Color.Transparent;
            this.btnrating.Font = new System.Drawing.Font("JetBrains Mono", 11.25F);
            this.btnrating.ForeColor = System.Drawing.Color.White;
            this.btnrating.Location = new System.Drawing.Point(548, 429);
            this.btnrating.Name = "btnrating";
            this.btnrating.Size = new System.Drawing.Size(182, 53);
            this.btnrating.TabIndex = 0;
            this.btnrating.Text = "RATING";
            this.btnrating.UseTransparentBackground = true;
            // 
            // btngenre
            // 
            this.btngenre.BackColor = System.Drawing.Color.Transparent;
            this.btngenre.BorderColor = System.Drawing.Color.White;
            this.btngenre.BorderThickness = 2;
            this.btngenre.FillColor = System.Drawing.Color.Transparent;
            this.btngenre.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngenre.ForeColor = System.Drawing.Color.White;
            this.btngenre.Location = new System.Drawing.Point(344, 429);
            this.btngenre.Name = "btngenre";
            this.btngenre.Size = new System.Drawing.Size(182, 53);
            this.btngenre.TabIndex = 0;
            this.btngenre.Text = "GENRE";
            this.btngenre.UseTransparentBackground = true;
            // 
            // btnexit
            // 
            this.btnexit.Animated = true;
            this.btnexit.BackColor = System.Drawing.Color.Transparent;
            this.btnexit.BorderColor = System.Drawing.Color.White;
            this.btnexit.BorderRadius = 5;
            this.btnexit.BorderThickness = 1;
            this.btnexit.FillColor = System.Drawing.Color.Transparent;
            this.btnexit.Font = new System.Drawing.Font("JetBrains Mono", 11.25F);
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.Location = new System.Drawing.Point(5, 541);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(94, 35);
            this.btnexit.TabIndex = 13;
            this.btnexit.Text = "EXIT";
            this.btnexit.UseTransparentBackground = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnnext
            // 
            this.btnnext.Animated = true;
            this.btnnext.BackColor = System.Drawing.Color.Transparent;
            this.btnnext.BorderColor = System.Drawing.Color.White;
            this.btnnext.BorderRadius = 5;
            this.btnnext.BorderThickness = 1;
            this.btnnext.FillColor = System.Drawing.Color.Transparent;
            this.btnnext.Font = new System.Drawing.Font("JetBrains Mono", 11.25F);
            this.btnnext.ForeColor = System.Drawing.Color.White;
            this.btnnext.Location = new System.Drawing.Point(938, 541);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(129, 35);
            this.btnnext.TabIndex = 13;
            this.btnnext.Text = "Next Movie";
            this.btnnext.UseTransparentBackground = true;
            this.btnnext.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::MovieRecommendationApp.Properties.Resources.wallpaperflare_com_wallpaper__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1072, 582);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.lblmonthgenre);
            this.Controls.Add(this.guna2Panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label lblmonthgenre;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnrating;
        private Guna.UI2.WinForms.Guna2Button btngenre;
        private ZBobb.AlphaBlendTextBox txtoverview;
        private ZBobb.AlphaBlendTextBox txtmovietitle;
        private Guna.UI2.WinForms.Guna2Button btnexit;
        private Guna.UI2.WinForms.Guna2Button btnnext;
    }
}

