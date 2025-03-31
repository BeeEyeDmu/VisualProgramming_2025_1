namespace _014_ScoreCalc
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
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.label1 = new System.Windows.Forms.Label();
      this.txtKor = new System.Windows.Forms.TextBox();
      this.txtMat = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtEng = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txtSum = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.txtAvg = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.txtEng);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.txtMat);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.txtKor);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.groupBox1.Location = new System.Drawing.Point(13, 13);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(200, 159);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "성적입력";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.txtAvg);
      this.groupBox2.Controls.Add(this.label5);
      this.groupBox2.Controls.Add(this.txtSum);
      this.groupBox2.Controls.Add(this.label4);
      this.groupBox2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.groupBox2.Location = new System.Drawing.Point(230, 13);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(200, 114);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "결과";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.label1.Location = new System.Drawing.Point(17, 41);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(34, 17);
      this.label1.TabIndex = 0;
      this.label1.Text = "국어";
      // 
      // txtKor
      // 
      this.txtKor.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.txtKor.Location = new System.Drawing.Point(79, 38);
      this.txtKor.Name = "txtKor";
      this.txtKor.Size = new System.Drawing.Size(100, 25);
      this.txtKor.TabIndex = 1;
      this.txtKor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // txtMat
      // 
      this.txtMat.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.txtMat.Location = new System.Drawing.Point(79, 79);
      this.txtMat.Name = "txtMat";
      this.txtMat.Size = new System.Drawing.Size(100, 25);
      this.txtMat.TabIndex = 3;
      this.txtMat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.label2.Location = new System.Drawing.Point(17, 82);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(34, 17);
      this.label2.TabIndex = 2;
      this.label2.Text = "수학";
      // 
      // txtEng
      // 
      this.txtEng.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.txtEng.Location = new System.Drawing.Point(79, 120);
      this.txtEng.Name = "txtEng";
      this.txtEng.Size = new System.Drawing.Size(100, 25);
      this.txtEng.TabIndex = 5;
      this.txtEng.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.label3.Location = new System.Drawing.Point(17, 123);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(34, 17);
      this.label3.TabIndex = 4;
      this.label3.Text = "영어";
      // 
      // txtSum
      // 
      this.txtSum.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.txtSum.Location = new System.Drawing.Point(78, 32);
      this.txtSum.Name = "txtSum";
      this.txtSum.ReadOnly = true;
      this.txtSum.Size = new System.Drawing.Size(100, 25);
      this.txtSum.TabIndex = 7;
      this.txtSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.label4.Location = new System.Drawing.Point(16, 35);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(34, 17);
      this.label4.TabIndex = 6;
      this.label4.Text = "총점";
      // 
      // txtAvg
      // 
      this.txtAvg.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.txtAvg.Location = new System.Drawing.Point(78, 79);
      this.txtAvg.Name = "txtAvg";
      this.txtAvg.ReadOnly = true;
      this.txtAvg.Size = new System.Drawing.Size(100, 25);
      this.txtAvg.TabIndex = 9;
      this.txtAvg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.label5.Location = new System.Drawing.Point(16, 82);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(34, 17);
      this.label5.TabIndex = 8;
      this.label5.Text = "평균";
      // 
      // button1
      // 
      this.button1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.button1.Location = new System.Drawing.Point(308, 149);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(100, 23);
      this.button1.TabIndex = 2;
      this.button1.Text = "계산";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(460, 235);
      this.Controls.Add(this.button1);
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
    private System.Windows.Forms.TextBox txtEng;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtMat;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtKor;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.TextBox txtAvg;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtSum;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button button1;
  }
}

