namespace WMPDiscordRPC
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
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ProgramTitle = new System.Windows.Forms.Label();
            this.HintText = new System.Windows.Forms.Label();
            this.TrackName = new System.Windows.Forms.Label();
            this.AlbumName = new System.Windows.Forms.Label();
            this.ArtistName = new System.Windows.Forms.Label();
            this.MediaProgress = new System.Windows.Forms.ProgressBar();
            this.CurrentTime = new System.Windows.Forms.Label();
            this.MaxTime = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "WMP Discord RPC";
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(94, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(93, 22);
            this.toolStripMenuItem1.Text = "Exit";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem1_Click);
            // 
            // ProgramTitle
            // 
            this.ProgramTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ProgramTitle.AutoSize = true;
            this.ProgramTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgramTitle.Location = new System.Drawing.Point(5, 8);
            this.ProgramTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProgramTitle.Name = "ProgramTitle";
            this.ProgramTitle.Size = new System.Drawing.Size(280, 45);
            this.ProgramTitle.TabIndex = 0;
            this.ProgramTitle.Text = "WMP Discord RPC";
            this.ProgramTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ProgramTitle.Click += new System.EventHandler(this.Label1_Click);
            // 
            // HintText
            // 
            this.HintText.Location = new System.Drawing.Point(332, 19);
            this.HintText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HintText.Name = "HintText";
            this.HintText.Size = new System.Drawing.Size(177, 34);
            this.HintText.TabIndex = 1;
            this.HintText.Text = "Minimizes to tray, click icon to pop up again";
            // 
            // TrackName
            // 
            this.TrackName.AutoEllipsis = true;
            this.TrackName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrackName.Location = new System.Drawing.Point(9, 75);
            this.TrackName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TrackName.Name = "TrackName";
            this.TrackName.Size = new System.Drawing.Size(276, 26);
            this.TrackName.TabIndex = 5;
            this.TrackName.Text = "Track";
            // 
            // AlbumName
            // 
            this.AlbumName.AutoSize = true;
            this.AlbumName.Location = new System.Drawing.Point(11, 101);
            this.AlbumName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AlbumName.Name = "AlbumName";
            this.AlbumName.Size = new System.Drawing.Size(43, 15);
            this.AlbumName.TabIndex = 6;
            this.AlbumName.Text = "Album";
            // 
            // ArtistName
            // 
            this.ArtistName.AutoSize = true;
            this.ArtistName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArtistName.Location = new System.Drawing.Point(11, 116);
            this.ArtistName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ArtistName.Name = "ArtistName";
            this.ArtistName.Size = new System.Drawing.Size(35, 15);
            this.ArtistName.TabIndex = 7;
            this.ArtistName.Text = "Artist";
            // 
            // MediaProgress
            // 
            this.MediaProgress.BackColor = System.Drawing.SystemColors.Control;
            this.MediaProgress.Location = new System.Drawing.Point(50, 140);
            this.MediaProgress.Margin = new System.Windows.Forms.Padding(2);
            this.MediaProgress.Name = "MediaProgress";
            this.MediaProgress.Size = new System.Drawing.Size(421, 12);
            this.MediaProgress.Step = 1;
            this.MediaProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.MediaProgress.TabIndex = 8;
            // 
            // CurrentTime
            // 
            this.CurrentTime.AutoSize = true;
            this.CurrentTime.Location = new System.Drawing.Point(12, 138);
            this.CurrentTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CurrentTime.Name = "CurrentTime";
            this.CurrentTime.Size = new System.Drawing.Size(34, 15);
            this.CurrentTime.TabIndex = 9;
            this.CurrentTime.Text = "00:00";
            // 
            // MaxTime
            // 
            this.MaxTime.AutoSize = true;
            this.MaxTime.Location = new System.Drawing.Point(475, 140);
            this.MaxTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MaxTime.Name = "MaxTime";
            this.MaxTime.Size = new System.Drawing.Size(34, 15);
            this.MaxTime.TabIndex = 9;
            this.MaxTime.Text = "03:00";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(520, 162);
            this.Controls.Add(this.MaxTime);
            this.Controls.Add(this.CurrentTime);
            this.Controls.Add(this.MediaProgress);
            this.Controls.Add(this.ArtistName);
            this.Controls.Add(this.AlbumName);
            this.Controls.Add(this.TrackName);
            this.Controls.Add(this.HintText);
            this.Controls.Add(this.ProgramTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "WMP Discord RPC";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label ProgramTitle;
        private System.Windows.Forms.Label HintText;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label TrackName;
        private System.Windows.Forms.Label AlbumName;
        private System.Windows.Forms.Label ArtistName;
        private System.Windows.Forms.ProgressBar MediaProgress;
        private System.Windows.Forms.Label CurrentTime;
        private System.Windows.Forms.Label MaxTime;
    }
}