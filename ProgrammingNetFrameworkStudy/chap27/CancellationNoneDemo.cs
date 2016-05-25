using System;
using System.Threading;

namespace ProgrammingNetFrameworkStudy.chap27
{
    public class CancellationNoneDemo
    {
//        public static void Main()
//        {
//            CancellationTokenSource cts = new CancellationTokenSource();
//
//            ThreadPool.QueueUserWorkItem(o => Count(CancellationToken.None, 1000));
//
//            Console.WriteLine("Press <Enter> to cancel the operation.");
//            Console.ReadLine();
//
//            cts.Cancel();
//
//            Console.ReadLine();
//        }

        private static void Count(CancellationToken token, int countTo)
        {
            for (int count = 0; count < countTo; count++)
            {
                if (token.IsCancellationRequested)
                {
                    Console.WriteLine("count is cancelled.");
                    break;
                }

                Console.WriteLine(count);
                Thread.Sleep(200);
            }

            Console.WriteLine("count is done.");
        }
    }
}