using System;

namespace opgave_metoder_simple
{
    internal class Program
  {
    public static void Main(string[] args)
    {
      // kører koden nedenunder
      Main1();

      // kører koden i metoder_statistik-filen
      Program2.Main2();

      // kører koden i metoder_rekursiv-filen
      Program3.Main3();



      if (System.Diagnostics.Debugger.IsAttached)
      {
        Console.WriteLine("Press any key to continue . . . ");
        Console.ReadKey();
      }
    }


    public static void Main1()
    {
      Console.WriteLine("Hello World!");

      int lægSammen(int a, int b)
      {
        return a + b;
      }

      double beregnAreal(int radius)
      {
        return Math.PI * radius * radius;
      }

      void udskriv(string txt)
      {
        Console.WriteLine(txt);
      }

      int res = lægSammen(5, 2);
      Console.WriteLine(res);
      double res2 = beregnAreal(5);
      Console.WriteLine(res2);
      udskriv("Dette er en test");

      OverLoadEksempler o = new OverLoadEksempler();

      Console.WriteLine(o.Beregn(1, 2));
      Console.WriteLine(o.Beregn(1, 2, 3));
      Console.WriteLine(o.Beregn(1, 2, 3, 4));

      void printTwo(int a, int b)
      {
        Console.WriteLine("Første argument");
        Console.WriteLine(a);
        Console.WriteLine("Andet argument");
        Console.WriteLine(b);
      }

      printTwo(b: 2, a: 1);


      //En hurtigt defineret definition
      Func<int, int, int> gangSammen = (int a, int b) => a * b;

      (int, bool, string) test(int a)
      {
        return (5, true, "huhuhu");
      }

      Console.WriteLine(test(4));


      //En rekursiv funktion
      void testRekursiv(string path)
      {
        var filer = System.IO.Directory.GetFiles(path);
        foreach (var fil in filer)
        {
          Console.WriteLine(fil);
        }
        var mapper = System.IO.Directory.GetDirectories(path);
        foreach (var mappe in mapper)
        {
          testRekursiv(mappe);
        }
      }

      testRekursiv("C:/drivers");

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
