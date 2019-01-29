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

            // Sjov med Events


            Action a = () => { Console.WriteLine("Demo1 NU"); };
            Events.EventDemo1 e = new Events.EventDemo1();
            e.NuDerSkerNoget += a;

            e.DerSkerNoget();
            e.NuDerSkerNoget -= a;


            EventHandler a2 = (sender,eventargs) => { Console.WriteLine("Booom"); };
            Events.EventDemo2 e2 = new Events.EventDemo2();
            e2.NuDerSkerNoget += a2;
            e2.DerSkerNoget();
            e2.NuDerSkerNoget -= a2;

            EventHandler<Events.MineEventArgs> eh3 = (sender, min) => { Console.WriteLine("Den tredje"); };
            Events.EventDemo3 e3 = new Events.EventDemo3();
            e3.NuDerSkerNoget += eh3;
            e3.DerSkerNoget();
            e3.NuDerSkerNoget -= eh3;

            //Events.EventDemo2 o2 = new Events.EventDemo2();
            //EventHandler handler2 = (s, e) => { Console.WriteLine("NU2"); };
            //o2.NuDerSkerNoget += handler2;
            //o2.DerSkerNoget();
            //o2.NuDerSkerNoget -= handler2;

            //Events.EventDemo3 o3 = new Events.EventDemo3();
            //EventHandler<Events.MineEventArgs> handler3 = (s, e) => { Console.WriteLine($"NU - id {e.Id}"); };
            //o3.NuDerSkerNoget += handler3;
            //o3.DerSkerNoget();
            //o3.NuDerSkerNoget -= handler3;




            ////Func - til metoder med returværdi
            //Func<int, bool> modern_delegate;
            //Predicate<int> doNotUseThis;

            //Func<int, int> function = MyMethod;
            //function += MyMethod;

            //var b = function(4);

            //Console.WriteLine(b);

            ////Action - til void metoder
            //Action<int> modern_delegate_with_no_return_value;




            ////problem - make this work
            //Console.WriteLine("f1");
            //Action<string> f1 = MinSkrivTilConsole;
            //f1("test");

            //Console.WriteLine("f2");
            //Action<string> f2 = MinSkrivTilConsole;
            //f2("test");

            //Console.WriteLine("f3");
            //Action<string> f3 = MinSkrivTilConsole;
            //f3 += Console.WriteLine;
            //f3("test");

            //Console.WriteLine("cleans up");
            //f1 = MinSkrivTilConsole;
            //f2 -= MinSkrivTilConsole;
            //f3 -= MinSkrivTilConsole;
            //f3 -= Console.WriteLine;

            //try
            //{

            //    f1("does this work?");
            //    f2("does this work?");
            //    f3("does this work?");
            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("It did not work");
            //}


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
            return a + 1;
        }
    }


}

namespace Events
{


    public class EventDemo1
    {
        public event Action NuDerSkerNoget;

        public void DerSkerNoget()
        {
            if (NuDerSkerNoget != null)
                NuDerSkerNoget();
        }
    }

    public class EventDemo2
    {
        public event EventHandler NuDerSkerNoget;

        public void DerSkerNoget()
        {
            // check for null på anden måde
            NuDerSkerNoget?.Invoke(this, new EventArgs());
        }
    }

    public class EventDemo3
    {
        public event EventHandler<MineEventArgs> NuDerSkerNoget;

        public void DerSkerNoget()
        {
            NuDerSkerNoget?.Invoke(this, new MineEventArgs() { Id = 1 });
        }
    }

    public class MineEventArgs : EventArgs
    {
        public int Id
        {
            get; set;
        }
    }


}
