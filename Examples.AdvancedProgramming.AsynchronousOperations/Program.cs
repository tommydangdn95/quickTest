using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Examples.AdvancedProgramming.AsynchronousOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int threadId;
            AsyncDemo ad = new AsyncDemo();
            AsyncMethodCaller caller = ad.TestMethod;

            IAsyncResult result = caller.BeginInvoke(3000, out threadId, null, null);

            Thread.Sleep(0);
            Console.WriteLine("Main thread {0} does some work.", Thread.CurrentThread.ManagedThreadId);

            result.AsyncWaitHandle.WaitOne();

            string returnValue = caller.EndInvoke(out threadId, result);


            result.AsyncWaitHandle.Close();


            Console.WriteLine("The call executed on thread {0}, with return value \"{1}\".",
                threadId, returnValue);

            Console.ReadLine();
        }
    }
}
