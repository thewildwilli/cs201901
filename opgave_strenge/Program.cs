using System;

namespace opgave_strenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string fornavn = "Mikkel";
            string efternavn = "Cronberg";
            string samletNavn = $"{fornavn} {efternavn}";
            Console.WriteLine(samletNavn);
            string navnStort = samletNavn.ToUpper();
            Console.WriteLine(navnStort);
            string navnLille = navnStort.ToLower();
            Console.WriteLine(navnLille);
            Console.WriteLine(efternavn.Substring(0,4));

            string text = $"fsfs\tfsfsfsfsfsf\r\nfsdfsfsf\tsfs\rns\ns";
            Console.WriteLine($"fsfs\tfsfsfsfsfsf\r\nfsdfsfsf\tsfs\rns\ns");
            System.IO.File.WriteAllText(@"C:\kode\cs201901\opgave_strenge\test_of_write.txt", text);


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }



        }
    }
}
