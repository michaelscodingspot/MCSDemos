using Lib1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStartup
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(SumNumbers(a, b));
        }

        private static int SumNumbers(int a, int b)
        {
            var calculator = new Calculator();
            return calculator.Sum(a, b);
        }
    }
}
