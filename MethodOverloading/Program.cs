using System.Diagnostics.CodeAnalysis;

namespace MethodOverloading
{
    public class Program
    {

        public static int Add(int x, int y) 
        {
            return x + y;
            
        }

        public static double Add(double x, double y)
        {
            return x + y;
        }

        public static void Add(int x, int y, bool isCheck)
        {
            var sum = x + y;

            if (isCheck == true && sum == 1)
            {
                Console.WriteLine($"{sum} dollar");
            }

            else if (isCheck == true)
            {
                Console.WriteLine($"{sum} dollars");
            }

            else if (isCheck == false)
            {
                Console.WriteLine("Will not compute");
            }

           

        }

        static void Main(string[] args)
        {
            Add(1, 0, true);

            var answer1 = Add(1, 6);

            Console.WriteLine(answer1);

            var answer2 = Add(1.23, 7.0);

            Console.WriteLine(answer2);


        }
    }
}
