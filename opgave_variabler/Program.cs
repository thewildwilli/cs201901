using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave_variabler
{
    class Program
    {
        static void Main(string[] args)
        {

            opgave_første();

        }


        public void opgave_første()
        {

            // opgave: https://github.com/devcronberg/undervisning-cs-opgaver/blob/master/Variabler-tal/Opgave/index.md


            Int32 heltal = 10;
            heltal++;
            heltal--;
            heltal += 20;
            Console.WriteLine(heltal);
            Console.WriteLine($"Heltal = {heltal}");

            double kommatal = 12.5;
            kommatal++;
            kommatal--;
            kommatal *= 2;
            Console.WriteLine($"Kommatal = {kommatal}");
            

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }
    }
}
