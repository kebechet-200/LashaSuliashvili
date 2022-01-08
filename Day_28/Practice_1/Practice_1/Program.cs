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

            // task which is depend on 'x'
            CancelTask(cts);

            // task for writing into file 
            WriteInFile(po, cts);
        }


        static void CancelTask(CancellationTokenSource cts)
        {
            Task.Factory.StartNew(() =>
            {
                if (Console.ReadKey().KeyChar == 'x')
                {
                    cts.Cancel();
                }
            });
        }

        static void WriteInFile(ParallelOptions po, CancellationTokenSource cts)
        {
            try
            {
                int from = 1;
                int to = 11;
                Parallel.For(from, to, po, i =>
                {
                    while (!po.CancellationToken.IsCancellationRequested)
                        using (StreamWriter sw = new StreamWriter($"{i}.txt", true))
                        {
                            Task.Delay(i * 100);
                            sw.WriteLine($"Task {i}");
                        }

                });
            }
            catch (OperationCanceledException ex)
            {
                Console.WriteLine($"\n{ex.Message}");
            }
            finally
            {
                cts.Dispose();
            }
        }
    }
}
