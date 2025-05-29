using System;
using System.Windows;
using System.Windows.Controls;

namespace _040_WPFCalc
{
  /// <summary>
  /// MainWindow.xaml에 대한 상호 작용 논리
  /// </summary>
  public partial class MainWindow : Window
  {
    double saved; // 연산자 버튼이 눌렸을 때, txtResult에 있던 값을 저장하는 곳
    string op;    // 연산자 버튼이 눌렸을 때, 어떤 연산자인지 저장
    bool opFlag = false;  // 연산자 버튼이 눌렸을 때, 숫자가 새로 써지게 한다
    bool afterCalc = false; // = 버튼이 눌려서 계산이 끝난 후, 새로 숫자 쓰기
    double memory = 0;
    bool memFlag = false; // 메모리 버튼이 눌린 후, 새로 숫자

    public MainWindow()
    {
      InitializeComponent();
    }

    // 숫자 10개 버튼
    private void btn1_Click(object sender, RoutedEventArgs e)
    {
      Button btn = (Button)sender;

      if (txtResult.Text == "0"
        || opFlag == true
        || afterCalc == true
        || memFlag == true)
      {
        txtResult.Text = btn.Content.ToString();
        opFlag = false;
        afterCalc = false;
        memFlag = false;
      }
      else
        txtResult.Text += btn.Content.ToString();
    }

    // 소수점
    private void btnDot_Click(object sender, RoutedEventArgs e)
    {
      if (txtResult.Text.Contains("."))
        return;
      else
        txtResult.Text += ".";
    }

    // +- 버튼
    private void btnPlusMinus_Click(object sender, RoutedEventArgs e)
    {
      txtResult.Text = (-1 * double.Parse(txtResult.Text)).ToString();
    }

    // ＋－× ÷
    private void opClick(object sender, RoutedEventArgs e)
    {
      Button btn = (Button)sender;

      saved = double.Parse(txtResult.Text);
      op = btn.Content.ToString();
      opFlag = true;

      txtExp.Text = txtResult.Text + op;
      

      // MessageBox.Show(String.Format("{0}, {1}", saved, op));
    }

    // = 버튼 × 
    private void btnEqual_Click(object sender, RoutedEventArgs e)
    {
      double v = double.Parse(txtResult.Text);
      txtExp.Text += txtResult.Text + "=";

      switch(op)
      {
        case "＋":
          txtResult.Text = (saved + v).ToString();
          break;
        case "－":
          txtResult.Text = (saved - v).ToString();
          break;
        case "×":
          txtResult.Text = (saved * v).ToString();
          break;
        case "÷":
          txtResult.Text = (saved / v).ToString();
          break;
      }

      afterCalc = true;
    }

    // 1/x
    private void btnReci_Click(object sender, RoutedEventArgs e)
    {
      if(txtExp.Text == "")
        txtExp.Text = "1/(" + txtResult.Text + ")";
      else
        txtExp.Text = "1/(" + txtExp.Text + ")";

      double v = double.Parse(txtResult.Text);
      txtResult.Text = (1 / v).ToString();
    }

    private void btnSqr_Click(object sender, RoutedEventArgs e)
    {
      if (txtExp.Text == "")
        txtExp.Text = "sqr(" + txtResult.Text + ")";
      else
        txtExp.Text = "sqr(" + txtExp.Text + ")";

      double v = double.Parse(txtResult.Text);
      txtResult.Text = (v * v).ToString();
    }

    private void btnSqrt_Click(object sender, RoutedEventArgs e)
    {
      if (txtExp.Text == "")
        txtExp.Text = "√(" + txtResult.Text + ")";
      else
        txtExp.Text = "√(" + txtExp.Text + ")";

      double v = double.Parse(txtResult.Text);
      txtResult.Text = Math.Sqrt(v).ToString();
    }

    private void btnCE_Click(object sender, RoutedEventArgs e)
    {
      txtResult.Text = "0";
    }

    private void btnC_Click(object sender, RoutedEventArgs e)
    {
      txtExp.Text = "";
      txtResult.Text = "0";
      op = "";
      opFlag = false;
      saved = 0;
    }

    private void btnDel_Click(object sender, RoutedEventArgs e)
    {
      txtResult.Text 
        = txtResult.Text.Remove(txtResult.Text.Length - 1);

      if (txtResult.Text.Length == 0)
        txtResult.Text = "0";
    }

    // Memory Save
    private void btnMS_Click(object sender, RoutedEventArgs e)
    {
      double v = double.Parse(txtResult.Text);
      memory = v;
      btnMC.IsEnabled = true;
      btnMR.IsEnabled = true;
      memFlag = true; // 메모리 버튼이 눌린 후, 새로 숫자

    }

    private void btnMC_Click(object sender, RoutedEventArgs e)
    {
      btnMC.IsEnabled = false;
      btnMR.IsEnabled = false;
      memFlag = true;
      memory = 0;
    }

    private void btnMR_Click(object sender, RoutedEventArgs e)
    {
      txtResult.Text = memory.ToString();
      memFlag = true;
    }

    private void btnMPlus_Click(object sender, RoutedEventArgs e)
    {
      memory += double.Parse(txtResult.Text);
      memFlag = true;
    }

    private void btnMMinus_Click(object sender, RoutedEventArgs e)
    {
      memory -= double.Parse(txtResult.Text);
      memFlag = true;
    }
  }
}
