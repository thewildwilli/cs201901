using System;

namespace Opgave_flowbreak
{
  class Program
  {
    static void Main(string[] args)
    {

      for (int tal = 0; tal < 20; tal++)
      {
        if (tal % 3 != 0)
        {
          continue;
        }
        if (tal > 15)
        {
          break;
        }
        Console.WriteLine(tal);
      }



      if (System.Diagnostics.Debugger.IsAttached)
      {
        Console.Write("Press any key to continue . . . ");
        Console.ReadKey();
      }
    }
  }
}
