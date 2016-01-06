using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            MyObject myObject = new MyObject();
            MyObject myObject2 = new MyObject(10, 10);
            myObject.Calculate(10, 10);

            //myObject.number1 = 10;
            //myObject.number2 = 5;

            //Console.WriteLine("Number 1 is " + myObject.number1);
            //Console.WriteLine("Number 2 is " + myObject.number2);
            Console.WriteLine("object 1 property is " + myObject.number3);
            Console.WriteLine("object 2 property is " + myObject2.number3);
            Console.ReadLine();



        }
    }

    class MyObject
    {
        public MyObject()
        {
            _number1 = 5;
            _number2 = 5;
        }

        public MyObject(int number1, int number2)
        {
            _number1 = number1;
            _number2 = number2;
        }

        int _number1 = 0;
        int _number2 = 0;
        int _number3 = 0;

        public int number1 {
            get
            {
                return _number1;
            }
            set
            {
                _number1 = value;
            }
        }
        public int number2 {
            get
            {
                return _number2;
            }
            set
            {
                _number2 = value;
            }
        }

        public int number3
        {
            get
            {
                return number1 + number2;
            }
        }

        public int Calculate(int number1, int number2)
        {
            return number1 + number2;
        }

        public int Calculate()
        {
            return _number1 + _number2;
        }
        public string MyMethod()
        {
            return "some value";
        }
    }
}
