namespace _025_Susi2_2
{
  class Rectangle
  {
    private int width, height;

    // 생성자 : 리턴값이 없고, 이름이 클래스와 같다
    public Rectangle(int w, int h)
    {
      width = w; height = h;
    }

    public Rectangle()
    {
      width=0; height=0;
    }

    public int GetArea() { return width * height; }
    public int GetPerimeter() { return width * 2 + height * 2; }
    public void SetWidth(int w) 
    {
      if (w > 0)
        width = w;
      else
      {
        height = 0;
        Console.WriteLine("0보다 큰 값을 사용하세요");
      }
    }
    public void SetHeight(int h)
    {
      if (h > 0)
        height = h;
      else
      {
        width = 0;
        Console.WriteLine("0보다 큰 값을 사용하세요");
      }
    }
  }
  internal class Program
  {
    static void Main(string[] args)
    {
      Rectangle rect = new Rectangle();

      Console.Write("너비 : ");
      int w = int.Parse(Console.ReadLine());
      Console.Write("높이 : ");
      int h = int.Parse(Console.ReadLine());

      //rect.width = w;
      rect.SetWidth(w); 
      rect.SetHeight(h);

      Console.WriteLine("넓이 : {0}", rect.GetArea());
      Console.WriteLine("둘레 : {0}", rect.GetPerimeter());
    }
  }
}
