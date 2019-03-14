using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassSample
{
    class Program
    {
        static void Main(string[] args)
        {
            pubMath math1 = new pubMath();
            math1.num1 = 99;
            math1.num2 = 100;
            Console.WriteLine("pubMath: " + math1.add().ToString());

            staMath.num1 = 99;
            staMath.num2 = 100;
            Console.WriteLine("staMath: " + staMath.add().ToString());
            Console.WriteLine("staMath: " + staMath.add(99, 100));

            oopMath om = new oopMath(99, 100);
            Console.WriteLine("oopMath: " + om.add().ToString());

            Console.Read();
        }
    }
}
