﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        public int Add(int first, int second)
        {
            return first + second;
        }

        public int Subtract(int first, int second)
        {
            return first - second;
        }

        public int Multiply(int first, int second)
        {
            return first * second;
        }

        public double? Divide(double first, double second)
        {
            if (second == 0)
            {
                Console.WriteLine("Cannot divide by zero.");
                return null;
            }
            return first / second;
        }
    }
}

