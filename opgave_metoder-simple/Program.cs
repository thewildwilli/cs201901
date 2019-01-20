using System;

namespace opgave_metoder_simple
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");



      int LægSammen(int a, int b)
      {
        return a + b;
      }

      double BeregnAreal(int radius)
      {
        return Math.PI * radius * radius;
      }

      void Udskriv(string txt)
      {
        Console.WriteLine(txt);
      }

      int res = LægSammen(5, 2);
      Console.WriteLine(res);
      double res2 = BeregnAreal(5);
      Console.WriteLine(res2);
      Udskriv("Dette er en test");

      OverLoadEksempler O = new OverLoadEksempler();

      Console.WriteLine(O.Beregn(1,2));
      Console.WriteLine(O.Beregn(1,2,3));
      Console.WriteLine(O.Beregn(1,2,3,4));
      



      if (System.Diagnostics.Debugger.IsAttached)
      {
        Console.WriteLine("Press any key to continue . . . ");
        Console.ReadKey();
      }
    }

  }


  public class OverLoadEksempler
  {
    public int Beregn(int a, int b)
    {
      return a + b;
    }
    public int Beregn(int a, int b, int c)
    {
      return a + b + c;
    }
    public int Beregn(int a, int b, int c, int d)
    {
      return a + b + c + d;
    }
  }



}
