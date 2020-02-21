using System;
using System.Threading;

namespace printingdot
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Thread.Sleep(1000);
                Console.Write(".");
            }
        }
    }
}
