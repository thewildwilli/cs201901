using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using williamernice;

namespace opgave_udvid_klasser
{
    class Program
    {
        static void Main(string[] args)
        {

            // For at lave extensions, skal man bruge "this"-keyword
            
            var d1 = new DateTime(2018, 9, 1);
            var d2 = new DateTime(2018, 9, 5);
            Console.WriteLine($"d1.IsWeekend = {d1.IsWeekend()}");
            Console.WriteLine($"d2.IsWeekend = {d2.IsWeekend()}");

            Console.WriteLine($"now.IsWeekend = {DateTime.Now.IsWeekend()}");

            string a = "søren";

            Console.WriteLine(a.LeftPartOfString(2));
            Console.WriteLine(a.FormatName());

        }
    }
}


namespace williamernice
{
    public static class MineMetoder
    {
        // Udvider DateTime
        public static bool IsWeekend(this DateTime d)
        {
            if (d.DayOfWeek == DayOfWeek.Sunday || d.DayOfWeek == DayOfWeek.Saturday)
                return true;

            return false;
        }

        // Udvider string
        public static string LeftPartOfString(this string text, int number)
        {
            text += new string(' ', number);
            return text.Substring(0, number);
        }


        public static string FormatName(this string s)
        {
            if (s.Length >0)
            {
                return s.Substring(0, 1).ToUpper()+s.Substring(1);
            }
            return null;
        }

    }
}
