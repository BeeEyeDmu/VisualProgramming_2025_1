using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;

namespace _043_EIS
{
  /// <summary>
  /// MainWindow.xaml에 대한 상호 작용 논리
  /// </summary>
  public partial class MainWindow : Window
  {
    string connStr =
      "server=localhost; user id=root; password=1234; database=eis";

    private MySqlConnection conn;
    private string gender;
    private string dateEnter; // 입사일
    private string dateExit; // 퇴사일
    private string dept;  // 부서
    private string pos;  // 직급

    public MainWindow() // 생성자
    {
      InitializeComponent();

      conn = new MySqlConnection(connStr);

      if (conn != null)
      {
        MessageBox.Show("Connection Success!");
      }

      DisplayDataGrid();
    }

    private void btnAdd_Click(object sender, RoutedEventArgs e)
    {
      // 성별 처리
      if (rbMale.IsChecked == true)
        gender = "남성";
      else if (rbFeMale.IsChecked == true)
        gender = "여성";

      // 입사일, 퇴사일 처리
      if(dpEnter.SelectedDate != null)
        dateEnter = dpEnter.SelectedDate.Value.Date.ToShortDateString();
      if (dpExit.SelectedDate != null)
        dateExit = dpExit.SelectedDate.Value.Date.ToShortDateString();
      else
        dateExit = DateTime.MaxValue.ToShortDateString();

      // 콤보박스 처리
      dept = cbDept.Text;
      pos = cbPos.Text;

      // 데이터베이스 부분
      conn.Open();

      // 명령어 만들기(SQL 문법)
      string sql = string.Format("INSERT INTO eis_table (name, department, "
        + "position, gender, date_enter, date_exit, contact, comment) "
        + "VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",
        txtName.Text, dept, pos, gender, dateEnter, dateExit, 
        txtContact.Text, txtComment.Text);

      //MessageBox.Show(sql);
      MySqlCommand cmd = new MySqlCommand(sql, conn);
      if (cmd.ExecuteNonQuery() == 1)
        MessageBox.Show("Insert Success!");

      conn.Close();
      InitControls();

      DisplayDataGrid();
    }

    private void InitControls()
    {
      txtEid.Text = "";
      txtName.Text = "";
      txtContact.Text = string.Empty;
      txtComment.Text = string.Empty;
      cbDept.SelectedIndex = -1;
      cbPos.SelectedIndex = -1;
      rbMale.IsChecked = false;
      rbFeMale.IsChecked = false;
      dpEnter.Text = string.Empty;
      dpExit.Text = string.Empty;
    }

    private void btnLoadData_Click(object sender, RoutedEventArgs e)
    {
      DisplayDataGrid();  
    }

    private void DisplayDataGrid()
    {
      conn.Open();

      string sql = "SELECT * FROM eis_table";

      try
      {
        MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        dataGrid.ItemsSource = ds.Tables[0].DefaultView;
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }

      conn.Close();
    }

    private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
      //DataGrid dg = (DataGrid)sender;
      DataGrid dg = sender as DataGrid;
      DataRowView rowView = dg.SelectedItem as DataRowView;

      if (rowView == null)
        return;

      txtEid.Text = rowView.Row[0].ToString();
      txtName.Text = rowView.Row[1].ToString();
      cbDept.Text = rowView.Row[2].ToString();
      cbPos.Text = rowView.Row[3].ToString();

      if (rowView.Row[4].ToString() == "남성")
      {
        rbMale.IsChecked = true;
        rbFeMale.IsChecked = false;
      }
      else
      {
        rbMale.IsChecked = false;
        rbFeMale.IsChecked = true;
      }

      dpEnter.Text = rowView.Row[5].ToString();      
      dpExit.Text = rowView.Row[6].ToString();
      txtContact.Text = rowView.Row[7].ToString();
      txtComment.Text = rowView.Row[8].ToString();
    }

    private void btnUpdate_Click(object sender, RoutedEventArgs e)
    {
      if (rbMale.IsChecked == true)
        gender = "남성";
      else
        gender = "여성";

      dateEnter = dpEnter.Text;
      dateExit = dpExit.Text;

      string sql = string.Format(
        "UPDATE eis_table SET name='{0}', department='{1}', position='{2}', gender='{3}'," +
        "date_enter='{4}', date_exit='{5}', contact='{6}', comment='{7}' WHERE eid={8}",
        txtName.Text, cbDept.Text, cbPos.Text, gender, dateEnter, dateExit,
        txtContact.Text, txtComment.Text, txtEid.Text);

      //MessageBox.Show(sql);

      conn.Open();

      MySqlCommand cmd = new MySqlCommand(sql, conn);
      if (cmd.ExecuteNonQuery() == 1)
        MessageBox.Show("Update Success!");

      conn.Close();

      InitControls();
      DisplayDataGrid();
    }

    private void btnInit_Click(object sender, RoutedEventArgs e)
    {
      InitControls();
    }
  }
}
