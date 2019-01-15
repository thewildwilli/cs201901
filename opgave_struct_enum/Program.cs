using System;

namespace opgave_struct_enum
{
    class Program
    {
        static void Main(string[] args)
        {

            SpilleKort s1 = new SpilleKort();
            s1.Værdi = 2;
            s1.Kulør = Kulør.Spar;
            Console.WriteLine($"{s1.Kulør} {s1.Værdi}");

            SpilleKort s2 = new SpilleKort();
            s2.Værdi = 10;
            s2.Kulør = Kulør.Hjerter;
            Console.WriteLine($"{s2.Kulør} {s2.Værdi}");


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }



        }
    }


    struct SpilleKort
    {
        public int Værdi;
        public Kulør Kulør;

        //public void Spillekort()
        //{
        //    Værdi = 1;
        //    Kulør = KortKulør.Hjerter;
        //}


    }


}
