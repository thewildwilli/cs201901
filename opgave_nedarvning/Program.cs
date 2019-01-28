using System;
using System.Collections.Generic;

namespace opgave_nedarvning
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            TestOfPersonAndStockItem();
            //Program2.Main2();

        }


        public static void TestOfPersonAndStockItem()
        {
            Console.WriteLine("Hello World!");


            Kursist k = new Kursist() { Id = 1, Fornavn = "a", Efternavn = "efternavn"};
            k.Skriv1();
            k.Skriv2();



            Person john;
            john = new Person(fornavn: "John", efternavn: "Johnson");

            Console.WriteLine(john.FuldtNavn());

            List<int> dooooo = new List<int>();

            // problemer med Elev
            Kursist brian = new Kursist(fornavn: "Brian", efternavn: "hmm", klasselokale: "Madrid");

            Instruktør morten = new Instruktør(fornavn: "Morten", efternavn: "Bhbjk", nøgleId: 3);

            Console.WriteLine(brian.FuldtNavn());
            Console.WriteLine(morten.FuldtNavn());

            UdvidetRandom urnd = new UdvidetRandom();
            Console.WriteLine(urnd.NextBool());

            int count = 0;
            for (int i = 0; i < 10000; i++)
            {
                if (urnd.NextBool())
                {
                    count++;
                }
            }

            Console.WriteLine(count);



            try
            {
                StockItem s1 = new StockItem(0);
                StockItem s2 = new StockItem(-1);
                StockItem s3 = new StockItem(1);
            }
            catch (StockItemException ex)
            {
                Console.WriteLine("StockItem Error : " + ex.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("General Error");
            }


        }

    }







    public class Person
    {
        public int Id
        {
            get; set;
        }

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
        public Person()
        {
        }

        public Person(string fornavn, string efternavn)
        {
            this.Fornavn = fornavn;
            this.Efternavn = efternavn;
        }

        public void Skriv1()
        {
            Console.WriteLine($"Person med id {Id} og navn {FuldtNavn()}");
        }

        public virtual void Skriv2()
        {
            Console.WriteLine("den originale");
        }


    }


    internal class Elev : Person
    {
        public Elev(string fornavn, string efternavn, string klasselokale) : base(fornavn, efternavn)
        {
            this.Klasselokale = klasselokale;
        }

        public string Klasselokale
        {
            get; set;
        }





    }
    internal class Kursist : Person
    {
        public Kursist(string fornavn, string efternavn, string klasselokale) : base(fornavn, efternavn)
        {
            this.Klasselokale = klasselokale;
        }

        public Kursist() : base()
        {
        }

        public string Klasselokale
        {
            get; set;
        }

        public override void Skriv2()
        {
            Console.WriteLine("Lol overriding!!!!");
            base.Skriv2();
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


    internal class UdvidetRandom : Random
    {
        public bool NextBool()
        {
            return this.Next(0, 2) == 0 ? false : true;
        }
    }


    internal class StockItem
    {
        public int ID
        {
            get; set;
        }
        /// <summary>
        /// My summary goes here.
        /// </summary>
        /// <param name="id">My decription of the id name</param>
        public StockItem(int id)
        {
            if (id < 0)
            {
                throw new StockItemException("StockItem ID must be non-negative. Wrong ID.");
            }
            this.ID = id;
            Console.WriteLine(this.ID);
        }

    }

    /// <summary>
    /// summary of stockitemexception - inherits directly from exception
    /// </summary>
    internal class StockItemException : Exception {

        public StockItemException(string msg) : base(msg)
        {

        }
    }




}
