using System;

namespace Lab5
{
    class Program
    {
        static long Factorial(long factNum)
        {
            if(factNum < 0)
                throw new ArgumentOutOfRangeException();
            if(factNum != 0)
                return Factorial(factNum-1) * factNum;
            return 1;
        }
        static long FactorialLoop(long factNum)
        {
            if(factNum < 0)
                throw new ArgumentOutOfRangeException();
            long end = 1;
            for(int i =1; i <= factNum; i++)
            {
                end *= i;
            }
            return end;
        }
        static void Main(string[] args)
        {
            //vars
            long end_Number = 0,start_Number = 0;
            bool isNotEnd = true;
            
            while(isNotEnd)
            {
                //input
                System.Console.WriteLine("Input a number from 0 to 20");
                try
                {
                    start_Number = int.Parse(System.Console.ReadLine());
                    //magic
                    end_Number = Factorial(start_Number);
                    //output
                    System.Console.WriteLine(end_Number);
                    //repeat?
                    System.Console.WriteLine("Continue(y/?)");
                    if(System.Console.ReadLine().ToLower() == "y")
                        {;}
                    else
                        isNotEnd = false;
                }
                catch(FormatException)
                {
                    System.Console.WriteLine("Invalid Input");
                }
                catch(ArgumentOutOfRangeException)
                {
                    System.Console.WriteLine("The number was too small");
                }
            }
        }
    }
}