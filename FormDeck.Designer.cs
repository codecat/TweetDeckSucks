namespace TweetdeckSucks
{
  partial class FormDeck
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
      if (disposing && (components != null)) {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDeck));
      this.textTweet = new System.Windows.Forms.TextBox();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.groupTweet = new System.Windows.Forms.GroupBox();
      this.labelCharactersLeft = new System.Windows.Forms.Label();
      this.checkMedia = new System.Windows.Forms.CheckBox();
      this.checkShortenURLs = new System.Windows.Forms.CheckBox();
      this.buttonUpdate = new System.Windows.Forms.Button();
      this.labelOverlayStupidGroupBox = new System.Windows.Forms.Label();
      this.buttonOptions = new System.Windows.Forms.Button();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.labelError = new System.Windows.Forms.Label();
      this.labelUserName = new System.Windows.Forms.Label();
      this.picUserAvatar = new System.Windows.Forms.PictureBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.groupMedia = new System.Windows.Forms.GroupBox();
      this.buttonMediaBrowse = new System.Windows.Forms.Button();
      this.picMediaPreview = new System.Windows.Forms.PictureBox();
      this.buttonLogout = new System.Windows.Forms.Button();
      this.flowColumns = new System.Windows.Forms.FlowLayoutPanel();
      this.timerError = new System.Windows.Forms.Timer(this.components);
      this.imageListMedia = new System.Windows.Forms.ImageList(this.components);
      this.buttonAddColumn = new System.Windows.Forms.Button();
      this.buttonQuickProfile = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.groupTweet.SuspendLayout();
      this.groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.picUserAvatar)).BeginInit();
      this.groupMedia.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.picMediaPreview)).BeginInit();
      this.SuspendLayout();
      // 
      // textTweet
      // 
      this.textTweet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.textTweet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
      this.textTweet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.textTweet.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textTweet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
      this.textTweet.Location = new System.Drawing.Point(6, 19);
      this.textTweet.Multiline = true;
      this.textTweet.Name = "textTweet";
      this.textTweet.Size = new System.Drawing.Size(1047, 57);
      this.textTweet.TabIndex = 0;
      this.textTweet.Text = "What\'s happening?";
      this.textTweet.TextChanged += new System.EventHandler(this.textTweet_TextChanged);
      this.textTweet.Enter += new System.EventHandler(this.textTweet_Enter);
      this.textTweet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textTweet_KeyDown);
      this.textTweet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTweet_KeyPress);
      this.textTweet.Leave += new System.EventHandler(this.textTweet_Leave);
      // 
      // pictureBox1
      // 
      this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(12, 12);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(24, 23);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      this.pictureBox1.TabIndex = 1;
      this.pictureBox1.TabStop = false;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.BackColor = System.Drawing.Color.Transparent;
      this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.White;
      this.label1.Location = new System.Drawing.Point(42, 10);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(162, 26);
      this.label1.TabIndex = 2;
      this.label1.Text = "TweetDeck Sucks";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.BackColor = System.Drawing.Color.Transparent;
      this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
      this.label2.Location = new System.Drawing.Point(198, 16);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(44, 19);
      this.label2.TabIndex = 3;
      this.label2.Text = "v0.01";
      // 
      // groupTweet
      // 
      this.groupTweet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.groupTweet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
      this.groupTweet.Controls.Add(this.labelCharactersLeft);
      this.groupTweet.Controls.Add(this.checkMedia);
      this.groupTweet.Controls.Add(this.checkShortenURLs);
      this.groupTweet.Controls.Add(this.buttonUpdate);
      this.groupTweet.Controls.Add(this.textTweet);
      this.groupTweet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.groupTweet.Location = new System.Drawing.Point(6, 48);
      this.groupTweet.Name = "groupTweet";
      this.groupTweet.Size = new System.Drawing.Size(1059, 112);
      this.groupTweet.TabIndex = 4;
      this.groupTweet.TabStop = false;
      // 
      // labelCharactersLeft
      // 
      this.labelCharactersLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.labelCharactersLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
      this.labelCharactersLeft.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelCharactersLeft.ForeColor = System.Drawing.Color.White;
      this.labelCharactersLeft.Location = new System.Drawing.Point(922, 79);
      this.labelCharactersLeft.Name = "labelCharactersLeft";
      this.labelCharactersLeft.Size = new System.Drawing.Size(69, 26);
      this.labelCharactersLeft.TabIndex = 6;
      this.labelCharactersLeft.Text = "140";
      this.labelCharactersLeft.TextAlign = System.Drawing.ContentAlignment.BottomRight;
      // 
      // checkMedia
      // 
      this.checkMedia.AutoSize = true;
      this.checkMedia.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
      this.checkMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.checkMedia.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.checkMedia.ForeColor = System.Drawing.Color.White;
      this.checkMedia.Location = new System.Drawing.Point(72, 89);
      this.checkMedia.Name = "checkMedia";
      this.checkMedia.Size = new System.Drawing.Size(53, 17);
      this.checkMedia.TabIndex = 2;
      this.checkMedia.Text = "Media";
      this.checkMedia.UseVisualStyleBackColor = true;
      this.checkMedia.CheckedChanged += new System.EventHandler(this.checkMedia_CheckedChanged);
      // 
      // checkShortenURLs
      // 
      this.checkShortenURLs.AutoSize = true;
      this.checkShortenURLs.Checked = true;
      this.checkShortenURLs.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkShortenURLs.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
      this.checkShortenURLs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.checkShortenURLs.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.checkShortenURLs.ForeColor = System.Drawing.Color.White;
      this.checkShortenURLs.Location = new System.Drawing.Point(6, 89);
      this.checkShortenURLs.Name = "checkShortenURLs";
      this.checkShortenURLs.Size = new System.Drawing.Size(60, 17);
      this.checkShortenURLs.TabIndex = 2;
      this.checkShortenURLs.Text = "Shorten";
      this.checkShortenURLs.UseVisualStyleBackColor = true;
      // 
      // buttonUpdate
      // 
      this.buttonUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
      this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonUpdate.ForeColor = System.Drawing.Color.White;
      this.buttonUpdate.Location = new System.Drawing.Point(997, 82);
      this.buttonUpdate.Name = "buttonUpdate";
      this.buttonUpdate.Size = new System.Drawing.Size(56, 23);
      this.buttonUpdate.TabIndex = 1;
      this.buttonUpdate.Text = "Send";
      this.buttonUpdate.UseVisualStyleBackColor = true;
      this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
      // 
      // labelOverlayStupidGroupBox
      // 
      this.labelOverlayStupidGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.labelOverlayStupidGroupBox.Location = new System.Drawing.Point(12, 37);
      this.labelOverlayStupidGroupBox.Name = "labelOverlayStupidGroupBox";
      this.labelOverlayStupidGroupBox.Size = new System.Drawing.Size(1308, 10);
      this.labelOverlayStupidGroupBox.TabIndex = 5;
      // 
      // buttonOptions
      // 
      this.buttonOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonOptions.AutoSize = true;
      this.buttonOptions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
      this.buttonOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonOptions.ForeColor = System.Drawing.Color.White;
      this.buttonOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonOptions.Image")));
      this.buttonOptions.Location = new System.Drawing.Point(1258, 12);
      this.buttonOptions.Name = "buttonOptions";
      this.buttonOptions.Size = new System.Drawing.Size(28, 24);
      this.buttonOptions.TabIndex = 6;
      this.buttonOptions.UseVisualStyleBackColor = true;
      // 
      // groupBox2
      // 
      this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
      this.groupBox2.Controls.Add(this.labelError);
      this.groupBox2.Controls.Add(this.labelUserName);
      this.groupBox2.Controls.Add(this.picUserAvatar);
      this.groupBox2.Controls.Add(this.label4);
      this.groupBox2.Controls.Add(this.label3);
      this.groupBox2.Controls.Add(this.groupMedia);
      this.groupBox2.Controls.Add(this.groupTweet);
      this.groupBox2.Location = new System.Drawing.Point(12, 41);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(1308, 167);
      this.groupBox2.TabIndex = 7;
      this.groupBox2.TabStop = false;
      // 
      // labelError
      // 
      this.labelError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.labelError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.labelError.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelError.ForeColor = System.Drawing.Color.White;
      this.labelError.Location = new System.Drawing.Point(199, 13);
      this.labelError.Name = "labelError";
      this.labelError.Size = new System.Drawing.Size(921, 32);
      this.labelError.TabIndex = 10;
      this.labelError.Text = "labelError";
      this.labelError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.labelError.Visible = false;
      // 
      // labelUserName
      // 
      this.labelUserName.AutoSize = true;
      this.labelUserName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelUserName.ForeColor = System.Drawing.Color.White;
      this.labelUserName.Location = new System.Drawing.Point(95, 21);
      this.labelUserName.Name = "labelUserName";
      this.labelUserName.Size = new System.Drawing.Size(98, 19);
      this.labelUserName.TabIndex = 9;
      this.labelUserName.Text = "Please log in.";
      // 
      // picUserAvatar
      // 
      this.picUserAvatar.Location = new System.Drawing.Point(57, 14);
      this.picUserAvatar.Name = "picUserAvatar";
      this.picUserAvatar.Size = new System.Drawing.Size(32, 32);
      this.picUserAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.picUserAvatar.TabIndex = 8;
      this.picUserAvatar.TabStop = false;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.ForeColor = System.Drawing.Color.White;
      this.label4.Location = new System.Drawing.Point(6, 20);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(45, 19);
      this.label4.TabIndex = 7;
      this.label4.Text = "From:";
      // 
      // label3
      // 
      this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.label3.Location = new System.Drawing.Point(6, 39);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(1296, 15);
      this.label3.TabIndex = 6;
      // 
      // groupMedia
      // 
      this.groupMedia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.groupMedia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
      this.groupMedia.Controls.Add(this.buttonMediaBrowse);
      this.groupMedia.Controls.Add(this.picMediaPreview);
      this.groupMedia.Location = new System.Drawing.Point(1071, 48);
      this.groupMedia.Name = "groupMedia";
      this.groupMedia.Size = new System.Drawing.Size(231, 112);
      this.groupMedia.TabIndex = 11;
      this.groupMedia.TabStop = false;
      this.groupMedia.Visible = false;
      // 
      // buttonMediaBrowse
      // 
      this.buttonMediaBrowse.Location = new System.Drawing.Point(151, 10);
      this.buttonMediaBrowse.Name = "buttonMediaBrowse";
      this.buttonMediaBrowse.Size = new System.Drawing.Size(75, 23);
      this.buttonMediaBrowse.TabIndex = 1;
      this.buttonMediaBrowse.Text = "Browse";
      this.buttonMediaBrowse.UseVisualStyleBackColor = true;
      this.buttonMediaBrowse.Click += new System.EventHandler(this.buttonMediaBrowse_Click);
      // 
      // picMediaPreview
      // 
      this.picMediaPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
      this.picMediaPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.picMediaPreview.Location = new System.Drawing.Point(5, 10);
      this.picMediaPreview.Name = "picMediaPreview";
      this.picMediaPreview.Size = new System.Drawing.Size(140, 97);
      this.picMediaPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.picMediaPreview.TabIndex = 0;
      this.picMediaPreview.TabStop = false;
      // 
      // buttonLogout
      // 
      this.buttonLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonLogout.AutoSize = true;
      this.buttonLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
      this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonLogout.ForeColor = System.Drawing.Color.White;
      this.buttonLogout.Image = ((System.Drawing.Image)(resources.GetObject("buttonLogout.Image")));
      this.buttonLogout.Location = new System.Drawing.Point(1292, 12);
      this.buttonLogout.Name = "buttonLogout";
      this.buttonLogout.Size = new System.Drawing.Size(28, 24);
      this.buttonLogout.TabIndex = 8;
      this.buttonLogout.UseVisualStyleBackColor = true;
      this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
      // 
      // flowColumns
      // 
      this.flowColumns.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.flowColumns.Location = new System.Drawing.Point(12, 214);
      this.flowColumns.Name = "flowColumns";
      this.flowColumns.Size = new System.Drawing.Size(1308, 562);
      this.flowColumns.TabIndex = 9;
      this.flowColumns.WrapContents = false;
      // 
      // timerError
      // 
      this.timerError.Interval = 5000;
      this.timerError.Tick += new System.EventHandler(this.timerError_Tick);
      // 
      // imageListMedia
      // 
      this.imageListMedia.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
      this.imageListMedia.ImageSize = new System.Drawing.Size(48, 48);
      this.imageListMedia.TransparentColor = System.Drawing.Color.Transparent;
      // 
      // buttonAddColumn
      // 
      this.buttonAddColumn.AutoSize = true;
      this.buttonAddColumn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
      this.buttonAddColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonAddColumn.ForeColor = System.Drawing.Color.White;
      this.buttonAddColumn.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddColumn.Image")));
      this.buttonAddColumn.Location = new System.Drawing.Point(248, 10);
      this.buttonAddColumn.Name = "buttonAddColumn";
      this.buttonAddColumn.Size = new System.Drawing.Size(28, 24);
      this.buttonAddColumn.TabIndex = 10;
      this.buttonAddColumn.UseVisualStyleBackColor = true;
      // 
      // buttonQuickProfile
      // 
      this.buttonQuickProfile.AutoSize = true;
      this.buttonQuickProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
      this.buttonQuickProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonQuickProfile.ForeColor = System.Drawing.Color.White;
      this.buttonQuickProfile.Image = ((System.Drawing.Image)(resources.GetObject("buttonQuickProfile.Image")));
      this.buttonQuickProfile.Location = new System.Drawing.Point(282, 10);
      this.buttonQuickProfile.Name = "buttonQuickProfile";
      this.buttonQuickProfile.Size = new System.Drawing.Size(28, 24);
      this.buttonQuickProfile.TabIndex = 11;
      this.buttonQuickProfile.UseVisualStyleBackColor = true;
      // 
      // FormDeck
      // 
      this.AllowDrop = true;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
      this.ClientSize = new System.Drawing.Size(1332, 788);
      this.Controls.Add(this.buttonQuickProfile);
      this.Controls.Add(this.buttonAddColumn);
      this.Controls.Add(this.flowColumns);
      this.Controls.Add(this.buttonLogout);
      this.Controls.Add(this.labelOverlayStupidGroupBox);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.buttonOptions);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.pictureBox1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FormDeck";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "TweetDeck Sucks";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDeck_FormClosed);
      this.Load += new System.EventHandler(this.FormDeck_Load);
      this.ResizeEnd += new System.EventHandler(this.FormDeck_ResizeEnd);
      this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FormDeck_DragDrop);
      this.DragOver += new System.Windows.Forms.DragEventHandler(this.FormDeck_DragOver);
      this.Resize += new System.EventHandler(this.FormDeck_Resize);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.groupTweet.ResumeLayout(false);
      this.groupTweet.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.picUserAvatar)).EndInit();
      this.groupMedia.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.picMediaPreview)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.GroupBox groupTweet;
    private System.Windows.Forms.Button buttonUpdate;
    private System.Windows.Forms.CheckBox checkShortenURLs;
    private System.Windows.Forms.Label labelOverlayStupidGroupBox;
    private System.Windows.Forms.Label labelCharactersLeft;
    private System.Windows.Forms.Button buttonOptions;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.PictureBox picUserAvatar;
    private System.Windows.Forms.Label labelUserName;
    private System.Windows.Forms.Button buttonLogout;
    public System.Windows.Forms.FlowLayoutPanel flowColumns;
    public System.Windows.Forms.TextBox textTweet;
    private System.Windows.Forms.Label labelError;
    private System.Windows.Forms.Timer timerError;
    private System.Windows.Forms.GroupBox groupMedia;
    private System.Windows.Forms.ImageList imageListMedia;
    private System.Windows.Forms.CheckBox checkMedia;
    private System.Windows.Forms.PictureBox picMediaPreview;
    private System.Windows.Forms.Button buttonMediaBrowse;
    private System.Windows.Forms.Button buttonAddColumn;
    private System.Windows.Forms.Button buttonQuickProfile;
  }
}