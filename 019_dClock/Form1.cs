using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _019_dClock
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      timer1.Enabled = true;
      timer1.Interval = 1000;
      timer1.Tick += Timer1_Tick;

      lblDate.Font = new Font("맑은 고딕", 16, FontStyle.Bold);
      lblDate.ForeColor = Color.DarkOrange;

      lblTime.Font = new Font("맑은 고딕", 32, FontStyle.Bold);
      lblTime.ForeColor = Color.DarkBlue;
    }

    private void Timer1_Tick(object sender, EventArgs e)
    {
      lblDate.Text = DateTime.Now.ToString("yyyy년 MM월 dd일");
      lblTime.Text = DateTime.Now.ToString("tt h:mm:ss");

      lblDate.Location = new Point(ClientSize.Width/2 - lblDate.Width/2,
        ClientSize.Height/2 - lblDate.Height/2 - 30);

      lblTime.Location = new Point(ClientSize.Width / 2 - lblTime.Width / 2,
        ClientSize.Height / 2 - lblTime.Height / 2 + 20);
    }

    private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
