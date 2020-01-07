using System;

namespace EvenFibonacciSum
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Hey anonymous user, please enter your desired maximum limit which shouldn't be exceeded by the sum of all the even numbers in the Fibonacci sequence. N.B: More like ceiling value, not the number of elements!: ");
            string input = Console.ReadLine();
            try
            {
                int limit = Int32.Parse(input);
                Console.WriteLine($"The sum of even numbers in yor chosen Fibonnaci sequence, which doesn't exceed  5 million is: {evenFibonacciSum(limit)}");
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{input}'. Please restart the program and enter a valid integer number");
            }
        }

        static int evenFibonacciSum(int limit)
        {

            //Recursive formula for even Fibonacci Numbers
            /*
            *Recurrence for Even Fibonacci sequence is:
                EFn = 4EFn-1 + EFn-2
            with seed values
                EF0 = 0, EF1 = 2.
            Where EFn means n'th term in Even Fibonacci sequence    
            */

            if (limit < 2)
            {
                return 0;
            }

            //Initialize first two even
            //numbers and their sum
            int firstEvenFib = 0;
            int secondEvenFib = 2;

            int sum = firstEvenFib + secondEvenFib;

            //calculating sum of even
            //Fibonacci value
            //with a condition that sum, after being incremented, cannot be greater than 5 000 000
            while (secondEvenFib <= limit && (sum + secondEvenFib) < 5000000)
            {
                // get next even value of Fibonacci sequence 
                int thirdEvenFib = 4 * secondEvenFib + firstEvenFib;

                // Move to next even number 
                // and update sum 
                firstEvenFib = secondEvenFib;
                secondEvenFib = thirdEvenFib;
                sum += secondEvenFib;
            }
            return sum;
        }
    }
}
