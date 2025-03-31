using System.Collections.Concurrent;

namespace _007_Format
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("안녕하세요!! C# 입니다.");
      Console.WriteLine("10이하의 소수 : {0} {1} {2} {3}",
        2, 3, 5, 7);

      string s
        = string.Format("10이하의 소수 : {0} {1} {2} {3}", 2, 3, 5, 7);

      Console.WriteLine(s);

      int v1 = 100;
      double v2 = 1.234;

      //Console.WriteLine(v1, v2); // 에러
      Console.WriteLine("v1 = " + v1 + ", v2 = " + v2);
      Console.WriteLine("v1 = {0}, v2 = {1}", v1, v2);
      Console.WriteLine($"v1 = {v1}, v2 = {v2}");

      double x = 123456789.5678;
      Console.WriteLine("{0:C}", x);
      Console.WriteLine("{0:E}", x);
      Console.WriteLine("{0:F2}", x);
      Console.WriteLine("{0:N2}", x);
      Console.WriteLine("{0:#,#.##}", x);

    }
  }
}
