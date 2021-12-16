using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class SimpleCalculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }

        public int Add()
        {
            return FirstNumber + SecondNumber;
        }
    }
}
