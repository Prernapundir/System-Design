/*
 * 1. Singleton Design Patten -> In Singletion Design Pattern , the instance of the class is created only once.
 * 2. We can save lot of memory , as we are only creating the instance once and using it at global level.
 * 3.Steps to implement Singleton Design Pattern
 *   3.1 Make private constructor -> So that no other class can ct=reate the object directly
 *   3.2 Make the Singleton class sealed -> So that non-derived or derived class can inherit singletion class
 *   3.3 Use Lazy implementation /Eager implementation for creating the instances
 *   3.4 Check for thread safety also , so use lock (one of the implementation)
 */

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
