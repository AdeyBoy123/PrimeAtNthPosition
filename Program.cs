using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeAtNthPosition
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the position (N) to find the prime number:");
            int position;
            if (int.TryParse(Console.ReadLine(), out position))
            {
                int prime = FindNthPrime(position);
                Console.WriteLine($"Prime number at position {position}: {prime}");
            }
            else
            {
                Console.WriteLine("Please enter a valid position.");
            }
        }

        public static int FindNthPrime(int n)
        {
            int count = 0; // how many primes we've found
            int number = 2; // the current number to check
            while (true)
            {
                if (IsPrime(number))
                {
                    count++;
                    if (count == n)
                    {
                        return number;
                    }
                }
                number++;
            }
        }

        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number <= 3) return true;

            // This is checked so that we can skip middle five numbers in below loop
            if (number % 2 == 0 || number % 3 == 0) return false;

            int i = 5;
            while (i * i <= number)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                    return false;
                i += 6;
            }
            return true;
        }
    }
}
