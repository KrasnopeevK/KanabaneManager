using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace StressTest
{
    class Go
    {
        private long _totalTime = 0;
        private int _totalFails = 0; 
        public async Task Start()
        {
            Stopwatch sw = new Stopwatch();
            var requester = new Requester("https://localhost:44327/employees");
            var totalRequest = 0;
            sw.Start();
            while (10000 > totalRequest++)
            {
                var result = await Task.Run(() => requester.StartTest());
                _totalTime += result.Item1;
                _totalFails += result.Item2;
            }
            sw.Stop();

            Console.WriteLine("Query address = /employees");
            Console.WriteLine("Total queries: 10000");
            Console.WriteLine($"Testing time, ms  = {sw.ElapsedMilliseconds}");
            Console.WriteLine($"Total requests time, ms = {_totalTime}");
            Console.WriteLine($"Total fails of request = {_totalFails}");
            Console.WriteLine($"RPS = {10000/(_totalTime/1000)}");
        }
    }
    class Program
    {
        
        static async Task Main(string[] args)
        {
           await new Go().Start();

           Console.ReadKey();
        }

        
    }
}