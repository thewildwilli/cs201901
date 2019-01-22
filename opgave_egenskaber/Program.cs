using System;

namespace opgave_egenskaber
{
    public class Program
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
        private int _grundlinje;

        public int Grundlinje
        {
            get
            {
                return this._grundlinje;
            }
            set
            {
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
            this._areal = (højde * grundlinje)/2;
        }

        readonly int _areal;

        public int Areal
        {
            get
            {
                return this._areal;
            }
        }
    }




}

