using System;

namespace CoordinatePaths
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter X:");
            string inputX = Console.ReadLine();
            Console.Write("Enter Y :");
            string inputY = Console.ReadLine();

            int X = 0;
            int Y = 0;

            try
            {
                X = int.Parse(inputX);
                Y = int.Parse(inputY);
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter .");
                return;
            }

            Console.WriteLine($"Calculating paths to ({X}, {Y})...");
            int pathCount = CalculatePaths(X, Y);
            Console.WriteLine($"Number of paths: {pathCount}");

        }

        static int CalculatePaths(int X, int Y)
        {
            if (X == 0 && Y == 0)
                return 1;

            if (X == 0)
                return 1;

            if (Y == 0)
                return 1;

            return Factorial(X + Y) / (Factorial(X) * Factorial(Y));
        }

        static int Factorial(int n)
        {
            if (n == 0)
                return 1;
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }

}
