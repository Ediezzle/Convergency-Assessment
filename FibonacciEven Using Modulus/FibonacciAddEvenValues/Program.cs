using System;

namespace FibonacciAddEvenValues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your desired maximum limit which shouldn't be exceeded by the largest element in the Fibonacci sequence. N.B: More like ceiling value, not the number of elements!");

            string input = Console.ReadLine();
            try
            {
                int max = Int32.Parse(input);
                Console.WriteLine("Your chosen Fibonacci sequence is as follows: ");
                Fibonacci(max);
            }
          
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{input}'. Please restart the program and enter a valid integer number");
            }
            

        }

        //max is the largest value an element in the fibonacci sequence can take
        static void Fibonacci(int max)
        {
            //Recursive formula for the Fibonacci Sequence Numbers
            /*
            *Recurrence for the Fibonacci sequence is:
                Fn = Fn-1 + Fn-2
            with seed values
                F0 = 0, F1 = 1.
            Where Fn means n'th term in the sequence    
            */
            int firstFibElement = 0;
            int secondFibElement = 1;

            //evenValuesTotal which will store the sum of even elements in the series is initialised to 0
            int evenValuesTotal = 0;

            //The while loop iterates through the sequence up until it reaches max (largest number than all the elements in the sequence)
            while (firstFibElement <= max)
            {
                //print elements of the sequence to the console
                Console.Write(firstFibElement + " ");

                //checking if an element in the sequence is even, and if so, then incrementing the variable evenValuesTotal (sum of the even elements before it in the sequence)
                if (firstFibElement % 2 == 0 && evenValuesTotal+firstFibElement < 5000000)
                {
                    evenValuesTotal += firstFibElement;

                }

                int sum = firstFibElement + secondFibElement;
                firstFibElement = secondFibElement;
                secondFibElement = sum;
            }

            Console.WriteLine();
            Console.WriteLine("Sum of even-valued terms in your Fibonacci sequence which doesn't exceed 5 million is: " + evenValuesTotal);
        }
    }
}
