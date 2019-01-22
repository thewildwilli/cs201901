using System;
using opgave_klasser_simpel;

namespace opgave_egenskaber
{
    public class Program_egenskab
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Vare v = new Vare();

            v.Navn = "navnet";
            string s = "";
            s = v.Navn;

            v.Pris = 10;
            double d = 0;
            d = v.Pris;

            d = v.PrisMedMoms(d);


            Console.WriteLine("test af trekant klassen");
            Trekant myTriangle = new Trekant(5, 7);
            Console.WriteLine("trekenat oprettet");
            int a = myTriangle.Areal;
            Console.WriteLine("Gemt areal i variablen a");
            Console.WriteLine(a);





            Console.WriteLine("Test af Person klassen");
            Person poul = new Person("Poul", "Poulsen");
            string fuldenavn = poul.Fornavn + poul.Efternavn;
            Console.WriteLine(fuldenavn);
            Console.WriteLine(poul.FuldtNavn());



            //Test af terning klassen
            Console.WriteLine("Test af klassen terning.");
            opgave_klasser_simpel.Terning terning = new opgave_klasser_simpel.Terning(1);
            terning.Skriv();
            terning.Ryst();
            terning.Skriv();

            terning.Værdi = 7;


            // Hold console åben ved debug
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }
    }




    internal class Vare
    {
        private static NLog.Logger log = NLog.LogManager.GetCurrentClassLogger();

        private string _navn;

        public string Navn
        {
            get
            {
                Console.WriteLine($"Aflæser et navn.");
                return this._navn;
            }
            set
            {
                Console.WriteLine($"Ændrer et navn.");
                this._navn = value;
            }
        }
        private double _pris;

        public double Pris
        {
            get
            {
                log.Trace($"Aflæser en pris");
                Console.WriteLine($"Aflæser en pris");
                return this._pris;
            }
            set
            {
                log.Trace($"Ændrer en pris");
                Console.WriteLine($"Ændrer en pris");
                this._pris = value;
            }
        }

        public Vare()
        {

        }

        public Vare(string navn, double pris)
        {
            this._navn = navn;
            this._pris = pris;
        }

        public double PrisMedMoms(double pris)
        {
            log.Trace("Sample trace message");
            log.Debug("Sample debug message");
            log.Info("Sample informational message");
            log.Warn("Sample warning message");
            log.Error("Sample error message");
            log.Fatal("Sample fatal error message");


            return pris * 1.25;
        }
    }


    internal class Trekant
    {
        private static NLog.Logger log = NLog.LogManager.GetCurrentClassLogger();



        private int _grundlinje;

        public int Grundlinje
        {
            get
            {
                return this._grundlinje;
            }
            set
            {
                log.Trace("Modifying the grundlinje value.");
                this._grundlinje = value;
            }
        }

        private int _højde;

        public int Højde
        {
            get
            {
                return this._højde;
            }
            set
            {
                this._højde = value;
            }
        }

        public Trekant(int grundlinje = 0, int højde = 0)
        {
            this._grundlinje = grundlinje;
            this._højde = højde;
            this._areal = (højde * grundlinje) / 2;
        }

        readonly int _areal;

        public int Areal
        {
            get
            {
                log.Trace($"Beder om Areal-værdien, som er {this._areal} baseret på en højde på {this._højde} og en grundlinje på {this._grundlinje}.");
                return this._areal;
            }
        }
    }





    public class Person
    {
        private static NLog.Logger log = NLog.LogManager.GetCurrentClassLogger();

        public string Fornavn
        {
            get; set;
        }


        private string _efternavn;

        public string Efternavn
        {
            get
            {
                return this._efternavn;
            }
            set
            {
                if (value.Length <= 3)
                    this._efternavn = value;
                else
                {
                    this._efternavn = "longLastName";
                }
            }
        }

        public string FuldtNavn()
        {
            return $"{this.Fornavn} {this.Efternavn}";
        }


        public Person(string fornavn, string efternavn)
        {
            log.Error("Nogen føder en person.");
            this.Efternavn = efternavn;
            this.Fornavn = fornavn;
        }

    }




}

