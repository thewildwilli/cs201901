using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace opgave_LINQ
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Noget LINQ kode- LINQ står for Language Integrated Query
            var mappe = new System.IO.DirectoryInfo(@"c:\temp");
            var filer = mappe.GetFiles("*.*", System.IO.SearchOption.AllDirectories);
            Console.WriteLine($"Antal filer i temp: {filer.Length:N0}");

            var res1 = from fil in filer
                       orderby fil.Length
                       group fil by fil.Extension into f
                       select f;

            var res2 = filer
                .OrderBy(i => i.Length)
                .GroupBy(i => i.Extension);

            Console.WriteLine($"Der findes {res1.Count()} forskellige extensions i mappen.");
            Console.WriteLine($"Der findes {res2.Count()} forskellige extensions i mappen.");

            var res3 = from fil in filer select fil;
            var res4 = filer;

            // Execution
            Console.WriteLine($"Der findes {res3.Count()} filer i mappen.");
            Console.WriteLine($"Der findes {res4.Count()} filer i mappen.");

            var res5 = (from fil in filer where fil.Extension == ".txt" select fil).ToList();
            var res6 = filer.Where(i => i.Extension == ".txt").ToList();

            Console.WriteLine($"Der findes {res5.Count()} .txt-filer i mappen.");
            Console.WriteLine($"Der findes {res6.Count()} .txt-filer i mappen.");

            var res7 = from fil in filer where fil.Extension == ".txt" select fil;
            var res8 = filer.Where(i => i.Extension == ".txt");

            Console.WriteLine($"Der findes {res7.Count()} .txt-filer i mappen.");
            Console.WriteLine($"Der findes {res8.Count()} .txt-filer i mappen.");

            // Execution
            var res9 = from fil in filer where fil.Extension == ".txt" orderby fil.FullName select fil;
            var res10 = filer.Where(i => i.Extension == ".txt").OrderBy(i => i.FullName);

            foreach (var item in res7)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine($"Der findes {res9} .txt-filer i mappen");

            foreach (var item in res9)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Der findes {res10} .txt-filer i mappen");

            foreach (var item in res10)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Gruppering");

            var res11 = from fil in filer group fil by fil.Extension into gruppe select gruppe;
            var res12 = filer.GroupBy(x => x.Extension);

            // resultat er IGrouping<string, FileInfo> - kan ses ved at holde musen over var ovenfor
            foreach (var item in res11)
            {
                Console.WriteLine("Gruppe");
                foreach (var fil in item)
                {
                    Console.WriteLine(fil.FullName);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Udfladning af lister");

            var res13 = from fil in filer group fil by fil.Extension into gruppe from r in gruppe select r;
            var res14 = filer.GroupBy(i => i.Extension).SelectMany(i => i);

            Console.WriteLine($"Res13 består af {res13.Count()} ting");
            Console.WriteLine($"Res14 består af {res14.Count()} ting");

            foreach (var item in res13)
            {
                Console.WriteLine(item.ToString());

            }

            Console.WriteLine();
            Console.WriteLine("Projecting");

            // En liste af strenge
            var res15 = from f in filer
                        select new
                        {
                            Navn = f.Name,
                            Størrelse = f.Length
                        };
            var res16 = filer.Select(f => new { Navn = f.Name, Størrelse = f.Length });

            foreach (var item in res15)
            {
                Console.WriteLine(item);
                Console.WriteLine(item.GetType());
                Console.WriteLine(item.Navn);
                Console.WriteLine(item.Størrelse);
            }

            try
            {
                Console.WriteLine($"Res15 består af {res15.Count()} ting");
                Console.WriteLine($"Res16 består af {res16.Count()} ting");
            }
            catch (Exception)
            {

                throw;
            }

            //Joining
            Console.WriteLine();
            Console.WriteLine("Joining");

            var personer = opgave_LINQ.Person.HentPersoner();
            personer.Add(new Person() { Navn = "William", IdLand = 1 });
            var lande = Land.HentLande();

            var res17 = from pers in personer
                        join land in lande
                        on pers.IdLand equals land.IdLand
                        select new
                        {
                            Navn = pers.Navn,
                            Land = land.Navn
                        };


            Console.WriteLine();
            Console.WriteLine("Experiments");

            var res18 = from land in lande
                        join pers in personer
                        on land.IdLand equals pers.IdLand
                        select land;
            //select new
            //{
            //    Navn = pers.Navn,
            //    Land = land.Navn
            //};

            foreach (var item in res18)
            {
                Console.WriteLine(item.Navn);
                Console.WriteLine(item.IdLand);
            }




        }
    }


    class Person
    {
        public string Navn
        {
            get; set;
        }
        public int IdLand
        {
            get; set;
        }
        public static List<Person> HentPersoner()
        {
            return new List<Person>() {
                new Person(){ Navn = "Mikkel", IdLand = 1 },
                new Person(){ Navn = "Mathias", IdLand = 2 },
                new Person(){ Navn = "Lene", IdLand = 3 }
            };
        }
    }

    class Land
    {
        public int IdLand
        {
            get; set;
        }
        public string Navn
        {
            get; set;
        }

        public static List<Land> HentLande()
        {
            return new List<Land>() {
                new Land() { IdLand = 1, Navn = "Danmark" },
                new Land() { IdLand = 2, Navn = "Sverige" },
                new Land() { IdLand = 3, Navn = "Norge" }
            };
        }
    }
}
