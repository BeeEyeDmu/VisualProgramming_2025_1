﻿namespace _006_Login
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
      this.label1 = new System.Windows.Forms.Label();
      this.txtId = new System.Windows.Forms.TextBox();
      this.txtPassword = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.btnLogin = new System.Windows.Forms.Button();
      this.txtResult = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.label1.Location = new System.Drawing.Point(49, 60);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(47, 17);
      this.label1.TabIndex = 0;
      this.label1.Text = "아이디";
      // 
      // txtId
      // 
      this.txtId.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.txtId.Location = new System.Drawing.Point(123, 57);
      this.txtId.Name = "txtId";
      this.txtId.Size = new System.Drawing.Size(141, 25);
      this.txtId.TabIndex = 1;
      // 
      // txtPassword
      // 
      this.txtPassword.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.txtPassword.Location = new System.Drawing.Point(123, 107);
      this.txtPassword.Name = "txtPassword";
      this.txtPassword.PasswordChar = '●';
      this.txtPassword.Size = new System.Drawing.Size(141, 25);
      this.txtPassword.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.label2.Location = new System.Drawing.Point(49, 110);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(60, 17);
      this.label2.TabIndex = 2;
      this.label2.Text = "패스워드";
      // 
      // btnLogin
      // 
      this.btnLogin.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btnLogin.Location = new System.Drawing.Point(123, 154);
      this.btnLogin.Name = "btnLogin";
      this.btnLogin.Size = new System.Drawing.Size(141, 30);
      this.btnLogin.TabIndex = 4;
      this.btnLogin.Text = "로그인";
      this.btnLogin.UseVisualStyleBackColor = true;
      this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
      // 
      // txtResult
      // 
      this.txtResult.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.txtResult.Location = new System.Drawing.Point(123, 224);
      this.txtResult.Name = "txtResult";
      this.txtResult.ReadOnly = true;
      this.txtResult.Size = new System.Drawing.Size(141, 25);
      this.txtResult.TabIndex = 5;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(337, 326);
      this.Controls.Add(this.txtResult);
      this.Controls.Add(this.btnLogin);
      this.Controls.Add(this.txtPassword);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtId);
      this.Controls.Add(this.label1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtId;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnLogin;
    private System.Windows.Forms.TextBox txtResult;
  }
}

