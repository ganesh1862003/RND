namespace FactoryPattern.AbstractFactory
{
    public class EmployeeSystemManager
    {
        IComputerFactory _computerFactory;
        public EmployeeSystemManager(IComputerFactory computerFactory)
        {
            _computerFactory = computerFactory;
        }

        public string GetSystemDetails()
        {
            IComputerBrand computerBrand = _computerFactory.computerBrand();
            IComputerType computerType = _computerFactory.computerType();
            IComputerProcessor computerProcessor = _computerFactory.computerProcessor();
            string returnValue = string.Format("{0} {1} {2}", computerType.getComputerType()
                                                , computerProcessor.getComputerProcessor()
                                                , computerBrand.getComputerBrand());
            return returnValue;
        }
    }
}
