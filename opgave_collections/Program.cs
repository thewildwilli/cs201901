using System;
using System.Collections.Generic;

namespace opgave_collections
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            System.Collections.Generic.List<Person> liste = new System.Collections.Generic.List<Person>();
            var liste2 = new System.Collections.Generic.List<Person>();
            var p1 = new Person();
            var p2 = new Person();
            var p3 = new Person(navn: "Poul");

            liste.Add(p1);
            liste.Add(p2);
            liste.Add(p3);

            foreach (var item in liste)
            {
                Console.WriteLine(item.Navn);
            }


            System.Collections.Generic.Dictionary<int, Person> liste3 = new System.Collections.Generic.Dictionary<int, Person>();

            liste3.Add(0, p1);
            liste3.Add(1, p1);
            liste3.Add(2, p2);
            liste3.Add(3, p3);

            Console.WriteLine(liste3[3].Navn);


            Console.WriteLine("kort bunke");

            Bunke b = new Bunke();
            b.TilføjKort(new Kort() { Kulør = "Spar", Værdi = 2 });
            b.TilføjKort(new Kort() { Kulør = "Hjerter", Værdi = 14 });
            b.TilføjKort(new Kort() { Kulør = "Ruder", Værdi = 3 });
            b.Vis();

            var k = b.FjernKort();
            Console.WriteLine();
            Console.WriteLine(k);
            Console.WriteLine();

            b.Vis();



        }
    }


    internal class Person
    {
        public int Id
        {
            get; set;
        }

        public string Navn
        {
            get; set;
        }

        public Person(int id = 2, string navn = "Michael")
        {
            this.Id = id;
            this.Navn = navn;
        }

    }

    public class Kort
    {
        public string Kulør
        {
            get;
            set;
        }

        public int Værdi
        {
            get;
            set;
        }

        public override string ToString()
        {
            return this.Kulør + " " + this.Værdi;
        }


    }

    public class Bunke
    {
        private Stack<Kort> kortstak;


        public void TilføjKort(Kort kort)
        {
            this.kortstak.Push(kort);
        }

        public Kort FjernKort()
        {
            return this.kortstak.Pop();
        }

        public void Vis()
        {
            foreach (Kort kort in this.kortstak)
            {
                Console.WriteLine(kort);
            }
        }

        public Bunke()
        {
            this.kortstak = new Stack<Kort>();
        }

    }






}
