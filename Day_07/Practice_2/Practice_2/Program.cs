using System;

namespace Practice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReturnSum(13));
        }


        static int ReturnSum(int number)
        {
            
            if (number <= 1) return number;
            number += ReturnSum(number - 1);
            return number;
        }

    }
}
