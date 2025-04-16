namespace _023_staticMethod
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Date bDay = new Date();
      bDay.year = 2025;
      bDay.month = 12;
      bDay.day = 26;

      Console.WriteLine("내 생일은 {0}째 되는 날입니다.", bDay.DayOfYear());

      Console.WriteLine(Date.IsLeapYear(2028));
    }
  }
}
