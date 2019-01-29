using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave_delegate
{
    class Program
    {
        static void Main(string[] args)
        {


            //Func - til metoder med returværdi
            Func<int, bool> modern_delegate;
            Predicate<int> doNotUseThis;

            Func<int, int> function = MyMethod;
            function += MyMethod;

            var b = function(4);

            Console.WriteLine(b);

            //Action - til void metoder
            Action<int> modern_delegate_with_no_return_value;




            //problem - make this work
            Console.WriteLine("f1");
            Action<string> f1 = MinSkrivTilConsole;
            f1("test");

            Console.WriteLine("f2");
            Action<string> f2 = MinSkrivTilConsole;
            f2("test");

            Console.WriteLine("f3");
            Action<string> f3 = MinSkrivTilConsole;
            f3 += Console.WriteLine;
            f3("test");

            Console.WriteLine("cleans up");
            f1 = MinSkrivTilConsole;
            f2 -= MinSkrivTilConsole;
            f3 -= MinSkrivTilConsole;
            f3 -= Console.WriteLine;

            try
            {

                f1("does this work?");
                f2("does this work?");
                f3("does this work?");
            }
            catch (Exception)
            {

                Console.WriteLine("It did not work");
            }


        }

        static void MinSkrivTilConsole(string txt)
        {
            Console.WriteLine("**** " + txt + " ****");
        }

        static int MyMethod(int a)
        {
            return a;
        }

        static int MyMethod2(int a)
        {
            return a+1;
        }
    }
}
