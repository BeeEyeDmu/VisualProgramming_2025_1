﻿namespace _012_RadioButton
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
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.rbKorea = new System.Windows.Forms.RadioButton();
      this.rbChina = new System.Windows.Forms.RadioButton();
      this.rbJapan = new System.Windows.Forms.RadioButton();
      this.rbOthers = new System.Windows.Forms.RadioButton();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.rbMale = new System.Windows.Forms.RadioButton();
      this.rbFemale = new System.Windows.Forms.RadioButton();
      this.btnSubmit = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.rbOthers);
      this.groupBox1.Controls.Add(this.rbJapan);
      this.groupBox1.Controls.Add(this.rbChina);
      this.groupBox1.Controls.Add(this.rbKorea);
      this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.groupBox1.Location = new System.Drawing.Point(41, 48);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(200, 158);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "국적";
      // 
      // rbKorea
      // 
      this.rbKorea.AutoSize = true;
      this.rbKorea.Location = new System.Drawing.Point(17, 31);
      this.rbKorea.Name = "rbKorea";
      this.rbKorea.Size = new System.Drawing.Size(78, 21);
      this.rbKorea.TabIndex = 0;
      this.rbKorea.TabStop = true;
      this.rbKorea.Text = "대한민국";
      this.rbKorea.UseVisualStyleBackColor = true;
      // 
      // rbChina
      // 
      this.rbChina.AutoSize = true;
      this.rbChina.Location = new System.Drawing.Point(17, 57);
      this.rbChina.Name = "rbChina";
      this.rbChina.Size = new System.Drawing.Size(52, 21);
      this.rbChina.TabIndex = 1;
      this.rbChina.TabStop = true;
      this.rbChina.Text = "중국";
      this.rbChina.UseVisualStyleBackColor = true;
      // 
      // rbJapan
      // 
      this.rbJapan.AutoSize = true;
      this.rbJapan.Location = new System.Drawing.Point(17, 83);
      this.rbJapan.Name = "rbJapan";
      this.rbJapan.Size = new System.Drawing.Size(52, 21);
      this.rbJapan.TabIndex = 2;
      this.rbJapan.TabStop = true;
      this.rbJapan.Text = "일본";
      this.rbJapan.UseVisualStyleBackColor = true;
      // 
      // rbOthers
      // 
      this.rbOthers.AutoSize = true;
      this.rbOthers.Location = new System.Drawing.Point(17, 109);
      this.rbOthers.Name = "rbOthers";
      this.rbOthers.Size = new System.Drawing.Size(101, 21);
      this.rbOthers.TabIndex = 3;
      this.rbOthers.TabStop = true;
      this.rbOthers.Text = "그 외의 국가";
      this.rbOthers.UseVisualStyleBackColor = true;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.rbFemale);
      this.groupBox2.Controls.Add(this.rbMale);
      this.groupBox2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.groupBox2.Location = new System.Drawing.Point(268, 48);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(200, 87);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "성별";
      // 
      // rbMale
      // 
      this.rbMale.AutoSize = true;
      this.rbMale.Location = new System.Drawing.Point(36, 40);
      this.rbMale.Name = "rbMale";
      this.rbMale.Size = new System.Drawing.Size(39, 21);
      this.rbMale.TabIndex = 0;
      this.rbMale.TabStop = true;
      this.rbMale.Text = "남";
      this.rbMale.UseVisualStyleBackColor = true;
      // 
      // rbFemale
      // 
      this.rbFemale.AutoSize = true;
      this.rbFemale.Location = new System.Drawing.Point(119, 40);
      this.rbFemale.Name = "rbFemale";
      this.rbFemale.Size = new System.Drawing.Size(39, 21);
      this.rbFemale.TabIndex = 1;
      this.rbFemale.TabStop = true;
      this.rbFemale.Text = "여";
      this.rbFemale.UseVisualStyleBackColor = true;
      // 
      // btnSubmit
      // 
      this.btnSubmit.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btnSubmit.Location = new System.Drawing.Point(362, 171);
      this.btnSubmit.Name = "btnSubmit";
      this.btnSubmit.Size = new System.Drawing.Size(106, 35);
      this.btnSubmit.TabIndex = 2;
      this.btnSubmit.Text = "제출";
      this.btnSubmit.UseVisualStyleBackColor = true;
      this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(505, 268);
      this.Controls.Add(this.btnSubmit);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.RadioButton rbOthers;
    private System.Windows.Forms.RadioButton rbJapan;
    private System.Windows.Forms.RadioButton rbChina;
    private System.Windows.Forms.RadioButton rbKorea;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.RadioButton rbFemale;
    private System.Windows.Forms.RadioButton rbMale;
    private System.Windows.Forms.Button btnSubmit;
  }
}

