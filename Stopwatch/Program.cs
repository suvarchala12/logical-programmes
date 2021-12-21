// See https://aka.ms/new-console-template for more information
namespace Stopwatch
{
    using System;
    using System.Diagnostics;
    using System.Threading;
    class Program
    {
        static void Main(string[] args)
        {
            //create new stopwatch
            Stopwatch Stopwatch = new Stopwatch();
            Stopwatch.Start();
            for (int i=1;i<=1;i++)
            {
                Console.WriteLine("HI");
            }
            //stoptiming
            Stopwatch.Stop();
            Console.WriteLine("Time Elapsed:{0}", Stopwatch.Elapsed);
            Console.ReadLine();
        }
    }
}
