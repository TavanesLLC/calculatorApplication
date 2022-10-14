using System;

namespace Calculator.Library
{
    public class Calculator
    {
        //public static int Divide(int numerator, int denominator)
        //{
          //  int result = numerator / denominator;
            //return result;
        //}

        public static int Divide(int numerator, int denominator)
        {

        if (denominator == 0)
            throw new DivideByZeroException("Denominator cannot be Zero");

        int result = numerator / denominator;
            return result;
        }

        public static int Add(int fn, int sn)
        {
            if (isPositive(fn) && isPositive(sn))
            {
                int result = fn + sn;
                return result;
            }
            else
            {
                throw new ArgumentException("Only positive number are allowed");
            }
        }

        private static bool isPositive(int Number)
        {
            return Number > 0;
        }

    }
}