using System.Net;

namespace SolveProblems
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fibonacci(10));
        }

        public static int Fibonacci(int n)
        {
            if (n < 0)
                throw new ArgumentException("Argument exception message");

            if (n == 0)
                return 0;

            if (n == 1)
                return 1;

            List<int> fib = new List<int>() { 0, 1 };

            for (int i = 2; i <= n; i++)
            {
                fib.Add(fib[i-1] + fib[i - 2]);
            }

            return fib[fib.Count - 1];
        }

        public static bool IsPrime(int n)
        {
            if (n <= 0)
                return false;

            if (n < 4)
                return true;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }
    }
}