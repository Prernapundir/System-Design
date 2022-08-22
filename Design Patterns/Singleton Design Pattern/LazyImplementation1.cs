
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

        private static Singleton singleInstance = null;

        // Lock object for thread safety
        private static readonly object lockObject = new();

        // Lazy Implementation : Where we are creating the objects on demand
        public static Singleton SingleInstance
        {
            get
            {
                if (singleInstance == null)
                {
                    //Double Checked Locking : as locks are expensive operation ,
                    //so if single instance is null then only lock code needs to be executed
                    lock (lockObject)
                    {
                        if (singleInstance == null)
                        {
                            singleInstance = new Singleton();
                        }
                    }
                }
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
