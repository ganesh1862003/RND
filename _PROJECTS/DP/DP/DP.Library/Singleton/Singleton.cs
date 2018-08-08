using System;

namespace SingletonPattern
{
    /// <summary>
    /// Singleton Pattern
    /// </summary>
    /*Sealed Keyword restricts inhertance*/
    public sealed class Singleton
    {
        private static int counter = 0;
        private static Singleton SingletonInstance = null;
        private static readonly object lockObj = new object();
        /*
        * Private constructor ensures that the object is not created 
        * other than  within class itself
        */
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter : " + counter.ToString());
        }


        /*
        * Public property used to return only one instance of the class
        * leveraging on the private property
        */
        public static Singleton GetSingletonInstance
        {
            get
            {
                if (SingletonInstance == null)
                {
                    lock (lockObj)
                    {
                        if (SingletonInstance == null)
                        {
                            SingletonInstance = new Singleton();
                        }
                    }
                }
                return SingletonInstance;
            }
        }

        /*
        * Public method which can be invoked using Singleton Instance.
        */
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
