namespace FactoryPattern.AbstractFactory
{
    public interface IComputerFactory
    {
        IComputerProcessor computerProcessor();
        IComputerBrand computerBrand();
        IComputerType computerType();
    }
}
