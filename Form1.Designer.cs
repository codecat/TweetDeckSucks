namespace TweetdeckSucks
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.webBrowser1 = new System.Windows.Forms.WebBrowser();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.button1 = new System.Windows.Forms.Button();
      this.textPinCode = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // webBrowser1
      // 
      this.webBrowser1.Location = new System.Drawing.Point(12, 12);
      this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
      this.webBrowser1.Name = "webBrowser1";
      this.webBrowser1.Size = new System.Drawing.Size(906, 449);
      this.webBrowser1.TabIndex = 0;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.button1);
      this.groupBox1.Controls.Add(this.textPinCode);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Location = new System.Drawing.Point(12, 467);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(906, 204);
      this.groupBox1.TabIndex = 1;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Authorize";
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(427, 112);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 2;
      this.button1.Text = "Authorize";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // textPinCode
      // 
      this.textPinCode.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textPinCode.Location = new System.Drawing.Point(346, 56);
      this.textPinCode.Name = "textPinCode";
      this.textPinCode.Size = new System.Drawing.Size(236, 50);
      this.textPinCode.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(322, 29);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(288, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Please authorize above and enter the given pincode below:";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(930, 683);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.webBrowser1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Authorize TweetDeckSucks";
      this.Activated += new System.EventHandler(this.Form1_Activated);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.WebBrowser webBrowser1;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox textPinCode;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button button1;
  }
}

