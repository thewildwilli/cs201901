using System;
using System.Collections.Generic;

namespace opgave_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            BaseClass a = new BaseClass();
            Console.WriteLine(a.GetMethodOwnerName());
            ChildClass b = new ChildClass();
            Console.WriteLine(b.GetMethodOwnerName());
            SecondChild c = new SecondChild();
            Console.WriteLine(c.GetMethodOwnerName());

            List<BaseClass> myList= new List<BaseClass>();
            myList.Add(a);
            myList.Add(b);
            myList.Add(c);

            foreach (var item in myList)
            {
                Console.WriteLine("-------------------New item");
                Console.WriteLine("Skriver den forskellig ting her? "+item.GetMethodOwnerName());
                Console.WriteLine(item is BaseClass);
                Console.WriteLine(item is ChildClass);
                Console.WriteLine(item is SecondChild);
                if (item is ChildClass)
                {
                    ChildClass replica = (ChildClass) item;
                    //ChildClass replica = item as ChildClass;
                    Console.WriteLine(replica.GetMethodOwnerName());
                }
                else
                {
                    Console.WriteLine("Not a childclass");
                }
                Console.WriteLine(item.GetMethodOwnerName());
            }


            Object o = 5;
        }
    }


    public class Hund
    {
        public string Navn
        {
            get; set;
        }

    }

    public class Ubåd
    {
        public int Nummer
        {
            get; set;
        }

        public double Turbine
        {
            get; set;
        }


    }

    public interface IDbFunktioner
    {

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
