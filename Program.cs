using StackExchange.Redis;
using System.Runtime.CompilerServices;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.Diagnostics;

namespace BasicTest
{
    static class Program
    {
        static void Main(string[] args)
        {
            var endpoint = args[0];
            Console.WriteLine($"Connecting to {endpoint}...");
            using (var conn = ConnectionMultiplexer.Connect($"{endpoint}:6379"))
            {
                // Console.WriteLine($"Connected to {endpoint}");

                // var db = conn.GetDatabase();

                // RedisKey key = Me();
                // db.KeyDelete(key);
                // db.StringSet(key, "abc");

                // var exceptions = new ConcurrentBag<Exception>();
                // var numberConcurrency = int.Parse(args[1]);

                // Parallel.For(1, numberConcurrency, (i) =>
                // {
                //     int requestId = Interlocked.Increment(ref AndReaderEventSource.NextId);
                //     AndReaderEventSource.Logger.StartRequest(requestId);
                //     try
                //     {
                //         var sw = new Stopwatch();
                //         sw.Start();
                //         conn.GetDatabase().StringGet(key);
                //         sw.Stop();
                //         Console.WriteLine(sw.ElapsedMilliseconds + " ms");
                //         PrintThreadPoolStats();
                //     }
                //     catch (Exception ex)
                //     {
                //         exceptions.Add(ex);
                //     }
                //     AndReaderEventSource.Logger.StopRequest(requestId);
                // });

                // foreach (var ex in exceptions)
                // {
                //     //Console.WriteLine(ex.ToString());
                // }
                // Console.WriteLine($"# of exceptions: {exceptions.Count}");
            }
        }

        // internal static void PrintThreadPoolStats()
        // {
        //     int maxIoThreads, maxWorkerThreads;
        //     ThreadPool.GetMaxThreads(out maxWorkerThreads, out maxIoThreads);

        //     int freeIoThreads, freeWorkerThreads;
        //     ThreadPool.GetAvailableThreads(out freeWorkerThreads, out freeIoThreads);

        //     int minIoThreads, minWorkerThreads;
        //     ThreadPool.GetMinThreads(out minWorkerThreads, out minIoThreads);

        //     int busyIoThreads = maxIoThreads - freeIoThreads;
        //     int busyWorkerThreads = maxWorkerThreads - freeWorkerThreads;

        //     //var iocp = $"IO: (Busy={busyIoThreads},Free={freeIoThreads},Min={minIoThreads},Max={maxIoThreads})";
        //     //var worker = $"WORKER: (Busy={busyWorkerThreads},Free={freeWorkerThreads},Min={minWorkerThreads},Max={maxWorkerThreads})";
        //     var worker = $"WORKER: (Busy={busyWorkerThreads},Min={minWorkerThreads})";
        //     //System.Console.WriteLine(iocp);
        //     System.Console.WriteLine(worker);
        // }

        // internal static string Me([CallerMemberName] string caller = null)
        // {
        //     return caller;
        // }
    }
}
