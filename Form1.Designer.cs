
namespace Music_Player
{
    partial class MusicPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayer));
            this.topPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.Label();
            this.flexBeat = new System.Windows.Forms.Label();
            this.listBoxSongs = new System.Windows.Forms.ListBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.windowsMedia = new AxWMPLib.AxWindowsMediaPlayer();
            this.copyRight = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsMedia)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.Gray;
            this.topPanel.Controls.Add(this.pictureBox2);
            this.topPanel.Controls.Add(this.pictureBox1);
            this.topPanel.Controls.Add(this.logo);
            this.topPanel.Controls.Add(this.flexBeat);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(675, 62);
            this.topPanel.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(23, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gray;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(614, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // logo
            // 
            this.logo.AutoSize = true;
            this.logo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.logo.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo.Location = new System.Drawing.Point(69, 41);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(83, 15);
            this.logo.TabIndex = 1;
            this.logo.Text = "Feel the Beat!";
            // 
            // flexBeat
            // 
            this.flexBeat.AutoSize = true;
            this.flexBeat.BackColor = System.Drawing.Color.AliceBlue;
            this.flexBeat.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flexBeat.Location = new System.Drawing.Point(69, 16);
            this.flexBeat.Name = "flexBeat";
            this.flexBeat.Size = new System.Drawing.Size(70, 23);
            this.flexBeat.TabIndex = 0;
            this.flexBeat.Text = "flex1.0";
            this.flexBeat.Click += new System.EventHandler(this.flexBeat_Click);
            // 
            // listBoxSongs
            // 
            this.listBoxSongs.BackColor = System.Drawing.Color.MintCream;
            this.listBoxSongs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSongs.FormattingEnabled = true;
            this.listBoxSongs.ItemHeight = 16;
            this.listBoxSongs.Location = new System.Drawing.Point(506, 90);
            this.listBoxSongs.Name = "listBoxSongs";
            this.listBoxSongs.Size = new System.Drawing.Size(145, 228);
            this.listBoxSongs.TabIndex = 1;
            this.listBoxSongs.SelectedIndexChanged += new System.EventHandler(this.listBoxSongs_SelectedIndexChanged);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn1.Location = new System.Drawing.Point(506, 333);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(145, 39);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "Select Song";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // windowsMedia
            // 
            this.windowsMedia.Enabled = true;
            this.windowsMedia.Location = new System.Drawing.Point(23, 90);
            this.windowsMedia.Name = "windowsMedia";
            this.windowsMedia.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("windowsMedia.OcxState")));
            this.windowsMedia.Size = new System.Drawing.Size(477, 282);
            this.windowsMedia.TabIndex = 3;
            // 
            // copyRight
            // 
            this.copyRight.AutoSize = true;
            this.copyRight.BackColor = System.Drawing.Color.Snow;
            this.copyRight.Font = new System.Drawing.Font("Wide Latin", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyRight.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.copyRight.Location = new System.Drawing.Point(274, 387);
            this.copyRight.Name = "copyRight";
            this.copyRight.Size = new System.Drawing.Size(86, 15);
            this.copyRight.TabIndex = 4;
            this.copyRight.Text = "Sanket";
            // 
            // MusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 411);
            this.Controls.Add(this.copyRight);
            this.Controls.Add(this.windowsMedia);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.listBoxSongs);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MusicPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Music Player";
            this.Load += new System.EventHandler(this.MusicPlayer_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsMedia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.Label flexBeat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBoxSongs;
        private System.Windows.Forms.Button btn1;
        private AxWMPLib.AxWindowsMediaPlayer windowsMedia;
        private System.Windows.Forms.Label copyRight;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

