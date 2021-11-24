using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        public int calc(int a, int b)
        {
            return a + b;
        }
        public string gs(int bb)
        {
            if (bb >= 18)
            {
                return "YES";
            }
            else
            {
                return "NO";
            }
        }
        public bool isEven(int a)
        {
            if (a % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("3 Home-Work");
            Console.WriteLine("1 ex:");
            int b;
            var func = new Program();
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(func.isEven(b));
            Console.WriteLine("2 ex:");
            int age;
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(func.gs(age));

            Console.WriteLine("3 ex:");
            int aa, bb;
            aa = Convert.ToInt32(Console.ReadLine());
            bb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(func.calc(aa, bb));
            Console.ReadLine();
        }
    }
}
