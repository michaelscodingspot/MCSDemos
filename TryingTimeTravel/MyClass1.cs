using System;

namespace TryingTimeTravel
{
    internal class MyClass1
    {
        public int MyInt
        {
            get
            {
                int x = 5;
                int y = x * x;
                return y;
            }
        }

        internal static void Foo()
        {

            int x = 5;
            for (int i = 0; i < 100; i++)
            {
                double someValue = Calc(i);
            }
            int y = x * 2;
        }

        public static double Calc(int i)
        {
            return i / 17.0;
        }
    }
}