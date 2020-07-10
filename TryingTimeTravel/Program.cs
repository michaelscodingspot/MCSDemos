using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryingTimeTravel
{
    class Program
    {
        class Person
        {
            public int Age { get; set; } = 5;
        }

        static void Main(string[] args)
        {
            var t = new MyClass1().MyInt;
            var x = new Person();
            MyClass1.Foo();

            MyClass1.Calc(22);

            try
            {
                throw new Exception("dfdsfsda");

            }
            catch
            {
                int xx = 5;
                int y = xx + 2;


            }

        }
    }
}
