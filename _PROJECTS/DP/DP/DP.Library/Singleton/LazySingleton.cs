using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    /// <summary>
    /// Singleton Pattern
    /// </summary>
    /*Sealed Keyword restricts inhertance*/
    public sealed class LazySingleton
    {
        private static int counter = 0;
        /*
        * Private constructor ensures that the object is not created 
        * other than  within class itself
        */
        private LazySingleton()
        {
            counter++;
            Console.WriteLine("Counter : " + counter.ToString());
        }


        private static Lazy<LazySingleton> LazySingletonInstance = new Lazy<LazySingleton>(() => new LazySingleton());
        /*
        * Public property used to return only one instance of the class
        * leveraging on the private property
        */
        public static LazySingleton GetLazySingletonInstance
        {
            get
            {
                return LazySingletonInstance.Value;
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
