using System;
using System.Threading;

namespace ProgrammingNetFrameworkStudy.chap27
{
    public class CancellationRegisterDemo
    {
//        public static void Main()
//        {
//            var cts1 = new CancellationTokenSource();
//            cts1.Token.Register(() => Console.WriteLine("cts1 canceled"));
//
//            var cts2 = new CancellationTokenSource();
//            cts2.Token.Register(() => Console.WriteLine("cts2 canceled"));
//
//            var linkedCts = CancellationTokenSource.CreateLinkedTokenSource(cts1.Token, cts2.Token);
//            linkedCts.Token.Register(() => Console.WriteLine("linked cts canceled"));
//
//            cts2.Cancel();
//
//            Console.WriteLine("cts1 canceled={0}, cts2 canceled={1}, linkedCts canceled={2}",
//                cts1.Token.IsCancellationRequested, cts2.Token.IsCancellationRequested,
//                linkedCts.Token.IsCancellationRequested);
//        }
    }
}