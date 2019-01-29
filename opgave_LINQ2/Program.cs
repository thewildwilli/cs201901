using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave_LINQ2
{
    public class Program
    {
        internal static void Main(string[] args)
        {
            var r = new PersonNuGetPackage.PersonRepositoryRandom();
            var people = r.Get10People();

            foreach (var person in people)
            {
                Console.WriteLine(person.Name);
            }

            //Sorter og udskriv efter navn og udskriv igen
            Console.WriteLine();
            Console.WriteLine("Opgave 0");
            var res0li = from person in people
                         orderby person.Name
                         select person.Name;
            var res0la = people.OrderBy(i => i.Name).Select(i => i.Name);
            foreach (var person in res0la)
            {
                Console.WriteLine(person);
            }


            //Sorter og udskriv efter gender og så navn
            Console.WriteLine();
            Console.WriteLine("Opgave 1");

            var res1li = from p in people
                         orderby p.Gender, p.Name
                         select p;
            var res1la = people.OrderBy(i => i.Gender).ThenBy(i => i.Name);

            foreach (var item in res1li)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Gender);
            }
            Console.WriteLine();
            foreach (var item in res1la)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Gender);
            }

            //Filtre og udskriv således, at der kun vises personer hvor height< 170
            Console.WriteLine();
            Console.WriteLine("Opgave 2");

            var res2li = from p in people
                         where p.Height < 170
                         select p;

            var res2la = people.Where(i => i.Height < 170);
            foreach (var item in res2li)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Height);
            }
            Console.WriteLine();
            foreach (var item in res2la)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Height);
            }

            //Filtre og udskriv således, at der kun vises personer hvor height = < 170, isHealthy = true
            Console.WriteLine();
            Console.WriteLine("Opgave 3");

            var res3li = from p in people
                         where (p.Height < 170 && p.IsHealthy == true)
                         select p;

            var res3la = people.Where(i => i.Height < 170 && i.IsHealthy == true);

            foreach (var item in res3li)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Height);
                Console.WriteLine(item.IsHealthy);
            }


            //Gruppér efter gender og udskriv hver gruppe(husk – der er tale om tilfældige navn / gender mv)
            Console.WriteLine();
            Console.WriteLine("Opgave 4");

            var res4li = from p in people
                         group p by p.Gender into gruppe
                         select gruppe;
            var res4la = people
                .GroupBy(
                    (PersonNuGetPackage.Person i) =>
                    {
                        return i.Gender;
                    }
                );

            foreach (var item in res4la)
            {
                Console.WriteLine(item);
                foreach (var per in item)
                {
                    Console.WriteLine(per.Gender);
                }

            }

            //Sorter og udskriv navn – men der skal kun returneres et anonymt objekt med navn og height
            Console.WriteLine();
            Console.WriteLine("Opgave 5");

            var res5li = from p in people select new { navn = p.Name, height = p.Height };
            var res5la = people.Select(i => new { navn = i.Name, height = i.Height });

            foreach (var item in res5li)
            {
                Console.WriteLine(item.navn);
                Console.WriteLine(item.height);

            }


            //Grupper og sorter efter height således, at der skabes grupper fra 160 - 170, 170 - 180, 180 - 190, 190 - 200, 200 - 210.Den svær..kig i løsningen og søg evt på nettet.
            Console.WriteLine();
            Console.WriteLine("Opgave 6");
            int[] range = { 160, 170, 180, 190, 200, 210, 220 };

            //var res6la = range.Select(r => new { people.})
            var res6la = people.OrderBy(i => i.Height).GroupBy(x => range.FirstOrDefault(ran => ran > x.Height));

            foreach (var item in res6la)
            {
                Console.WriteLine(item);
                foreach (var per in item)
                {
                    Console.WriteLine(per.Height);
                }

            }

            // Hold console åben ved debug
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }
    }
}
