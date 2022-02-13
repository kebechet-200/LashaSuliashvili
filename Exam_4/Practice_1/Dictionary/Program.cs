using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Task> tasks = new List<Task>();

            var files = InputOutputOperation();

            Task t1 = Task.Run(async () =>
           {
               await Read(files.Item1);
           });

            Task t2 = Task.Run(async () =>
            {
               await Read(files.Item2);
            });

            tasks.Add(t1);
            tasks.Add(t2);

            Task.WaitAll(tasks.ToArray());
        }

        static (string,string) InputOutputOperation()
        {
            Console.Write("Enter first file name : ");
            string firstFile = Console.ReadLine();
            string firstPath = $"../../../{firstFile}.txt";

            Console.Write("Enter second file name : ");
            string secondFile = Console.ReadLine();
            string secondPath = $"../../../{secondFile}.txt";

            return (firstPath, secondPath);
        }

        static async Task Read(string filePath)
        {
            string _result; 
            using (StreamReader sr = File.OpenText(filePath))
            {
                while (!sr.EndOfStream)
                {
                    //await Task.Delay(100); // orive mushaobs
                    _result = await sr.ReadLineAsync();
                    Console.WriteLine(_result);
                    await Task.Delay(100);
                }
            }    
        }
    }
}
