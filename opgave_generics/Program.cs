using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace opgave_ekstra_reflection
{
    class Program
    {
        static void Main(string[] args)
        {

            //// Noget LINQ kode- LINQ står for Language Integrated Query
            //var mappe = new System.IO.DirectoryInfo(@"c:\temp");
            //var filer = mappe.GetFiles("*.*", System.IO.SearchOption.AllDirectories);
            //Console.WriteLine($"Antal filer i temp: {filer.Length:N0}");

            //var res1 = from fil in filer
            //           orderby fil.Length
            //           group fil by fil.Extension into f
            //           select f;

            //var res2 = filer
            //    .OrderBy(i => i.Length)
            //    .GroupBy(i => i.Extension);

            //Console.WriteLine($"Der findes {res1.Count()} forskellige extensions i mappen.");
            //Console.WriteLine($"Der findes {res2.Count()} forskellige extensions i mappen.");

            // using System.Reflection;





            //opgave_ekstra_reflection.TestKlasse o = new opgave_ekstra_reflection.TestKlasse();
            //Type t = o.GetType();

            //Console.WriteLine("Felter:");
            //foreach (var item in t.GetFields())
            //    Console.WriteLine($"  {item.Name}");

            //Console.WriteLine("Egenskaber:");
            //foreach (var item in t.GetProperties())
            //    Console.WriteLine($"  {item.Name}");

            //Console.WriteLine("Instans metoder:");
            //foreach (var item in t.GetMethods(BindingFlags.Instance | BindingFlags.Public))
            //    Console.WriteLine($"  {item.Name}");


            //Console.WriteLine("Statiske metoder:");
            //foreach (var item in t.GetMethods(BindingFlags.Static | BindingFlags.Public))
            //    Console.WriteLine($"  {item.Name}");

            //Console.WriteLine("Constructors:");
            //foreach (var item in t.GetConstructors())
            //    Console.WriteLine($"  Argumenter: {item.GetParameters().Length}");


            //Console.WriteLine("bubububububu");


            //Reflection2.MinKlasse o2 = new Reflection2.MinKlasse();

            //foreach (var item in o2.GetType().GetCustomAttributes())
            //    Console.WriteLine(item.ToString());

            //Console.WriteLine("bubububububu");

            //foreach (var m in o2.GetType().GetMethods())
            //    foreach (var a in m.GetCustomAttributes())
            //        Console.WriteLine(a.ToString());

            Dictionary<int, string> StatusKoder = new Dictionary<int, string>();
            StatusKoder.Add(0, "IkkeAngivet");
            StatusKoder.Add(1, "Ligegyldigt");
            StatusKoder.Add(2, "IkkeVigtigt");
            StatusKoder.Add(4, "Vigtigt");
            StatusKoder.Add(8, "MegetVigtig");

            // Automatisk generering af enum
            CodeCompileUnit unit = new CodeCompileUnit();





        }
    }


//    public class TestKlasse
//    {
//        public int Id;
//        public string Navn
//        {
//            get; set;
//        }
//        public void Test()
//        {
//        }
//        public int Test1() => this.Id;
//        public string Test2(int a, char b) => this.Navn?.ToUpper() + new string(b, a).ToUpper();
//        public static void Test3()
//        {
//        }
//        public TestKlasse()
//        {
//        }

//        public TestKlasse(int id, string navn)
//        {
//            this.Id = id;
//            this.Navn = navn;
//        }
//    }
//}


//namespace Reflection2
//{
//    [MinAttribut1]
//    public class MinKlasse
//    {

//        [MinAttribut2(1, 2)]
//        public void Test()
//        {
//        }
//    }


//    public class MinAttribut1 : Attribute
//    {
//    }

//    public class MinAttribut2 : Attribute
//    {

//        private int a;
//        private int b;

//        public MinAttribut2()
//        {

//        }

//        public MinAttribut2(int a = 0, int b = 1)
//        {
//            this.a = a;
//            this.b = b;
//        }
//    }
//}
