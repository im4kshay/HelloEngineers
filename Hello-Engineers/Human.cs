using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Engineers
{
    class Human
    {
        //variables
        //access modifiers datatype variable name
        public string name="Akshay", address="Ahinsa Chowk";
        public double height=5.6;
        //public decimal a = 12.45M;
         
        //methods
        public void Speek()
        {
            Console.WriteLine("He/She can talk");
            Console.WriteLine("Name :- {0} Address :- {1} Height :- {2}", name, address, height);
        }
    }
}
