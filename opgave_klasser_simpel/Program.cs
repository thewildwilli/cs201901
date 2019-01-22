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


            //Test af appsettings
            Console.WriteLine("Test af appsettings");
            AppSettings appSettings = AppSettings.HentAppSettings();
            Console.WriteLine(appSettings.AppId);   // 0
            appSettings.AppId = 10;
            Console.WriteLine(appSettings.AppId);   // 10
            appSettings = AppSettings.HentAppSettings();
            Console.WriteLine(appSettings.AppId);   // 10

            appSettings.AppId = 1;


            // test af beregninger
            Console.WriteLine("Test af beregninger");
            Console.WriteLine(Beregninger.LægSammen(2,3));
            Console.WriteLine(Beregninger.TrækFra(3,1));



            Console.WriteLine("Terning halløj");
            // kode relateret til terningerne
            Terning t1 = new Terning();
            t1.Skriv();
            t1.Ryst();
            t1.Skriv();

            Terning t2 = new Terning(true);
            t2.Skriv();
            t2.Ryst();
            t2.Skriv();

            Terning t3 = new Terning();

            Console.WriteLine("situationen er nu:");
            t1.Skriv();
            t2.Skriv();
            t3.Skriv();

            t1.Ryst();

            Console.WriteLine("situationen er nu:");

            t1.Skriv();
            t2.Skriv();
            t3.Skriv();

            Console.WriteLine("t1 er t3");
            t1 = t3;

            Console.WriteLine("situationen er nu:");
            t1.Skriv();
            t2.Skriv();
            t3.Skriv();

            Console.WriteLine("situationen er nu:");
            t1.Ryst();
            Console.WriteLine("t1 rystes");
            t1.Skriv();
            t2.Skriv();
            t3.Skriv();




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
