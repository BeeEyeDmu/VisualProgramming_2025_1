namespace _028_Circle
{
  class Circle
  {
    private double radius;

    public Circle(double r)
    {
      radius = r;
    }

    public double GetArea()
    {
      return 3.14*radius*radius;
    }
  }
  internal class Program
  {
    static void Main(string[] args)
    {
      Circle donut = new Circle(5);
      Circle pie = new Circle(10);
      Circle pizza = new Circle(15);

      Console.WriteLine("도넛의 면적 = {0}", donut.GetArea());
      Console.WriteLine($"도넛의 면적 = {donut.GetArea()}");

      Console.WriteLine("파이의 면적 = {0}", pie.GetArea());
      Console.WriteLine("피자의 면적 = {0}", pizza.GetArea());
    }
  }
}
