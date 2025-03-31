using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _013_TempConv
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (txtC.Text == "" && txtF.Text == "")
        return;
      if(txtC.Text != "")
      {
        double f = double.Parse(txtC.Text) * 9 / 5 + 32;
        txtF.Text = f.ToString("#.##");
      }
      else if(txtF.Text != "")
      {
        double c = (double.Parse(txtF.Text) - 32) * 5 / 9;
        txtC.Text = c.ToString("#.##");
      }
    }
  }
}
