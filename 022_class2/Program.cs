namespace _022_class2
{
  class Product
  {
    public string? name;
    public int price;
  }

  class MyMath
  {
    public static double PI = 3.14;
  }

  class MyCalendar
  {
    public const int months = 12;
    public const int weeks = 52;
    public const int days = 365;

    public const double daysPerWeek = (double)days / weeks;
    public const double daysPerMonth = (double)days / months;
  }
  internal class Program
  {
    static void Main(string[] args)
    {
      // Product의 객체 p를 만들고, p의 이름은 "시계", 가격은 10만원
      Product p = new Product();
      p.name = "시계";
      p.price = 100000;

      // 객체 p의 이름과 가격을 출력하시오
      Console.WriteLine(p.name);
      Console.WriteLine(p.price);

      // MyMath 객체를 만들자
      MyMath m = new MyMath();
      Console.WriteLine(MyMath.PI);

      // MyCalendar 객체 c를 만들자
      MyCalendar c = new MyCalendar();
      Console.WriteLine("{0:F3}", MyCalendar.daysPerMonth);
    }
  }
}
