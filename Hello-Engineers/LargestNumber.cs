using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Engineers
{
    class LargestNumber
    {
        public void LargNum()
        {
            Console.WriteLine("Enter First Number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Third Number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            
            if(num1>num2 && num1>num3)
            {
                Console.WriteLine("A is Greater");
            }
            else if(num2>num3 && num2>num1)
            {
                Console.WriteLine("B is Greater");
            }
            else
            {
                Console.WriteLine("C is Greater");
            }
            Console.ReadLine();
        }
    }
}
