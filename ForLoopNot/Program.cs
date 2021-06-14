using System;

namespace ForLoopNot
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number1, sum;
            sum = 0;

            for(Number1 = 100; Number1<=500; Number1 = Number1+1)
            {
                if(Number1 % 11 == 0 && Number1 % 2 != 0)
                {
                    Console.WriteLine(Number1);
                    sum = sum + Number1;
                }
            }
            Console.WriteLine("sum of all number that divided by 11 but not by 2 are = " + sum.ToString());
        }
    }
}
