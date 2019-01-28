using System;
using System.Collections.Generic;
using System.Text;

namespace opgave_nedarvning
{
    public class Program2
    {
        public static void Main2()
        {
            Console.WriteLine("Hello terning world");


            Terning almTerning = new Terning();

            LudoTerning ludoTerning = new LudoTerning();

            for (int i = 0; i < 15; i++)
            {

                Console.WriteLine("Vi skriver");
                almTerning.Skriv();
                ludoTerning.Skriv();
                Console.WriteLine(String.Format("Er Ludoterningen en stjerne?: {0}", ludoTerning.ErStjerne()));

                almTerning.Ryst();
                ludoTerning.Ryst();

            }



            Faktura myFaktura = new Faktura();

            myFaktura.Kunde = "Poul";
            myFaktura.Dato = DateTime.Now;
            myFaktura.Nr = 11;
            Console.WriteLine(myFaktura);


            List<Dyr> dyreListe = new List<Dyr>();
            //dyreListe.Add(new Dyr() { Navn = "Tigerdyr" });
            dyreListe.Add(new Hund() { Navn = "Vuffer" });
            dyreListe.Add(new Kat() { Navn = "Misser" });
            for (int i = 0; i < 5; i++)
            {
                dyreListe.Add(Dyr.TilfældigtDyr());
            }


            foreach (var dyr in dyreListe)
            {
                Console.WriteLine(dyr.SigNoget());
            }

        }


    }

    public class Terning
    {
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
                    throw new FormatException("Fejl i indtastning af værdi. Ikke mellem 1 og 6.");
                    this.værdi = 1;
                }
                else
                {
                    this.værdi = value;
                }
            }
        }


        public virtual void Skriv()
        {
            Console.WriteLine("[" + this.Værdi + "]");
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
            this.Ryst();
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

    public class LudoTerning : Terning
    {
        public bool ErGlobus()
        {
            return this.Værdi == 3;
        }

        public bool ErStjerne()
        {
            return this.Værdi == 5;
        }

        public LudoTerning() : base()
        {

        }

        public LudoTerning(bool snydeTerning) : base(snydeTerning) { }

        public override void Skriv()
        {
            if (this.Værdi == 3)
            {
                Console.WriteLine("[" + "G" + "]");
            }
            else if (this.Værdi == 5)
            {
                Console.WriteLine("[" + "S" + "]");
            }
            else
            {
                base.Skriv();
            }
        }
    }


    public class Faktura
    {
        public int Nr
        {
            get; set;
        }

        public DateTime Dato
        {
            get; set;
        }

        public string Kunde
        {
            get; set;
        }

        public override string ToString()
        {
            return $"Faktura til {Kunde} nr {Nr} fra {Dato}";
        }

    }


    public abstract class Dyr
    {
        public string Navn
        {
            get; set;
        }

        public virtual string SigNoget()
        {

            return $"Jeg er et dyr og hedder {Navn}";
        }

        public static Dyr TilfældigtDyr()
        {
            Random rnd = new Random();
            string data = "Freja;Bella;Emma;Mille;Fie;Molly;Lady;Trine;Trunte;Luna;Amanda;";
            data += "Bonnie;Laika;Ronja;Sally;Trille;Zita;Tøsen;Bianca;Zenta;Victor;Buller;";
            data += "Buster;King;Simba;Thor;Charlie;Samson;Bamse;Mickey;Max;Rasmus;Sofus;Anton;";
            data += "Laban;Basse;Bølle;Oliver;Oscar;Balder";
            string[] navne = data.Split(';');
            int index = rnd.Next(0, navne.Length);

            if (rnd.Next(0, 2) == 0)
            {
                return new Hund() { Navn = navne[index] };
            }
            else
            {
                return new Kat() { Navn = navne[index] };
            }

        }
    }

    public class Hund : Dyr
    {
        public override string SigNoget()
        {
            return $"Jeg er en hund og hedder {Navn}";
        }
    }

    public class Kat : Dyr
    {
        public override string SigNoget()
        {
            return $"Jeg er en kat og hedder {Navn}";
        }
    }





}
