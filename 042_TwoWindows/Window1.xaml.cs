using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace _042_TwoWindows
{
  /// <summary>
  /// Window1.xaml에 대한 상호 작용 논리
  /// </summary>
  public partial class Window1 : Window
  {
    MainWindow mainW;
    public Window1(string name, MainWindow w)
    {
      InitializeComponent();

      mainW = w;

      txtName.Text = name + "님! 안녕하세요!";
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
      this.Close();
      mainW.Close();
    }
  }
}
