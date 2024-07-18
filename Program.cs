using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240718_ClassesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point2D p0;

            Console.WriteLine($"Point2D.InstanceCount: {Point2D.InstanceCount}");

            // class - reference type !!!
            Point2D p1 = new Point2D();

            Console.WriteLine($"Point2D.InstanceCount: {Point2D.InstanceCount}");

            p1.X = 10;    // p1.SetX(10);    //p1._x = 10;

            int x1 = p1.X;

            p1.SetY(-10);

            Console.WriteLine($"p1: {p1}");

            Point2D p2 = new Point2D(12, 5);

            Console.WriteLine($"Point2D.InstanceCount: {Point2D.InstanceCount}");

            Point2D p3 = new Point2D(15);

            Console.WriteLine($"Point2D.InstanceCount: {Point2D.InstanceCount}");

            int sum1 = GetSumma(12, 23);

            Console.WriteLine($"sum1 = {sum1}");

            int sum2 = -54;

            GetSumma(12, 23, out sum2);

            Console.WriteLine($"sum2 = {sum2}");

            int sum3 = 21;

            GetSumma2(12, 23, ref sum3);

            Console.WriteLine($"sum3 = {sum3}");

            MyInt n1 = new MyInt(2);
            MyInt n2 = new MyInt(3);

            MyInt res1 = MyInt.Add(n1, n2);

            Console.WriteLine($"{n1} + {n2} = {res1}");

            MyInt res2 = n1 + n2;

            Console.WriteLine($"{n1} + {n2} = {res2}");

            if (n1 > n2)
            {
                Console.WriteLine("n1 > n2");
            }

            if (n1 < n2)
            {
                Console.WriteLine("n1 < n2");
            }

            int arg1 = (int)n1;

            double arg2 = (double)n2;

            Console.ReadKey();
        }

        public static int GetSumma(int firstArg, int secondArg)
        {
            return firstArg + secondArg;
        }

        public static void GetSumma(int firstArg, int secondArg, out int result)
        {
            //int resultCopy = result;

            result = firstArg + secondArg;
        }

        public static void GetSumma2(int firstArg, int secondArg, ref int result)
        {
            int resultCopy = result;

            result = firstArg + secondArg;
        }
    }
}
