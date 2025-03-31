namespace _003_bmiCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("키(cm) 입력 : ");
            string s = Console.ReadLine();
            double h = double.Parse(s);

            Console.Write("체중(kg) 입력 : ");
            s = Console.ReadLine();
            double w = double.Parse(s);

            h /= 100;
            double bmi = w / (h * h);
            Console.WriteLine("BMI = " + bmi);
        }
    }
}
