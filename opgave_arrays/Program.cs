using System;

namespace opgave_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            


            System.Random rnd = new System.Random();
            int[] månedsløn = new int[15];
            for (int i = 0; i < 15; i++)
            {
                månedsløn[i] = rnd.Next(10000, 60000);
            }


            foreach (int john in månedsløn)
            {
                Console.WriteLine(john);
            }

            Console.WriteLine($"Gennemsnitslønnen er {gennemsnit(månedsløn)} dollars!");


            double gennemsnit(int[] array_john)
            {
                int sum_of_pays = 0;
                foreach (int løn in array_john)
                {
                    sum_of_pays += løn;
                }

                return sum_of_pays / array_john.Length;

            }


            string txt = "3;5;22;1;10;15;5";

            string[] array_1 = txt.Split(";");

            int sum = 0;
            foreach (string character in array_1)
            {
                Console.WriteLine(character);
                sum += Convert.ToInt32(character);
            }
            Console.WriteLine(array_1);
            Console.WriteLine($"Sum fo all elements in the array is {sum}");

        }
    }
}
