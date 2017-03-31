using System;

namespace FibonacciSolution
{
    public class Fibonacci
    {
        public int GetNthNumber(int n)
        {
            if (n < 0)
                throw new ArgumentException("Invalid Parameter.  Must be greater than zero.");

            // easy way
            // ********************* 
            //if (n == 0 || n == 1 || n == 5)
            //    return n;
            //else if (n == 10)
            //    return 55;

            //return n - 1;
            // ********************* 

            int i = 0;
            int total = 0;
            int num1 = 0;
            int num2 = 1;

            if (n < 2)
                return n;

            while (i < n)
            {
                total = num1 + num2;                

                num2 = num1;
                num1 = total;                

                i++;
            }

            return total;
        }

        public string Print(int n)
        {
            return GetNthNumber(n).ToString();
        }
    }
}
