using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    /// <summary>
    /// Singleton Pattern
    /// </summary>
    /*Sealed Keyword restricts inhertance*/
    public sealed class EagerSingleton
    {
        private static int counter = 0;
        private static readonly EagerSingleton EagerSingletonInstance = new EagerSingleton();
        
        /*
        * Private constructor ensures that the object is not created 
        * other than  within class itself
        */
        private EagerSingleton()
        {
            counter++;
            Console.WriteLine("Counter : " + counter.ToString());
        }


        /*
        * Public property used to return only one instance of the class
        * leveraging on the private property
        */
        public static EagerSingleton GetEagerSingleton
        {
            get
            {
                return EagerSingletonInstance;
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
