using FactoryPattern.BusinessLogic;

namespace FactoryPattern.AbstractFactory
{
    public class Laptop : IComputerType
    {
        public string getComputerType()
        {
            return ComputerType.Laptop.ToString();
        }
    }
    public class Desktop : IComputerType
    {
        public string getComputerType()
        {
            return ComputerType.Desktop.ToString();
        }
    }
}
