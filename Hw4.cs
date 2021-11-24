using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    class Program
    {
        public int adad_detect(int a)
        {
            if (a > 0)
            {
                return a * a;
            }
            else
            {
                return a;
            }
        }

        public int day(string na)
        { 
            int d = 0;
            na = na.ToLower();
            switch (na) 
            { 
                case "январь": 
                    d = 1; 
                    break;
                case "февраль":
                    d = 2;
                    break;
                case "март":
                    d = 1;
                    break;
                case "апрел":
                    d = 3;
                    break;
                case "май":
                    d = 1;
                    break;
                case "июнь":
                    d = 3;
                    break;
                case "июль":
                    d = 1;
                    break;
                case "август":
                    d = 1;
                    break;
                case "сентябрь":
                    d = 3;
                    break;
                case "октябрь":
                    d = 1;
                    break;
                case "ноябрь":
                    d = 3;
                    break;
                case "декабрь":
                    d = 1;
                    break; 

            } 
            if (d == 1)
            {
                return 31;
            }
            if (d == 2)
            {
                return 28;
            }
            if (d == 3)
            {
                return 30;
            }
            else
            {
                return 0;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Home-Work 4!");
            Console.WriteLine("EX1:");
            int a, b, c;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            var func = new Program();
            Console.WriteLine(func.adad_detect(a));
            Console.WriteLine(func.adad_detect(b));
            Console.WriteLine(func.adad_detect(c));

            Console.WriteLine("EX2:");
            string month;
            month = Console.ReadLine();
            Console.WriteLine(func.day(month));

            Console.WriteLine("EX3:");
            bool adadd1, adadd2;
            int aa, bb, cc;
            aa = Convert.ToInt32(Console.ReadLine());
            bb = Convert.ToInt32(Console.ReadLine());
            cc = Convert.ToInt32(Console.ReadLine());
            adadd1 = (aa < bb) && (bb < cc);
            adadd2 = (bb > aa) && (aa > cc);
            Console.WriteLine("1: " + adadd1);
            Console.WriteLine("2: " + adadd2);

            Console.ReadLine();
        }
    }
}
