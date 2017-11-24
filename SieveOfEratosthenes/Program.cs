using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieveOfEratosthenes
{
    class Program
    {
        /// <summary>
        /// This program calculates the Sieve of Eratosthenes using
        /// an array of Booleans.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int stoppingValue = 0;
            string doAgain = "N";

            do
            {
                Console.Write("Enter the stopping value (2 to 10,000): ");
                stoppingValue = Convert.ToInt32(Console.ReadLine());

                Console.Write($"\nHere are all of the prime numbers from 2 to {stoppingValue}:");

                // This section handles all of the logic for the Sieve.
                // The outer loop handles printing the indexes
                // The inner if determines whether a number should be printed
                // The inner loop determines which other numbers to mark
                Boolean[] primes = new Boolean[stoppingValue + 1];
                for ( int i = 2; i < primes.Length; i++ )    // We need to start at 2 b/c 1 isn't prime
                {
                    // If a given indexed location is 0, then it hasn't been marked.
                    // If it hasn't been marked, then we want to print it and mark it.
                    if (primes[i] == false)
                    {
                        Console.Write("\n" + i);
                        primes[i] = true;
                    }

                    // We then go through and mark all of the multiples the original index
                    for ( int j = i + i; j < primes.Length; j += i )
                    {
                        primes[j] = true;
                    }
                }
                
                Console.Write("\nDo you want to create another list? (Y or N): ");
                doAgain = Console.ReadLine().ToUpper();
                if(doAgain != "Y" && doAgain !="N")
                {
                    Console.Write("\nPlease enter Y or N :");
                    doAgain = Console.ReadLine().ToUpper();
                }
            } while (doAgain == "Y") ;

        }
    }
}
