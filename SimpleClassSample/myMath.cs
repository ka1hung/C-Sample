using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassSample
{

    public class pubMath
    {
        public int num1 = 0;
        public int num2 = 0;

        public int add()
        {
            return num1 + num2;
        }
        public float add(int a, int b)
        {
            return a + b;
        }
    }

    public class staMath
    {
        static public int num1 = 0;
        static public int num2 = 0;

        static public int add()
        {
            return num1 + num2;
        }
        static public float add(int a, int b)
        {
            return a + b;
        }
    }

    public class oopMath
    {
        private int _num1 { get; set; }
        private int _num2 { get; set; }

        public oopMath(int num1, int num2)
        {
            _num1 = num1;
            _num2 = num2;
        }
        public int add()
        {
            return _num1 + _num2;
        }
        public float add(int a, int b)
        {
            return a + b;
        }
    }
}
