class InfiniteSeries
{
    static void Main(string[] args)
    {
        double ex = 1.0;
        double denominator = 1.0;
        double numerator = 1.0;

        Console.Write("Enter The Number Of Terms To Be Used In The Series:  ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter The Value Of X:  ");
        double x = Convert.ToDouble(Console.ReadLine());

        for (int i = 1; i <= number; i++) 
        {
            numerator *= x;
            denominator *= i;   // same as factorial
            ex = numerator / denominator;
        }

        Console.WriteLine("Estimated Value Of e^x:  " + ex);

        Console.WriteLine("Actual Value Of e^x:  " + Math.Pow(Math.E, x));
    }
}