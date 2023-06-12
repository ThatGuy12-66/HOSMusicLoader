namespace HOSMusicLoader
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
            this.author = new System.Windows.Forms.Label();
            this.French = new System.Windows.Forms.Button();
            this.English = new System.Windows.Forms.Button();
            this.URLList = new System.Windows.Forms.ListBox();
            this.urldownload = new System.Windows.Forms.Label();
            this.urlbox = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.DownloadButton = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.German = new System.Windows.Forms.Button();
            this.Russian = new System.Windows.Forms.Button();
            this.clearList = new System.Windows.Forms.Button();
            this.Play = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // author
            // 
            this.author.AutoSize = true;
            this.author.Location = new System.Drawing.Point(446, 9);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(176, 15);
            this.author.TabIndex = 0;
            this.author.Text = "Author: TronrenGuy / Suziki5000";
            // 
            // French
            // 
            this.French.Location = new System.Drawing.Point(547, 27);
            this.French.Name = "French";
            this.French.Size = new System.Drawing.Size(75, 23);
            this.French.TabIndex = 1;
            this.French.Text = "Français";
            this.French.UseVisualStyleBackColor = true;
            this.French.Click += new System.EventHandler(this.French_Click);
            // 
            // English
            // 
            this.English.Location = new System.Drawing.Point(446, 27);
            this.English.Name = "English";
            this.English.Size = new System.Drawing.Size(75, 23);
            this.English.TabIndex = 2;
            this.English.Text = "English";
            this.English.UseVisualStyleBackColor = true;
            this.English.Click += new System.EventHandler(this.English_Click);
            // 
            // URLList
            // 
            this.URLList.FormattingEnabled = true;
            this.URLList.ItemHeight = 15;
            this.URLList.Location = new System.Drawing.Point(12, 39);
            this.URLList.Name = "URLList";
            this.URLList.Size = new System.Drawing.Size(337, 469);
            this.URLList.TabIndex = 3;
            // 
            // urldownload
            // 
            this.urldownload.AutoSize = true;
            this.urldownload.Location = new System.Drawing.Point(12, 525);
            this.urldownload.Name = "urldownload";
            this.urldownload.Size = new System.Drawing.Size(81, 15);
            this.urldownload.TabIndex = 4;
            this.urldownload.Text = "Youtube URL: ";
            // 
            // urlbox
            // 
            this.urlbox.Location = new System.Drawing.Point(99, 522);
            this.urlbox.Name = "urlbox";
            this.urlbox.Size = new System.Drawing.Size(442, 23);
            this.urlbox.TabIndex = 5;
            this.urlbox.Text = "https://www.youtube.com/watch?v=";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(93, 10);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(250, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // DownloadButton
            // 
            this.DownloadButton.Location = new System.Drawing.Point(12, 9);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(75, 23);
            this.DownloadButton.TabIndex = 7;
            this.DownloadButton.Text = "Download";
            this.DownloadButton.UseVisualStyleBackColor = true;
            this.DownloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(547, 521);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 8;
            this.Add.Text = "Add To List";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // German
            // 
            this.German.Location = new System.Drawing.Point(446, 56);
            this.German.Name = "German";
            this.German.Size = new System.Drawing.Size(75, 23);
            this.German.TabIndex = 9;
            this.German.Text = "Deutsch";
            this.German.UseVisualStyleBackColor = true;
            this.German.Click += new System.EventHandler(this.German_Click);
            // 
            // Russian
            // 
            this.Russian.Location = new System.Drawing.Point(547, 56);
            this.Russian.Name = "Russian";
            this.Russian.Size = new System.Drawing.Size(75, 23);
            this.Russian.TabIndex = 10;
            this.Russian.Text = "Русский";
            this.Russian.UseVisualStyleBackColor = true;
            this.Russian.Click += new System.EventHandler(this.Russian_Click);
            // 
            // clearList
            // 
            this.clearList.Location = new System.Drawing.Point(547, 492);
            this.clearList.Name = "clearList";
            this.clearList.Size = new System.Drawing.Size(75, 23);
            this.clearList.TabIndex = 11;
            this.clearList.Text = "Clear List";
            this.clearList.UseVisualStyleBackColor = true;
            this.clearList.Click += new System.EventHandler(this.clearList_Click);
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(547, 463);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(75, 23);
            this.Play.TabIndex = 12;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 561);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.clearList);
            this.Controls.Add(this.Russian);
            this.Controls.Add(this.German);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.DownloadButton);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.urlbox);
            this.Controls.Add(this.urldownload);
            this.Controls.Add(this.URLList);
            this.Controls.Add(this.English);
            this.Controls.Add(this.French);
            this.Controls.Add(this.author);
            this.Name = "Form1";
            this.Text = "Tronren\'s Hex Of Steel Music Loader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label author;
        private Button French;
        private Button English;
        private ListBox URLList;
        private Label urldownload;
        private TextBox urlbox;
        private ProgressBar progressBar1;
        private Button DownloadButton;
        private Button Add;
        private Button German;
        private Button Russian;
        private Button clearList;
        private Button Play;
    }
}