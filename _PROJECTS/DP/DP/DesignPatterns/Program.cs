using System;
using System.Threading.Tasks;
using SingletonPattern;
namespace DesignPatterns
{
    class Program
    {
        public static string strKey = "";
        static void Main(string[] args)
        {
            // 1 : SINGLETON

            Console.WriteLine("KEY IN TO DISPLAY (1/2/3):");
            strKey = Console.ReadLine().ToString();

            if (Convert.ToInt32(strKey) == 1) //SINGLETONPATTERN
            {

                Parallel.Invoke(()=> GetSingletonInstance_1(), ()=> GetSingletonInstance_2());
            }
            else
            {
                Console.WriteLine("INCORRECT KEY INPUT");                
            }
            Console.ReadLine();

        }
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
    }
}
