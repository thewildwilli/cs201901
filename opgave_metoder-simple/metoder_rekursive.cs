using System;
using System.Collections.Generic;
using System.Text;

namespace opgave_metoder_simple
{
  public class Program3
  {
    public static void Main3()
    {
      void løkkeSomMetode(int start, int slut)
      {
        if (start > slut)
        {
          return;
        }
        Console.WriteLine(start);
        løkkeSomMetode(start + 1, slut);
      }


      løkkeSomMetode(1, 10);
      
    }
  }

}
