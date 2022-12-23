using System;

namespace perfect_numbers
{
    internal class Program
    {
        static bool isperfect(int x)
        {
            int sum = 0;
            for (int i = 1; i < x; i++)
            {
                if (x  % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == x)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
        static void Main(string[] args)
        {
            int n1, n2;

            Console.WriteLine("enter n1:");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter n2:");
            n2 = int.Parse(Console.ReadLine());

            Console.Write("\n");

            for(int x=n1; x<=n2; x++)
            {
              if(isperfect (x))
                {
                    Console .WriteLine (x); Console.Write("\n");
                }
            }
        }
    }
}
