using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Engineers
{
    class Calculator
    {
        public void Calculation()
        {
            int res;
            Console.WriteLine("Enter First Number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter symbol(/,*,+,-):");
            string symbol = Console.ReadLine();

            switch (symbol)
            {
                case "+":
                    res = num1 + num2;
                    Console.WriteLine("Addition:" + res);
                    break;

                case "-":
                    res = num1 - num2;
                    Console.WriteLine("Subtraction:" + res);
                    break;

                case "*":
                    res = num1 * num2;
                    Console.WriteLine("Multiplication:" + res);
                    break;

                case "/":
                    res = num1 / num2;
                    Console.WriteLine("Division:" + res);
                    break;

                default:
                    Console.WriteLine("Wrong Input");
                    break;
            }
            Console.ReadLine();
        }
    }
}
