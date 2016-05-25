using System;
using System.Threading;

namespace ProgrammingNetFrameworkStudy.chap27
{
    public class CancellationAfterDemo
    {
        public static void Main()
        {
            CancellationTokenSource cts = new CancellationTokenSource();
            
            // 2s後に処理を終了する
            cts.CancelAfter(2000);

            // キャンセル時に実行される処理
            cts.Token.Register(() => Console.WriteLine("hogehoge"));

            ThreadPool.QueueUserWorkItem(o => Count(cts.Token, 1000));

//            Console.WriteLine("Press <Enter> to cancel the operation.");
//            Console.ReadLine();
//
//            cts.Cancel();

            Console.ReadLine();
        }

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