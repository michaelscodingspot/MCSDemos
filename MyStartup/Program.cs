using Lib1;
using Lib2;
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
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine(SumNumbers(a, b));
            Serialize();

        }

        private static void Serialize()
        {
            var serializer1 = new Serializer1();
            var serializer2 = new Serializer2();
            serializer2.Foo();
            serializer1.Foo();
        }

        private static int SumNumbers(int a, int b)
        {
            var calculator = new Calculator();
            return calculator.Sum(a, b);
        }
    }
}
