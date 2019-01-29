using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave_operator_overload
{
    class Program
    {
        static void Main(string[] args)
        {
            Hund h1 = new Hund() { Navn = "A", LydNiveau = 30 };
            Hund h2 = new Hund() { Navn = "B", LydNiveau = 20 };
            Console.WriteLine(h1 > h2);  // true


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

        public int LydNiveau
        {
            get; set;
        }

        public static bool operator <(Hund h1, Hund h2)
        {
            if (h1.LydNiveau < h2.LydNiveau)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator >(Hund h1, Hund h2)
        {
            return h1.LydNiveau > h2.LydNiveau;
        }

        public static bool operator ==(Hund h1, Hund h2)
        {
            return h1.LydNiveau == h2.LydNiveau && h1.Navn == h2.Navn;
        }

        public static bool operator !=(Hund h1, Hund h2)
        {
            return !(h1 == h2);
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
