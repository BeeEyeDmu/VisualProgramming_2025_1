namespace _020_array1
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Random r = new Random();
      int[] a = new int[20];

      // 20개의 난수를 생성하여 배열에 저장
      for (int i = 0; i < 20; i++)
        a[i] = r.Next(101);

      // 출력
      foreach(var i in a)
        Console.Write(i + " ");
      Console.WriteLine();

      // 최소, 최대, 평균(합)
      int min = a[0];
      int max = a[0];
      int sum = 0;
      foreach(var i in a)
      {
        if (i < min)
          min = i;
        if(i > max)
          max = i;
        sum += i;
      }
      Console.WriteLine("min = {0}, max = {1}, avg = {2}", 
        min, max, sum/20.0);
    }
  }
}
