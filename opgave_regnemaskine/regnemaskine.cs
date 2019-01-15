using System;

namespace opgave_regnemaskine
{
    class regnemaskine
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("indtast første tal");
                string tal1 = Console.ReadLine();
                if (tal1 == "")
                {
                    tal1 = "0";
                }
                Console.WriteLine("indtast andet tal");
                string tal2 = Console.ReadLine();
                if (tal2 == "")
                {
                    tal2 = "0";
                }
                double t1 = System.Convert.ToDouble(tal1);
                double t2 = System.Convert.ToDouble(tal2);
                Console.WriteLine("Resultatet er");
                Console.WriteLine((t1 + t2).ToString("N2"));
            }

            System.DateTime c = new DateTime(1, 1, 15);
            Console.WriteLine(c);
            Console.WriteLine(System.DateTime.Now.ToLongTimeString());
            Console.WriteLine(System.DateTime.Now.Millisecond);

            for (int i = 0; i < 1000000; i++)
            {
                Console.Write("");
            }
            Console.WriteLine(System.DateTime.Now.ToLongTimeString());
            Console.WriteLine(System.DateTime.Now.Millisecond);



            {
                char a = '1';
                Console.WriteLine(Convert.ToInt32(a));

                Console.WriteLine("backslash \\ ");
            }

            {

            // Stopur
            System.Diagnostics.Stopwatch s = new System.Diagnostics.Stopwatch();
            s.Start();
            string a = "";
            for (int i = 0; i < 50000; i++)
            {
                a += "*";
            }
            s.Stop();
            Console.WriteLine($"ms = {s.ElapsedMilliseconds}");

            }








            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }
    }
}
