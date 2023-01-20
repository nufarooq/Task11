using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdditionSubstractionApp
{
    public class Calc
    {
        public int add(string num1, string num2)
        {
            int a = Int32.Parse(num1);
            int b = Int32.Parse(num2);
            return a + b;
        }
        public int sub(string num1, string num2)
        {
            int a = Int32.Parse(num1);
            int b = Int32.Parse(num2);
            return a - b;
        }
    }
}