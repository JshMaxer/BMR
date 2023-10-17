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
            this.formmenu = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.bEBUsMOVIERECOMMENDATIONAPPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.formmenu.SuspendLayout();
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
            this.txtoverview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
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
            // formmenu
            // 
            this.formmenu.BackColor = System.Drawing.Color.White;
            this.formmenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.formmenu.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Bold);
            this.formmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bEBUsMOVIERECOMMENDATIONAPPToolStripMenuItem});
            this.formmenu.Name = "formmenu";
            this.formmenu.RenderStyle.ArrowColor = System.Drawing.Color.Empty;
            this.formmenu.RenderStyle.BorderColor = System.Drawing.Color.Black;
            this.formmenu.RenderStyle.ColorTable = null;
            this.formmenu.RenderStyle.RoundedEdges = true;
            this.formmenu.RenderStyle.SelectionArrowColor = System.Drawing.Color.Empty;
            this.formmenu.RenderStyle.SelectionBackColor = System.Drawing.Color.White;
            this.formmenu.RenderStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.formmenu.RenderStyle.SeparatorColor = System.Drawing.Color.Empty;
            this.formmenu.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.formmenu.Size = new System.Drawing.Size(325, 48);
            // 
            // bEBUsMOVIERECOMMENDATIONAPPToolStripMenuItem
            // 
            this.bEBUsMOVIERECOMMENDATIONAPPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eXITToolStripMenuItem1});
            this.bEBUsMOVIERECOMMENDATIONAPPToolStripMenuItem.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEBUsMOVIERECOMMENDATIONAPPToolStripMenuItem.Image = global::MovieRecommendationApp.Properties.Resources.output_onlinepngtools;
            this.bEBUsMOVIERECOMMENDATIONAPPToolStripMenuItem.Name = "bEBUsMOVIERECOMMENDATIONAPPToolStripMenuItem";
            this.bEBUsMOVIERECOMMENDATIONAPPToolStripMenuItem.Size = new System.Drawing.Size(324, 22);
            this.bEBUsMOVIERECOMMENDATIONAPPToolStripMenuItem.Text = "BEBU\'s MOVIE RECOMMENDATION APP";
            // 
            // eXITToolStripMenuItem1
            // 
            this.eXITToolStripMenuItem1.BackColor = System.Drawing.Color.White;
            this.eXITToolStripMenuItem1.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eXITToolStripMenuItem1.Name = "eXITToolStripMenuItem1";
            this.eXITToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.eXITToolStripMenuItem1.ShowShortcutKeys = false;
            this.eXITToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.eXITToolStripMenuItem1.Text = "EXIT";
            this.eXITToolStripMenuItem1.Click += new System.EventHandler(this.eXITToolStripMenuItem1_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::MovieRecommendationApp.Properties.Resources.wallpaperflare_com_wallpaper__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1072, 582);
            this.ContextMenuStrip = this.formmenu;
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
            this.formmenu.ResumeLayout(false);
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
        private Guna.UI2.WinForms.Guna2ContextMenuStrip formmenu;
        private ZBobb.AlphaBlendTextBox txtmovietitle;
        private System.Windows.Forms.ToolStripMenuItem bEBUsMOVIERECOMMENDATIONAPPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem1;
    }
}

