using FactoryPattern.BusinessLogic;

namespace FactoryPattern.AbstractFactory
{
    public class DELL : IComputerBrand
    {
        public string getComputerBrand()
        {
            return ComputerBrand.Dell.ToString();
        }
    }
}
