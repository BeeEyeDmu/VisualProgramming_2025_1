using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _014_ScoreCalc
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      double sum = double.Parse(txtKor.Text) 
        + double.Parse(txtMat.Text)
        + double.Parse(txtEng.Text);

      double avg = sum / 3;

      txtSum.Text = sum.ToString("0.0");
      txtAvg.Text = avg.ToString("0.0");
    }
  }
}
