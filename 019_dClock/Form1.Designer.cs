namespace _019_dClock
{
  partial class Form1
  {
    /// <summary>
    /// 필수 디자이너 변수입니다.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// 사용 중인 모든 리소스를 정리합니다.
    /// </summary>
    /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form 디자이너에서 생성한 코드

    /// <summary>
    /// 디자이너 지원에 필요한 메서드입니다. 
    /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.lblDate = new System.Windows.Forms.Label();
      this.lblTime = new System.Windows.Forms.Label();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.표시형식ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.아날로그ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.디지털ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.끝내기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // lblDate
      // 
      this.lblDate.AutoSize = true;
      this.lblDate.Location = new System.Drawing.Point(128, 120);
      this.lblDate.Name = "lblDate";
      this.lblDate.Size = new System.Drawing.Size(0, 12);
      this.lblDate.TabIndex = 0;
      // 
      // lblTime
      // 
      this.lblTime.AutoSize = true;
      this.lblTime.Location = new System.Drawing.Point(130, 216);
      this.lblTime.Name = "lblTime";
      this.lblTime.Size = new System.Drawing.Size(0, 12);
      this.lblTime.TabIndex = 1;
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.표시형식ToolStripMenuItem,
            this.끝내기ToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(632, 24);
      this.menuStrip1.TabIndex = 2;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // 표시형식ToolStripMenuItem
      // 
      this.표시형식ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.아날로그ToolStripMenuItem,
            this.디지털ToolStripMenuItem});
      this.표시형식ToolStripMenuItem.Name = "표시형식ToolStripMenuItem";
      this.표시형식ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
      this.표시형식ToolStripMenuItem.Text = "표시형식";
      // 
      // 아날로그ToolStripMenuItem
      // 
      this.아날로그ToolStripMenuItem.Name = "아날로그ToolStripMenuItem";
      this.아날로그ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.아날로그ToolStripMenuItem.Text = "아날로그";
      // 
      // 디지털ToolStripMenuItem
      // 
      this.디지털ToolStripMenuItem.Name = "디지털ToolStripMenuItem";
      this.디지털ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.디지털ToolStripMenuItem.Text = "디지털";
      // 
      // 끝내기ToolStripMenuItem
      // 
      this.끝내기ToolStripMenuItem.Name = "끝내기ToolStripMenuItem";
      this.끝내기ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
      this.끝내기ToolStripMenuItem.Text = "끝내기";
      this.끝내기ToolStripMenuItem.Click += new System.EventHandler(this.끝내기ToolStripMenuItem_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(632, 368);
      this.Controls.Add(this.lblTime);
      this.Controls.Add(this.lblDate);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblDate;
    private System.Windows.Forms.Label lblTime;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem 표시형식ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 아날로그ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 디지털ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 끝내기ToolStripMenuItem;
  }
}

