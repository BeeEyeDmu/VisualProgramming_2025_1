using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _015_gradeCalc
{
  public partial class Form1 : Form
  {
    TextBox[] titles;
    ComboBox[] crds;
    ComboBox[] grds;
    public Form1()
    {
      InitializeComponent();
    }


    private void Form1_Load(object sender, EventArgs e)
    {
      txt1.Text = "인체의 구조와 기능";
      txt2.Text = "일반수학I";
      txt3.Text = "디지털공학및실험";
      txt4.Text = "비주얼프로그래밍";
      txt5.Text = "설계및프로젝트기본I";
      txt6.Text = "데이터사이언스";
    }
  }
}
