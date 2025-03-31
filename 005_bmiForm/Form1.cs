using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _005_bmiForm
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void btnBMI_Click(object sender, EventArgs e)
    {
      double h = double.Parse(txtH.Text);
      double w = double.Parse(txtW.Text);
      h /= 100;
      double bmi = w / (h * h);
      lblBMI.Text = string.Format("당신의 BMI = {0:F1}", bmi);
      //lblBMI.Text = "당신의 BMI = " + bmi.ToString();

      // 비만도 판정
      if(bmi < 20)
      {
        lblResult.Text = "저체중입니다.";
        pictureBox1.BackColor = Color.Blue;
      }
      else if(/*20 <= bmi && */bmi < 25)  // 블록잡고 ^KC(Comment)
      {
        lblResult.Text = "정상체중입니다.";
        pictureBox1.BackColor = Color.Green;
      }
      else if(bmi < 30)
      {
        lblResult.Text = "경도비만입니다.";
        pictureBox1.BackColor = Color.YellowGreen;
      }
      else if(bmi < 40)
      {
        lblResult.Text = "비만입니다.";
        pictureBox1.BackColor = Color.OrangeRed;
      }
      else
      {
        lblResult.Text = "고도비만입니다.";
        pictureBox1.BackColor = Color.Red;
      }
    }
  }
}
