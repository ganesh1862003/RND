using FactoryPattern.BusinessLogic;
namespace FactoryPattern.AbstractFactory
{
    public class I3 : IComputerProcessor
    {
        public string getComputerProcessor()
        {
            return ComputerProcessors.I3.ToString();

        }
    }
    public class I5 : IComputerProcessor
    {
        public string getComputerProcessor()
        {
            return ComputerProcessors.I5.ToString();

        }
    }
    public class I7 : IComputerProcessor
    {
        public string getComputerProcessor()
        {
            return ComputerProcessors.I7.ToString();

        }
    }
}
