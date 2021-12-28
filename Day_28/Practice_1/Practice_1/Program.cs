using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            CancellationTokenSource cts = new CancellationTokenSource();
            ParallelOptions po = new ParallelOptions();
            po.CancellationToken = cts.Token;

            Console.WriteLine("Press Any Key To Start, For Exit Press 'x'");

            var task1 = WaitingX(cts);
            CatchTask(po, cts);

        }

        static void CatchTask(ParallelOptions po, CancellationTokenSource cts)
        {

            try
            {
                CreateAndWriteToFile2(po);
            }
            catch (OperationCanceledException ex)
            {
                Console.WriteLine($"{ex.Message} is cancelled.");
            }
            finally
            {
                cts.Dispose();
            }
        }

        static void CreateAndWriteToFile2(ParallelOptions po)
        {
            int from = 1;
            int to = 11;

            Parallel.For(from, to, po, i =>
            {
                //string file = $"{i}.txt";
                //File.Create(file);
                /*StreamWriter sw = new StreamWriter(file);*///error
                while (!po.CancellationToken.IsCancellationRequested)
                {
                    //StreamWriter sw = new StreamWriter(file); //error
                    //File.AppendAllText(file,$"Task {i}"); // error
                    Console.WriteLine($"Task {i}");
                }
            });
        }

        static async Task WaitingX(CancellationTokenSource cts)
        {
            await Task.Run(() =>
            {
                Console.ReadKey();
                if (Console.ReadKey().KeyChar == 'x')
                {
                    cts.Cancel();
                }
                Console.WriteLine();
            });
        }
    }
}
