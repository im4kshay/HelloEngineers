using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Engineers
{
    class Palindrome
    {
        public static void FindPalindrome(int inputNumb, int reverse)
        {
            //1221 1221
            if (reverse == inputNumb)
            {
                Console.WriteLine("Given Number is a Palidrome");
            }
            else
            {
                Console.WriteLine("Given Number is not a Palidrome");
            }
        }
    }
}
