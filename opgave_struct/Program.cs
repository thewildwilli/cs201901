using System;

namespace opgave_struct
{
    class Program
    {
        static void Main(string[] args)
        {
            //opgave her: https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/Variabler_Struct/Opgave/index.md

            Vare v1 = new Vare();
            v1.Id = 1;
            v1.Navn = "Vare #1";
            v1.Beskrivelse = "Min beskrivelse til #1";
            v1.Pris = 100;
            Console.WriteLine($"{v1.Navn} koster {v1.Pris:N2}");

            Vare v2 = new Vare();
            v2.Id = 2;
            v2.Navn = "Vare #2";
            v2.Beskrivelse = "Min beskrivelse til #2";
            v2.Pris = 200;
            Console.WriteLine($"{v2.Navn} koster {v2.Pris:N2}");

            Vare v2Kopi = v2;
            Console.WriteLine($"{v2Kopi.Navn} koster {v2Kopi.Pris:N2}");





            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }



        public struct Vare
        {
            public int Id;
            public string Navn;
            public string Beskrivelse;
            public double Pris;
            public double Vægt;
            public bool Tyverifare;

        }

    }
}
