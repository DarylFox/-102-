using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static void Function(double x)
        {
            double y = (x * x * x) / 2;
            Console.WriteLine(y);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите точку начала и конца шаг:");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите шаг:");
            double step = Convert.ToDouble(Console.ReadLine());
            int n_step = (int)((x2 - x1) / step);

            for (int i = 0; i <= n_step ; i++)
            {
                Console.Write(x1 + i * step + " ");
                Function(x1 + i * step);
            }
            Console.ReadLine();
        }
    }
}

