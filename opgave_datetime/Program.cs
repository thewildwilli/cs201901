using System;

namespace opgave_datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);
            d1 = d1.AddDays(10);
            Console.WriteLine(d1);
            d1 = d1.AddMinutes(20);
            DateTime d2 = d1;
            Console.WriteLine(d1);
            d1 = d1.AddMonths(-1);
            DateTime d3 = d1;
            Console.WriteLine(d1);
            Console.WriteLine((d1.Subtract(d2)).Days);
            TimeSpan t2 = new TimeSpan(16, 0, 0);
            TimeSpan t3 = new TimeSpan(0, 30, 0);
            TimeSpan t4 = t2 - t3;  
            TimeSpan t5 = t2 + t3;
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);

						Console.WriteLine("Woo hooo hello world");

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
