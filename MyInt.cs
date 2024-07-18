using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240718_ClassesDemo
{
    public class MyInt
    {
        private int _number = 0;

        public MyInt(int number)
        {
            _number = number;
        }

        public override string ToString()
        {
            return $"[{_number}]";
        }

        public static MyInt Add(MyInt a, MyInt b)
        {
            int result = a._number + b._number;

            return new MyInt(result);
        }

        public static MyInt operator +(MyInt a, MyInt b)
        {
            int result = a._number + b._number;

            return new MyInt(result);
        }

        public static bool operator >(MyInt a, MyInt b)
        {
            return a._number > b._number;
        }

        public static bool operator <(MyInt a, MyInt b)
        {
            return a._number < b._number;
        }

        public static explicit operator int(MyInt arg)
        { 
            return arg._number; 
        }

        public static explicit operator double(MyInt arg)
        {
            return arg._number;
        }
    }
}
