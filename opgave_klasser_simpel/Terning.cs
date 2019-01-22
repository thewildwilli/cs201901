using System;
using System.Collections.Generic;
using System.Text;

namespace opgave_klasser_simpel
{
    public class Terning
    {
        private static NLog.Logger log = NLog.LogManager.GetCurrentClassLogger();
        private int værdi;
        private bool snyd;
        private static System.Random rnd = new System.Random();

       

        public int Værdi
        {
            get
            {
                return this.værdi;
            }
            set
            {
                if (value < 1 || value > 6)
                {
                    log.Error("Fejl i indtastning af værdi. Ikke mellem 1 og 6.");
                    throw new FormatException("Fejl i indtastning af værdi. Ikke mellem 1 og 6.");
                    this.værdi = 1;
                }
                else
                {
                    log.Trace($"Terningværdien {this.værdi} overskrives af værdien {value}");
                    this.værdi = value;
                }
            }
        }


        public void Skriv()
        {
            Console.WriteLine(this.Værdi);
        }

        public void Ryst()
        {
            switch (this.snyd)
            {
                case true:
                    {
                        this.Værdi = 6;
                        break;
                    }
                case false:
                    {
                        this.Værdi = rnd.Next(1, 7);
                        break;
                    }
            }
        }

        public Terning()
        {
            this.Værdi = 1;
            this.snyd = false;
        }

        public Terning(bool snydeTerning)
        {
            this.Værdi = 5;
            this.snyd = snydeTerning;
            this.Ryst();
        }

        public Terning(int startøjne)
        {
            this.Værdi = startøjne;
        }


    }
}
