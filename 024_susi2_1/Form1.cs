using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _026_susi2_1
{
  public partial class Form1 : Form
  {
    Random r = new Random();
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      chart1.Series[0].ChartType = SeriesChartType.Spline;
      chart1.Series[0].BorderWidth = 3;
      for (int i=0; i<10; i++)
        chart1.Series[0].Points.Add(r.Next(101));
    }

    private void button1_Click(object sender, EventArgs e)
    {
      chart1.Series[0].Points.Clear();
      for (int i = 0; i < 10; i++)
        chart1.Series[0].Points.Add(r.Next(101));
    }
  }
}
