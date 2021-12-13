using Practice_1.ExceptionClass;
using System;
using yieldReturn_Demo;

namespace Practice_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 1, 2, 3, 4, 5 };
            Console.WriteLine(arr[2]);
            

            try
            {
                ILinkedItem<string> li = new LinkedItem<string>();
                li.AddItem("aa");
                li.AddItem("ab");
                li.AddItem("ac");
                li.AddItem("ad");
                li.AddItem("ae");
                li.AddItem("af");
                foreach (var item in li)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine("After changing");
                Console.WriteLine(li[2]);
                li[3] = "wp";
                foreach (var item in li)
                {
                    Console.WriteLine(item);
                }
            }
            catch (IndexCantBeNegativeNumberException ex)
            {
                Console.WriteLine($"Exception : {ex.Message}");
            }
            catch (InvalidArgumentException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }
}
