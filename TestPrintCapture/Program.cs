using System;
using System.Threading.Tasks;

namespace TestPrintCapture
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                int toCaptureI = i;
                Task.Factory.StartNew(() => Console.WriteLine(toCaptureI));
            }
            Console.ReadLine();
        }
    }
}
