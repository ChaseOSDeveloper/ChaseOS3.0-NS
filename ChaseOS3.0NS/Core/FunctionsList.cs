using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaseOS3._0NS.Core
{
    public class FunctionsList
    {
        public FunctionsList()
        {

        }
        public void Calc(string number1, string operation, string number2)
        {
            int first = Convert.ToInt32(number1);
            int second = Convert.ToInt32(number2);
            if (operation == "+")
            {
                Console.WriteLine(first + second);
            } else if (operation == "-")
            {
                Console.WriteLine(first - second);
            } else if (operation == "*")
            {
                Console.WriteLine(first * second);
            } else if (operation == "/")
            {
                Console.WriteLine(first / second);
            }
        }
    }
}
