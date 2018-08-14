using System;
using System.Threading.Tasks;
using SingletonPattern;
using FactoryPattern;
namespace DesignPatterns
{
    class Program
    {
        public static string strKeyMain = "";
        public static string strKeyChild = "";
        public static string strKeyChilds = "";
        public static string NewLine => "\r\n";
        static void Main(string[] args)
        {
        
            // 1 : SINGLETON    (A : SINGLETON WITH THREAD SAFE , B : EAGER LOADING , LAZY LOADING)
            // 2 : FACTORY      (A : SIMPLE)

        MainLoop:
            Console.WriteLine(NewLine);
            Console.WriteLine("SELECT THE DESIGN PATTERN .FOR E.G. (1/2/3) : ");
            strKeyMain = Console.ReadLine().ToString();
            Console.WriteLine(NewLine);

            if (Convert.ToInt32(strKeyMain) == 1) //SINGLETONPATTERN
            {
            ChildLoop1:
                Console.WriteLine("SELECT SINGLETON PATTERN TYPE. FOR E.G. (A/B/C)");
                strKeyChild = Console.ReadLine().ToString();
                if (strKeyChild.ToUpper() == "A")
                {                    
                    Console.WriteLine("SINGLETON WITH THREAD SAFE");
                    Parallel.Invoke(() => GetSingletonInstance_1(), () => GetSingletonInstance_2());
                }
                else if (strKeyChild.ToUpper() == "B")
                {
                    Console.WriteLine("SINGLETON WITH EAGER LOADING");
                    Parallel.Invoke(() => GetEagerSingletonInstance_1(), () => GetEagerSingletonInstance_2());
                }
                else if (strKeyChild.ToUpper() == "C")
                {
                    Console.WriteLine("SINGLETON WITH LAZY LOADING");
                    Parallel.Invoke(() => GetLazySingletonInstance_1(), () => GetLazySingletonInstance_2());
                }
                else
                {
                    goto ChildLoop1;
                }

            }
            else if (Convert.ToInt32(strKeyMain) == 2) //SIMPLE FACTORY
            {
                Console.WriteLine("SELECT FACTORY PATTERN TYPE. FOR E.G. (A/B/C)");
                strKeyChild = Console.ReadLine().ToString();

            ChildLoop2:                
                if (strKeyChild.ToUpper() == "A")
                {                    
                    Console.WriteLine("SIMPLE FACTORY PATTERN");
                    Console.WriteLine("SELECT EMPLOYEE TYPE .FOR E.G. (1,2)");
                    strKeyChilds = Console.ReadLine().ToString();
                    SimpleFactory A = new SimpleFactory();
                    A.GetEmployeeData(Convert.ToInt32(strKeyChilds));
                }
                else
                {
                    goto ChildLoop2;
                }
            }

            Console.WriteLine(NewLine);
            Console.WriteLine("WANT TO CONTINUE (Y/N)?");
            if (Console.ReadLine().ToString().ToUpper() == "Y")
            {
                goto MainLoop;
            }
        }

        #region SINGLETON
        private static void GetSingletonInstance_1()
        {
            Singleton GetSingletonInstance_1 = Singleton.GetSingletonInstance;
            GetSingletonInstance_1.PrintDetails("PRINT : GetSingletonInstance_1");
        }
        private static void GetSingletonInstance_2()
        {
            Singleton GetSingletonInstance_2 = Singleton.GetSingletonInstance;
            GetSingletonInstance_2.PrintDetails("PRINT : GetSingletonInstance_2");
        }

        private static void GetEagerSingletonInstance_1()
        {
            EagerSingleton GetEagerSingletonInstance_1 = EagerSingleton.GetEagerSingleton;
            GetEagerSingletonInstance_1.PrintDetails("PRINT : GetEagerSingletonInstance_1");
        }
        private static void GetEagerSingletonInstance_2()
        {
            EagerSingleton GetEagerSingletonInstance_2 = EagerSingleton.GetEagerSingleton;
            GetEagerSingletonInstance_2.PrintDetails("PRINT : GetEagerSingletonInstance_2");
        }

        private static void GetLazySingletonInstance_1()
        {
            LazySingleton GetLazySingletonInstance_1 = LazySingleton.GetLazySingletonInstance;
            GetLazySingletonInstance_1.PrintDetails("PRINT : GetLazySingletonInstance_1");
        }
        private static void GetLazySingletonInstance_2()
        {
            LazySingleton GetLazySingletonInstance_2 = LazySingleton.GetLazySingletonInstance;
            GetLazySingletonInstance_2.PrintDetails("PRINT : GetLazySingletonInstance_2");
        }
        #endregion
        
    }
}
