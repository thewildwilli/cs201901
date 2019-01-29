using System;
using System.Collections.Generic;

namespace opgave_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            opgave_interface2.Interface_compare_program.Main2();




            //List<IDbFunktioner> begge = new List<IDbFunktioner>();
            //begge.Add(new Hund());
            //begge.Add(new Ubåd());

            //foreach (var item in begge)
            //{
            //    item.Gem();
            //}











            // Test af shadowing (new method)
            //BaseClass a = new BaseClass();
            //Console.WriteLine(a.GetMethodOwnerName());
            //ChildClass b = new ChildClass();
            //Console.WriteLine(b.GetMethodOwnerName());
            //SecondChild c = new SecondChild();
            //Console.WriteLine(c.GetMethodOwnerName());

            //List<BaseClass> myList= new List<BaseClass>();
            //myList.Add(a);
            //myList.Add(b);
            //myList.Add(c);

            //foreach (var item in myList)
            //{
            //    Console.WriteLine("-------------------New item");
            //    Console.WriteLine("Skriver den forskellig ting her? "+item.GetMethodOwnerName());
            //    Console.WriteLine(item is BaseClass);
            //    Console.WriteLine(item is ChildClass);
            //    Console.WriteLine(item is SecondChild);
            //    if (item is ChildClass)
            //    {
            //        ChildClass replica = (ChildClass) item;
            //        //ChildClass replica = item as ChildClass;
            //        Console.WriteLine(replica.GetMethodOwnerName());
            //    }
            //    else
            //    {
            //        Console.WriteLine("Not a childclass");
            //    }
            //    Console.WriteLine(item.GetMethodOwnerName());
            //}

        }
    }


    public class Hund : IDbFunktioner
    {
        public string Navn
        {
            get; set;
        }

        public void Gem()
        {
            Console.WriteLine("Gemmer hund...");
        }
        public void Gem2() { }
    }

    public class Ubåd : IDbFunktioner
    {
        public int Nummer
        {
            get; set;
        }

        public double Turbine
        {
            get; set;
        }

        public void Gem()
        {
            Console.WriteLine("Gemmer ubåd...");
        }
        public void Gem2() { }
    }

    public interface IDbFunktioner
    {
        void Gem();
        void Gem2();



    }

    public class BaseClass
    {
        public virtual string GetMethodOwnerName()
        {
            return "Base Class";
        }

    }
    public class ChildClass : BaseClass
    {
        public override string GetMethodOwnerName()
        {
            return "ChildClass";
        }
    }
    public class SecondChild : ChildClass
    {
        public new string GetMethodOwnerName()
        {
            return "Second level Child";
        }
    }

    public class ThirdChild : SecondChild
    {

    }
}
