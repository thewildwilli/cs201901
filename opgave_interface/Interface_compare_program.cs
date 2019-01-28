using System;
using System.Collections.Generic;
using System.Text;

namespace opgave_interface2
{
    class Interface_compare_program
    {
        public static void Main2()
        {
            //Hund[] hunde = new Hund[2];
            //hunde[0] = new Hund() { Alder = 10, Navn = "Bulder" };
            //hunde[1] = new Hund() { Alder = 5, Navn = "Lady" };
            //Array.Sort(hunde);
            //foreach (var item in hunde)
            //{
            //    Console.WriteLine(item.Navn);
            //}

            ITilfældighedsGenerator m = new TilfældighedsGeneratorMock(5);
            Console.WriteLine(m.FindTalTilTerning());
            ITilfældighedsGenerator f = new TilfældighedsGeneratorFramework();
            Console.WriteLine(f.FindTalTilTerning());


        }

    }

    class Hund : IComparable<Hund>
    {
        public string Navn
        {
            get; set;
        }
        public int Alder
        {
            get; set;
        }

        public int CompareTo(Hund other)
        {

            return this.Alder - other.Alder;

            //if (this.Alder > other.Alder)
            //{
            //    return 1;
            //}
            //else if (this.Alder < other.Alder)
            //{
            //    return -1;
            //}
            //else
            //{
            //    return 0;
            //}
        }

    }

    public interface ITilfældighedsGenerator
    {
        int FindTalTilTerning();

    }

    public class TilfældighedsGeneratorFramework : ITilfældighedsGenerator
    {
        private static Random rnd = new Random();
        public int FindTalTilTerning()
        {
            return rnd.Next(1, 7);
        }
    }
    public class TilfældighedsGeneratorMock : ITilfældighedsGenerator
    {
        public int Øjne
        {
            get; set;
        }

        public int FindTalTilTerning()
        {
            return Øjne;
        }

        public TilfældighedsGeneratorMock(int øjne = 1)
        {
            this.Øjne = øjne;
        }

    }



}
