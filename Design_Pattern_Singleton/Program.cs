using System;

namespace Design_Pattern_Singleton
{
    public sealed class Singleton
    {
        private static int count = 0;
        private static Singleton instance = null; //hold a reference to the single created instance of the class
        public static Singleton GetInstance //return the single-created instance of the singleton class
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();
                return instance;
            }
        }

        private Singleton() //it is not allowed the class to be instantiated from outside the class. It only instantiates from within the class
        {
            count++;
            Console.WriteLine("Count Value " + count.ToString());
        }
        public void Details(string message)
        {
            Console.WriteLine(message);
        }
    }
    public class Program
    {
        static void Main(string[] args) // same instance call different ways
        {
            Singleton fromOneClient = Singleton.GetInstance;
            fromOneClient.Details("From OneClient");
            Singleton fromTwoClient = Singleton.GetInstance;
            fromTwoClient.Details("From TwoClient");
            Console.ReadLine();
        }
    }
}
