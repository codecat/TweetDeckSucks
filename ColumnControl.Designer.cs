namespace TweetdeckSucks
{
  partial class ColumnControl
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
      this.labelColumnName = new System.Windows.Forms.Label();
      this.flowColumn = new System.Windows.Forms.FlowLayoutPanel();
      this.SuspendLayout();
      // 
      // labelColumnName
      // 
      this.labelColumnName.AutoSize = true;
      this.labelColumnName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelColumnName.ForeColor = System.Drawing.Color.White;
      this.labelColumnName.Location = new System.Drawing.Point(3, 0);
      this.labelColumnName.Name = "labelColumnName";
      this.labelColumnName.Size = new System.Drawing.Size(156, 23);
      this.labelColumnName.TabIndex = 13;
      this.labelColumnName.Text = "labelColumnName";
      // 
      // flowColumn
      // 
      this.flowColumn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.flowColumn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
      this.flowColumn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.flowColumn.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
      this.flowColumn.Location = new System.Drawing.Point(0, 26);
      this.flowColumn.Name = "flowColumn";
      this.flowColumn.Padding = new System.Windows.Forms.Padding(0, 0, 18, 0);
      this.flowColumn.Size = new System.Drawing.Size(363, 435);
      this.flowColumn.TabIndex = 12;
      this.flowColumn.WrapContents = false;
      // 
      // ColumnControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
      this.Controls.Add(this.labelColumnName);
      this.Controls.Add(this.flowColumn);
      this.Name = "ColumnControl";
      this.Size = new System.Drawing.Size(363, 461);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label labelColumnName;
    public System.Windows.Forms.FlowLayoutPanel flowColumn;
  }
}
