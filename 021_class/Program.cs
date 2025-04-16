namespace _021_class
{
  class Date
  {
    private int year, month, day;

    public void SetYear(int year)
    {
      this.year = year;
    }
    public int GetYear()
    {
      return this.year;
    }
    public void PrintDate()
    {
      Console.WriteLine("{0}년 {1}월 {2}일", year, month, day);
    }

    // 생성자
    public Date()
    {
      year = 1;
      month = 1;
      day = 1;
    }

    public Date(int y, int m, int d)
    {
      year = y;
      month = m;
      day = d;
    }
  }
  public class Program
  {
    
    static void Main(string[] args)
    {
      Date a = new Date();

      a.SetYear(2025);
      Console.WriteLine(a.GetYear());
      a.PrintDate();

      Date b = new Date();
      b.PrintDate();

      Date c = new Date(2025,4,7);
      c.PrintDate();
    }
  }
}
