using System;
using System.Collections.Generic;

namespace opgave_nedarvning
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Person john;
            john = new Person(fornavn: "John", efternavn: "Johnson");

            Console.WriteLine(john.FuldtNavn());

            List<int> dooooo = new List<int>();

            // problemer med Elev
            Elev brian = new Elev(fornavn: "Brian", efternavn: "hmm");


        }
    }







    public class Person
    {
        public string Fornavn
        {
            get; set;
        }

        public string Efternavn
        {
            get; set;
        }

        public string FuldtNavn()
        {
            return $"{this.Fornavn} {this.Efternavn}";
        }

        public Person(string fornavn, string efternavn)
        {
            this.Fornavn = fornavn;
            this.Efternavn = efternavn;
        }
    }


    internal class Elev : Person
    {
        public Elev(string fornavn, string efternavn) : base(fornavn, efternavn)
        {
        }

        public string Klasselokale
        {
            get; set;
        }





    }

    internal class Instruktør : Person
    {
        public Instruktør(string fornavn, string efternavn, int nøgleId) : base(fornavn, efternavn)
        {
            this.NøgleId = nøgleId;
        }

        public int NøgleId
        {
            get; set;
        }



    }


}
