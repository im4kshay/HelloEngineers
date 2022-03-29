using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Engineers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Engineers lets play with Programs..!!");
            Console.WriteLine("1: Human\n2: Swap Numbers\n3: Revserse or Palinndrome\n4: User Name Replace\n5: Flip Coin\n6: Calculator\n7: Largest Number\n");
            int option = Convert.ToInt32(Console.ReadLine()); 
            switch(option)
            {
                case 1:
                    //object
                    //class name variablle name = new Classname();
                    Human human = new Human();
                    human.Speek();
                    break;

                case 2:
                    Swap_Numbers swap = new Swap_Numbers();
                    swap.SwapTwoNumbers();
                    break;

                case 3:
                    Console.WriteLine("Enter Number To Reverse ");
                    int number = Convert.ToInt32(Console.ReadLine());
                    ReverseNumber.RevNum(number);
                    break;

                case 4:
                    UserReplace.ReplaceUserName();
                    break;

                case 5:
                    FlipCoin.FindFlipCount();
                    break;

                case 6:
                    Calculator cal = new Calculator();
                    cal.Calculation();
                    break;

                case 7:
                    LargestNumber lnum = new LargestNumber();
                    lnum.LargNum();
                    break;
                    
                default:
                    Console.WriteLine("Please Choose Program/Number Between 1 to 5");
                    break;
            }
            Console.ReadLine();
        }
    }
}
