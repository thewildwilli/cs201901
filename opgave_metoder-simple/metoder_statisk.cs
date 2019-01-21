using System;
using System.Collections.Generic;
using System.Text;

namespace opgave_metoder_simple
{
    public class Program2
    {
        public static void Main2()
        {
            Console.WriteLine("Hello World 2");


            //// fuld af statiske metoder - fordi der er så mange, har den sit eget "bibliotek"
            //System.IO.File.Delete("");


            //// Det samme som ovenfor men udført vha. instans metoder (ikkestatiske)
            //System.IO.FileInfo f = new System.IO.FileInfo("");
            //f.Delete();
            Console.WriteLine("Findes filen?");
            Console.WriteLine(System.IO.File.Exists("c:/temp/text.txt"));
            Console.WriteLine(System.IO.File.ReadAllText("c:/temp/text.txt"));


            var myFile = new System.IO.FileInfo("c:/temp/text.txt");
            Console.WriteLine(myFile.LastAccessTime);
            Console.WriteLine(myFile.Extension);




            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.WriteLine("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

    }

    internal struct Person
    {
        private string navn;
        private int alder;

        public void Udskriv()
        {
            Console.WriteLine($"Jeg herdder {this.navn} og er {this.alder} år gammel.");
        }

        public static bool ValiderCpr(string cpr)
        {
            return true;
        }



    }


}
