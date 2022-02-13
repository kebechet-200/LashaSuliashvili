using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Bingo
{
    internal class Program
    {
        // winning numbers list
        private static List<int> winningNumbers = new List<int>();
        private static int _players;
        private static Random rnd = new Random();
        private static int winner = 0;

        static void Main(string[] args)
        {
            CancellationTokenSource cts = new CancellationTokenSource();
            ParallelOptions po = new ParallelOptions();
            po.CancellationToken = cts.Token;

            Start(po, cts);
        }

        static void Start(ParallelOptions po, CancellationTokenSource cts)
        {
            Console.Write("Please enter the number of players : ");
            _players = Convert.ToInt32(Console.ReadLine());
            //filling lucky numbers with input values
            FillLuckyNumbers();

            try
            {
                Game(po, cts);
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine($"Player {winner} BINGOOO");
            }
        }

        static void Game(ParallelOptions po, CancellationTokenSource cts)
        {
            int from = 0; int to = _players;

            Parallel.For(from, to, po, i =>
            {
                Task.Run(() =>
                {
                    int count = winningNumbers.Count;
                    while (!po.CancellationToken.IsCancellationRequested)
                    {
                        int number = rnd.Next(1, 100);
                        if (winningNumbers.Contains(number))
                        {
                            count--;
                        }
                        if (count == 0)
                        {
                            winner = i;
                            cts.Cancel();
                        }
                    }
                });
            });
        }
        static void FillLuckyNumbers()
        {
            for (int i = 1; i <= 3; i++)
            {
                Console.Write($"Input {i} lucky number : ");
                winningNumbers.Add(Convert.ToInt32(Console.ReadLine()));
            }
        }
    }
}
