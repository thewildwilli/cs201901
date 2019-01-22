using System;
using System.Collections.Generic;
using System.Text;

namespace opgave_klasser_simpel
{
    internal class Beregninger
    {
        static public int LægSammen(int a, int b)
        {
            return a + b;
        }

        static public Func<int, int, int> TrækFra = (a, b) => a - b;
                
    }
}
