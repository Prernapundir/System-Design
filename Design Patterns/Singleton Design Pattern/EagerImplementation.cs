using System;
using System.Threading.Tasks;

namespace Singleton_Design_Pattern
{
    sealed class Singleton
    {
        public static int counter = 0;

        private Singleton()
        {
            counter++;
            Console.WriteLine($"Instance created : {counter}");
        }

        // Eager Implementation : Creating instance of Singleton class beforehand
        private static  readonly Singleton singleInstance =  new();

        public static Singleton SingleInstance
        {
            get
            {
                return singleInstance;
            }
        }

        public void Display(int number)
        {
            Console.WriteLine($"Displaying message {number}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Singleton instance1 = Singleton.SingleInstance;
            //instance1.Display(1);
            //Singleton instance2 = Singleton.SingleInstance;
            //instance2.Display(2);


            // Muti-threading
            Parallel.Invoke(
                () => DisplayMessage1(),
                () => DisplayMessage2()
                );

        }
        private static void DisplayMessage1()
        {
            Singleton instance1 = Singleton.SingleInstance;
            instance1.Display(1);
        }

        private static void DisplayMessage2()
        {
            Singleton instance1 = Singleton.SingleInstance;
            instance1.Display(2);
        }
    }
}
