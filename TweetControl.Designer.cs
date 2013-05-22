namespace TweetdeckSucks
{
  partial class TweetControl
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TweetControl));
      this.picAvatar = new System.Windows.Forms.PictureBox();
      this.labelFollowers = new System.Windows.Forms.Label();
      this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
      this.labelName = new System.Windows.Forms.Label();
      this.labelDate = new System.Windows.Forms.Label();
      this.contextDate = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.openURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.copyLinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.labelVia = new System.Windows.Forms.Label();
      this.contextVia = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
      this.labelInReplyTo = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.buttonReply = new System.Windows.Forms.Button();
      this.buttonRetweet = new System.Windows.Forms.Button();
      this.buttonDM = new System.Windows.Forms.Button();
      this.buttonOptions = new System.Windows.Forms.Button();
      this.rtText = new TweetdeckSucks.RichTextBoxEx();
      ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
      this.flowLayoutPanel1.SuspendLayout();
      this.contextDate.SuspendLayout();
      this.contextVia.SuspendLayout();
      this.SuspendLayout();
      // 
      // picAvatar
      // 
      this.picAvatar.Location = new System.Drawing.Point(1, 0);
      this.picAvatar.Name = "picAvatar";
      this.picAvatar.Size = new System.Drawing.Size(48, 48);
      this.picAvatar.TabIndex = 0;
      this.picAvatar.TabStop = false;
      this.picAvatar.WaitOnLoad = true;
      // 
      // labelFollowers
      // 
      this.labelFollowers.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelFollowers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
      this.labelFollowers.Location = new System.Drawing.Point(0, 51);
      this.labelFollowers.Name = "labelFollowers";
      this.labelFollowers.Size = new System.Drawing.Size(48, 16);
      this.labelFollowers.TabIndex = 1;
      this.labelFollowers.Text = "labelFollowers";
      this.labelFollowers.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // flowLayoutPanel1
      // 
      this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.flowLayoutPanel1.Controls.Add(this.labelName);
      this.flowLayoutPanel1.Controls.Add(this.labelDate);
      this.flowLayoutPanel1.Controls.Add(this.labelVia);
      this.flowLayoutPanel1.Controls.Add(this.labelInReplyTo);
      this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 75);
      this.flowLayoutPanel1.Name = "flowLayoutPanel1";
      this.flowLayoutPanel1.Size = new System.Drawing.Size(300, 19);
      this.flowLayoutPanel1.TabIndex = 2;
      this.flowLayoutPanel1.WrapContents = false;
      // 
      // labelName
      // 
      this.labelName.AutoSize = true;
      this.labelName.Cursor = System.Windows.Forms.Cursors.Hand;
      this.labelName.Font = new System.Drawing.Font("Arial", 8.25F);
      this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
      this.labelName.Location = new System.Drawing.Point(0, 0);
      this.labelName.Margin = new System.Windows.Forms.Padding(0);
      this.labelName.Name = "labelName";
      this.labelName.Size = new System.Drawing.Size(56, 14);
      this.labelName.TabIndex = 2;
      this.labelName.Text = "labelName";
      this.labelName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      this.labelName.Click += new System.EventHandler(this.labelName_Click);
      // 
      // labelDate
      // 
      this.labelDate.AutoSize = true;
      this.labelDate.ContextMenuStrip = this.contextDate;
      this.labelDate.Cursor = System.Windows.Forms.Cursors.Hand;
      this.labelDate.Font = new System.Drawing.Font("Arial", 8.25F);
      this.labelDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
      this.labelDate.Location = new System.Drawing.Point(56, 0);
      this.labelDate.Margin = new System.Windows.Forms.Padding(0);
      this.labelDate.Name = "labelDate";
      this.labelDate.Size = new System.Drawing.Size(51, 14);
      this.labelDate.TabIndex = 3;
      this.labelDate.Text = "labelDate";
      this.labelDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      this.labelDate.Click += new System.EventHandler(this.labelDate_Click);
      // 
      // contextDate
      // 
      this.contextDate.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openURLToolStripMenuItem,
            this.copyLinkToolStripMenuItem});
      this.contextDate.Name = "contextDate";
      this.contextDate.Size = new System.Drawing.Size(129, 48);
      // 
      // openURLToolStripMenuItem
      // 
      this.openURLToolStripMenuItem.Name = "openURLToolStripMenuItem";
      this.openURLToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
      this.openURLToolStripMenuItem.Text = "Open Link";
      this.openURLToolStripMenuItem.Click += new System.EventHandler(this.openURLToolStripMenuItem_Click);
      // 
      // copyLinkToolStripMenuItem
      // 
      this.copyLinkToolStripMenuItem.Name = "copyLinkToolStripMenuItem";
      this.copyLinkToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
      this.copyLinkToolStripMenuItem.Text = "Copy Link";
      this.copyLinkToolStripMenuItem.Click += new System.EventHandler(this.copyLinkToolStripMenuItem_Click);
      // 
      // labelVia
      // 
      this.labelVia.AutoSize = true;
      this.labelVia.ContextMenuStrip = this.contextVia;
      this.labelVia.Cursor = System.Windows.Forms.Cursors.Hand;
      this.labelVia.Font = new System.Drawing.Font("Arial", 8.25F);
      this.labelVia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
      this.labelVia.Location = new System.Drawing.Point(107, 0);
      this.labelVia.Margin = new System.Windows.Forms.Padding(0);
      this.labelVia.Name = "labelVia";
      this.labelVia.Size = new System.Drawing.Size(45, 14);
      this.labelVia.TabIndex = 4;
      this.labelVia.Text = "labelVia";
      this.labelVia.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      this.labelVia.Click += new System.EventHandler(this.labelVia_Click);
      // 
      // contextVia
      // 
      this.contextVia.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
      this.contextVia.Name = "contextDate";
      this.contextVia.Size = new System.Drawing.Size(129, 48);
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
      this.toolStripMenuItem1.Text = "Open Link";
      this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
      // 
      // toolStripMenuItem2
      // 
      this.toolStripMenuItem2.Name = "toolStripMenuItem2";
      this.toolStripMenuItem2.Size = new System.Drawing.Size(128, 22);
      this.toolStripMenuItem2.Text = "Copy Link";
      this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
      // 
      // labelInReplyTo
      // 
      this.labelInReplyTo.AutoSize = true;
      this.labelInReplyTo.Cursor = System.Windows.Forms.Cursors.Hand;
      this.labelInReplyTo.Font = new System.Drawing.Font("Arial", 8.25F);
      this.labelInReplyTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
      this.labelInReplyTo.Location = new System.Drawing.Point(152, 0);
      this.labelInReplyTo.Margin = new System.Windows.Forms.Padding(0);
      this.labelInReplyTo.Name = "labelInReplyTo";
      this.labelInReplyTo.Size = new System.Drawing.Size(75, 14);
      this.labelInReplyTo.TabIndex = 5;
      this.labelInReplyTo.Text = "labelInReplyTo";
      this.labelInReplyTo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      this.labelInReplyTo.Click += new System.EventHandler(this.labelInReplyTo_Click);
      // 
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
      this.label1.Location = new System.Drawing.Point(0, 92);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(300, 2);
      this.label1.TabIndex = 4;
      // 
      // buttonReply
      // 
      this.buttonReply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
      this.buttonReply.ForeColor = System.Drawing.Color.White;
      this.buttonReply.Image = ((System.Drawing.Image)(resources.GetObject("buttonReply.Image")));
      this.buttonReply.Location = new System.Drawing.Point(2, 2);
      this.buttonReply.Name = "buttonReply";
      this.buttonReply.Size = new System.Drawing.Size(22, 20);
      this.buttonReply.TabIndex = 7;
      this.buttonReply.UseVisualStyleBackColor = true;
      this.buttonReply.Visible = false;
      this.buttonReply.Click += new System.EventHandler(this.buttonReply_Click);
      // 
      // buttonRetweet
      // 
      this.buttonRetweet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
      this.buttonRetweet.ForeColor = System.Drawing.Color.White;
      this.buttonRetweet.Image = ((System.Drawing.Image)(resources.GetObject("buttonRetweet.Image")));
      this.buttonRetweet.Location = new System.Drawing.Point(2, 25);
      this.buttonRetweet.Name = "buttonRetweet";
      this.buttonRetweet.Size = new System.Drawing.Size(22, 20);
      this.buttonRetweet.TabIndex = 8;
      this.buttonRetweet.UseVisualStyleBackColor = true;
      this.buttonRetweet.Visible = false;
      this.buttonRetweet.Click += new System.EventHandler(this.buttonRetweet_Click);
      // 
      // buttonDM
      // 
      this.buttonDM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
      this.buttonDM.ForeColor = System.Drawing.Color.White;
      this.buttonDM.Image = ((System.Drawing.Image)(resources.GetObject("buttonDM.Image")));
      this.buttonDM.Location = new System.Drawing.Point(26, 2);
      this.buttonDM.Name = "buttonDM";
      this.buttonDM.Size = new System.Drawing.Size(22, 20);
      this.buttonDM.TabIndex = 9;
      this.buttonDM.UseVisualStyleBackColor = true;
      this.buttonDM.Visible = false;
      this.buttonDM.Click += new System.EventHandler(this.buttonDM_Click);
      // 
      // buttonOptions
      // 
      this.buttonOptions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
      this.buttonOptions.ForeColor = System.Drawing.Color.White;
      this.buttonOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonOptions.Image")));
      this.buttonOptions.Location = new System.Drawing.Point(26, 25);
      this.buttonOptions.Name = "buttonOptions";
      this.buttonOptions.Size = new System.Drawing.Size(22, 20);
      this.buttonOptions.TabIndex = 10;
      this.buttonOptions.UseVisualStyleBackColor = true;
      this.buttonOptions.Visible = false;
      this.buttonOptions.Click += new System.EventHandler(this.buttonOptions_Click);
      // 
      // rtText
      // 
      this.rtText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.rtText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
      this.rtText.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.rtText.DetectUrls = true;
      this.rtText.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rtText.ForeColor = System.Drawing.Color.White;
      this.rtText.Location = new System.Drawing.Point(54, 0);
      this.rtText.Name = "rtText";
      this.rtText.ReadOnly = true;
      this.rtText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
      this.rtText.Size = new System.Drawing.Size(246, 72);
      this.rtText.TabIndex = 11;
      this.rtText.Text = "rtText";
      this.rtText.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.rtText_LinkClicked);
      // 
      // TweetControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
      this.Controls.Add(this.buttonOptions);
      this.Controls.Add(this.buttonDM);
      this.Controls.Add(this.buttonRetweet);
      this.Controls.Add(this.buttonReply);
      this.Controls.Add(this.rtText);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.flowLayoutPanel1);
      this.Controls.Add(this.labelFollowers);
      this.Controls.Add(this.picAvatar);
      this.Name = "TweetControl";
      this.Size = new System.Drawing.Size(300, 94);
      ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
      this.flowLayoutPanel1.ResumeLayout(false);
      this.flowLayoutPanel1.PerformLayout();
      this.contextDate.ResumeLayout(false);
      this.contextVia.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    public System.Windows.Forms.PictureBox picAvatar;
    public System.Windows.Forms.Label labelFollowers;
    public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    public System.Windows.Forms.Label labelName;
    public System.Windows.Forms.Label labelDate;
    public System.Windows.Forms.Label labelVia;
    public System.Windows.Forms.Label labelInReplyTo;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ContextMenuStrip contextDate;
    private System.Windows.Forms.ToolStripMenuItem openURLToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem copyLinkToolStripMenuItem;
    private System.Windows.Forms.ContextMenuStrip contextVia;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    private System.Windows.Forms.Button buttonReply;
    private System.Windows.Forms.Button buttonRetweet;
    private System.Windows.Forms.Button buttonDM;
    private System.Windows.Forms.Button buttonOptions;
    public RichTextBoxEx rtText;

  }
}
