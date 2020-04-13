using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //var listinter = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //foreach (var i in listinter)
            //{
            //    int temp = i;
            //    Task.Factory.StartNew(() => Console.WriteLine(temp));
            //}

            //for(int i = 0; i < listinter.Count;i++)
            //{
            //    int temp = i;
            //    Task.Factory.StartNew(() => Console.WriteLine(temp));
            //}

            for (int i = 0; i < 10; i++)
            {
                int toCaptureI = i;
                Task.Factory.StartNew(() => Console.WriteLine(toCaptureI));
            }
            Console.ReadLine();

            //Console.ReadLine();
        }
    }
}
