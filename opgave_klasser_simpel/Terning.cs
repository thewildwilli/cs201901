using System;
using System.Collections.Generic;
using System.Text;

namespace opgave_klasser_simpel
{
    public class Terning
    {
        private int værdi;
        private bool snyd;
        private static System.Random rnd = new System.Random();

        internal void Skriv()
        {
            Console.WriteLine(this.værdi);
        }

        internal void Ryst()
        {
            switch (this.snyd)
            {
                case true:
                    {
                        this.værdi = 6;
                        break;
                    }
                case false:
                    {
                        this.værdi = rnd.Next(1, 7);
                        break;
                    }
            }
        }

        public Terning()
        {
            this.værdi = 1;
            this.snyd = false;
        }

        public Terning(bool snydeTerning)
        {
            this.værdi = 5;
            this.snyd = snydeTerning;
        }

        public int Værdi
        {
            get => this.værdi; set => this.værdi = value;
        }
    }
}
