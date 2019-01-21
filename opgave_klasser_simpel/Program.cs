using System;

namespace opgave_klasser_simpel
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Person william = new Person("William", "larsen", 27);

            Console.WriteLine(william.FuldtNavn());
            william.PrintData();

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.WriteLine("something something.........");
                Console.ReadKey();
            }

            Person villads = new Person();

            villads.PrintData();


        }
    }







    internal class Person
    {
        private string Fornavn
        {
            get; set;
        }
        private string efternavn;
        private int Alder
        {
            get; set;
        }

        private int fødselsår;
        public string FuldtNavn()
        {
            return $"{this.Fornavn} {this.efternavn}";
        }

        public void EstimerAlder()
        {
            this.Alder = DateTime.Now.Year - this.fødselsår;
        }

        public Person()
        {
            this.Fornavn = "Vil";
            this.efternavn = "Lar";
        }
        public Person(string fornavn, string efternavn, int fødselsÅr)
        {
            this.Fornavn = fornavn;
            this.efternavn = efternavn;
            this.fødselsår = fødselsÅr;
            this.EstimerAlder();
        }

        public void PrintData()
        {
            Console.WriteLine(this.Fornavn);
            Console.WriteLine(this.efternavn);
            Console.WriteLine(this.Alder);
            Console.WriteLine(this.fødselsår);
        }
    }




}
