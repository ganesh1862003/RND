using FactoryPattern.BusinessLogic;

namespace FactoryPattern.AbstractFactory
{
    public class MAC : IComputerBrand
    {
        public string getComputerBrand()
        {
            return ComputerBrand.Apple.ToString();
        }
    }
}
