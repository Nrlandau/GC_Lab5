using System;

namespace Lab5
{
    class Program
    {
        static int Factorial(int a)
        {
            if(a < 0)
                throw new ArgumentOutOfRangeException();
            if(a != 0)
                return Factorial(a-1) * a;
            return 1;
        }
        static void Main(string[] args)
        {
        }
    }
}
