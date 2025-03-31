using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _011_CheckBox
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void btnSubmit_Click(object sender, EventArgs e)
    {
      string s = "좋아하는 과일은 : ";

      CheckBox[] cBox = { checkBox1, checkBox2, 
        checkBox3, checkBox4, checkBox5 };

      // cBox 배열 안에 있는 각각의 item에 대해서
      foreach (var item in cBox)
      {
        if (item.Checked == true)
          s += item.Text + " ";
      }
      //if (checkBox1.Checked == true)
      //  s += checkBox1.Text + " ";
      //if (checkBox2.Checked == true)
      //  s += checkBox2.Text + " ";
      //if (checkBox3.Checked == true)
      //  s += checkBox3.Text + " ";
      //if (checkBox4.Checked == true)
      //  s += checkBox4.Text + " ";
      //if (checkBox5.Checked == true)
      //  s += checkBox5.Text + " ";

      MessageBox.Show(s);

      string t = "";

      foreach(var item in cBox)
      {
        t += string.Format("{0} : {1}\n", item.Text, item.Checked);
      }

      MessageBox.Show(t);
    }
  }
}
