using System;
using System.Collections.Generic;

namespace TestChildTask
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            var startDate = new DateTime(now.Year, now.Month, 1);
            var endDate = startDate.AddMonths(1).AddDays(-1);
            var formatDate = startDate.ToString("yyyy-MM-ddTHH:mm:ss");
            var formatDateEnd = endDate.ToString("yyyy-MM-ddTHH:mm:ss");

            var today = DateTime.Today;
            var month = new DateTime(2020, 1, 1);
            var first = month.AddMonths(-1);
            var last = month.AddDays(-1);
            //List<int> list = new List<int> { 1, 2, 3, };
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}
        }
    }
}
