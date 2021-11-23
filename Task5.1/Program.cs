using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 7;
            double[] array = new double[n];
            Console.WriteLine("введите 7 элементов");
            for (int i = 0; i < n; i++)
            {
                array[i] = Convert.ToDouble(Console.ReadLine());
            }
            double S = 0;
            for (int i = 0; i < n; i++)
            {
                S += array[i];
            }
            Console.WriteLine("среднее арифметическое = {0:f2}", S/n);
            Console.ReadKey();

        }

    }
}
