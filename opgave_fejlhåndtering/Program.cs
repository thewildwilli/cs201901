using System;

namespace opgave_fejlhåndtering
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Run2();
        }

        private static void Run()
        {
            int tal1 = 0;
            int tal2 = 0;
            try
            {
                Console.WriteLine("Indtast 1. tal");
                tal1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Indtast 2. tal");
                tal2 = Forsøg(3);
                int res = tal1 + tal2;
                Console.WriteLine("resultatet er " + res);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Der er sket en fejl - {ex.Message}");
                //throw;
            }
            finally
            {

            }




        }


        private static int Forsøg(int forsøgstal)
        {
            if (forsøgstal == 0)
            {
                Console.WriteLine("Du er løbet tør for forsøg. Kontakt en administrator");
                Console.WriteLine("Tallet indlæses i stedet som 0.");
                return 0;
            }
            else
            {
                try
                {
                    int tal1 = Convert.ToInt32(Console.ReadLine());
                    return tal1;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Der er sket en fejl - {ex.Message}");
                    Console.WriteLine("Prøv igen");
                    return Forsøg(forsøgstal - 1);
                    //throw;
                }
            }
        }

        internal static void Run2()
        {
            //check om fil existerer
            try
            {
                System.IO.File.Exists("c:\temp\text.txt");
            }
            catch (Exception)
            {
                Console.WriteLine(@"Filen c:\temp\text.txt findes ikke!");
                throw;
            }
            Console.WriteLine(@"Filen c:\temp\text.txt findes!");
            // åbn fil og hent indhold, ret og gem
            try
            {
                System.IO.FileInfo file = new System.IO.FileInfo("c:\temp\text.txt");

                Console.WriteLine(System.IO.File.ReadAllText(@"c:\temp\text.txt"));

                string indhold = System.IO.File.ReadAllText(@"c:\temp\text.txt");
                Console.WriteLine("loaded");
                int tal = Convert.ToInt32(indhold);
                Console.WriteLine("converted");
                tal += 1;

                System.IO.File.WriteAllText(@"c:\temp\text.txt", Convert.ToString(tal));
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Argument exception");
                throw;
            }
            catch (FormatException)
            {
                ApplicationException ex = new ApplicationException("Indhold kan ikke konverteres til et heltal.");

            }
            catch (Exception)
            {
                throw;
            }



        }
    }
}
