using System;
using System.Threading.Tasks;

namespace Factorial
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.Write("Enter number for factorial : ");
            int number = Convert.ToInt32(Console.ReadLine());

            int firstTaskWork = number / 2;

            Task<int> firstTask = Task.Run(() => Fact(firstTaskWork));

            await firstTask.ContinueWith((completedTask) =>
            {
                int result = completedTask.Result; 
                for (int i = firstTaskWork + 1; i <= number; i++)
                    result *= i;

                Console.WriteLine(result);
            });
        }

        static int Fact(int number)
        {
            if (number == 0 || number == 1)
            {
                return 1;
            }

            return number * Fact(number - 1);
        }

    }
}