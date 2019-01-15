using System;

namespace opgave_enum
{
    public class Program
    {
        static void Main(string[] args)
        {
            // opgavelink: https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/Variabler-Enum/Opgave/index.md


            Console.WriteLine(Math.PI.GetType());

            Person p1 = new Person();
            p1.Navn = "Will";
            p1.Alder = 5;
            p1.Skriv();


        }
    }

    public enum Kulør : byte
    {
        Spar, // = 0
        hjerter, // =1
        Ruder, // = 2
        Klør // = 3
    }

    public struct Person
    {
        public string Navn;
        public int Alder;

        public void Skriv()
        {
            Console.WriteLine($"Jeg hedder {Navn} og er {Alder} år gammel.");
        }
    }
}
