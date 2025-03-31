namespace _005_bmiForm
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
      this.lblBMI = new System.Windows.Forms.Label();
      this.btnBMI = new System.Windows.Forms.Button();
      this.txtW = new System.Windows.Forms.TextBox();
      this.lblW = new System.Windows.Forms.Label();
      this.txtH = new System.Windows.Forms.TextBox();
      this.lblH = new System.Windows.Forms.Label();
      this.lblResult = new System.Windows.Forms.Label();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // lblBMI
      // 
      this.lblBMI.AutoSize = true;
      this.lblBMI.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.lblBMI.Location = new System.Drawing.Point(67, 264);
      this.lblBMI.Name = "lblBMI";
      this.lblBMI.Size = new System.Drawing.Size(0, 25);
      this.lblBMI.TabIndex = 12;
      // 
      // btnBMI
      // 
      this.btnBMI.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btnBMI.Location = new System.Drawing.Point(142, 178);
      this.btnBMI.Name = "btnBMI";
      this.btnBMI.Size = new System.Drawing.Size(139, 39);
      this.btnBMI.TabIndex = 11;
      this.btnBMI.Text = "BMI 계산";
      this.btnBMI.UseVisualStyleBackColor = true;
      this.btnBMI.Click += new System.EventHandler(this.btnBMI_Click);
      // 
      // txtW
      // 
      this.txtW.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.txtW.Location = new System.Drawing.Point(142, 121);
      this.txtW.Name = "txtW";
      this.txtW.Size = new System.Drawing.Size(139, 33);
      this.txtW.TabIndex = 10;
      this.txtW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // lblW
      // 
      this.lblW.AutoSize = true;
      this.lblW.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.lblW.Location = new System.Drawing.Point(53, 124);
      this.lblW.Name = "lblW";
      this.lblW.Size = new System.Drawing.Size(83, 25);
      this.lblW.TabIndex = 9;
      this.lblW.Text = "체중(kg)";
      // 
      // txtH
      // 
      this.txtH.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.txtH.Location = new System.Drawing.Point(142, 73);
      this.txtH.Name = "txtH";
      this.txtH.Size = new System.Drawing.Size(139, 33);
      this.txtH.TabIndex = 8;
      this.txtH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // lblH
      // 
      this.lblH.AutoSize = true;
      this.lblH.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.lblH.Location = new System.Drawing.Point(53, 76);
      this.lblH.Name = "lblH";
      this.lblH.Size = new System.Drawing.Size(69, 25);
      this.lblH.TabIndex = 7;
      this.lblH.Text = "키(cm)";
      // 
      // lblResult
      // 
      this.lblResult.AutoSize = true;
      this.lblResult.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.lblResult.Location = new System.Drawing.Point(63, 330);
      this.lblResult.Name = "lblResult";
      this.lblResult.Size = new System.Drawing.Size(0, 25);
      this.lblResult.TabIndex = 13;
      // 
      // pictureBox1
      // 
      this.pictureBox1.Location = new System.Drawing.Point(289, 264);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(72, 91);
      this.pictureBox1.TabIndex = 14;
      this.pictureBox1.TabStop = false;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.ClientSize = new System.Drawing.Size(406, 450);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.lblResult);
      this.Controls.Add(this.lblBMI);
      this.Controls.Add(this.btnBMI);
      this.Controls.Add(this.txtW);
      this.Controls.Add(this.lblW);
      this.Controls.Add(this.txtH);
      this.Controls.Add(this.lblH);
      this.Name = "Form1";
      this.Text = "BMI계산기 v.0.2 by 강병익";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

    #endregion

    private System.Windows.Forms.Label lblBMI;
    private System.Windows.Forms.Button btnBMI;
    private System.Windows.Forms.TextBox txtW;
    private System.Windows.Forms.Label lblW;
    private System.Windows.Forms.TextBox txtH;
    private System.Windows.Forms.Label lblH;
    private System.Windows.Forms.Label lblResult;
    private System.Windows.Forms.PictureBox pictureBox1;
  }
}

