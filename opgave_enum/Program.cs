using System;

namespace opgave_enum
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // opgavelink: https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/Variabler-Enum/Opgave/index.md


            Console.WriteLine(Math.PI.GetType());

            Person p1 = new Person();
            p1.Navn = "Will";
            p1.Alder = 5;
            p1.Skriv();



            //int kort1Værdi = 2;
            Kulør kort1Kulør = Kulør.Hjerter;

            //int kort2Værdi = 2;
            //Kulør kort2Kulør = Kulør.Ruder;

            Console.WriteLine(kort1Kulør);
            Console.WriteLine(System.Convert.ToInt32(kort1Kulør));



        }
    }

    public struct Person
    {
        public string Navn;
        public int Alder;

        public void Skriv()
        {
            Console.WriteLine($"Jeg hedder {this.Navn} og er {this.Alder} år gammel.");
        }
    }
}
