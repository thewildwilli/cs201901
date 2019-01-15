using System;

namespace opgave_flow
{
    class Program
    {
        static void Main(string[] args)
        {

            

            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    if (i*j > 53)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    string tal = (i * j).ToString();

                    Console.Write(tal.PadLeft(4));
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine("\r\n");
            }







            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
