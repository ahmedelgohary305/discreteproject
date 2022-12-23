using System;
using System.Xml.Linq;

namespace prime_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isprime=true;
            int n1, n2;

            Console.WriteLine("enter n1:");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter n2:");
            n2 = int.Parse(Console.ReadLine());
            
            for (int x = n1; x <= n2; x++)
            {
                for (int y = 2; y <= n2;y++)
                {
                    if (x!=y && x % y == 0)
                    {
                        isprime = false;
                        break;
                    }

                }
                if(isprime )
                {
                    Console.WriteLine(x);
                }
                isprime = true;
            }
           

        }
    }
}
