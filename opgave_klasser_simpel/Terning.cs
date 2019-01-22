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

        internal int Skriv()
        {
            return this.værdi;
        }

        internal int Ryst()
        {
            switch (this.snyd)
            {
                case true:
                    {
                        return 6;
                    }
                case false:
                    {
                        return rnd.Next(1, 7);
                    }
                default:
                    return 1;
            }
        }

        public Terning()
        {
            this.værdi = 1;
            this.snyd = false;
        }

        public Terning(int værdi)
        {
            this.Værdi = værdi;
        }

        public int Værdi
        {
            get => this.værdi; set => this.værdi = value;
        }
    }
}
