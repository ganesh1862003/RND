namespace FactoryPattern.AbstractFactory
{
    public class DELLFactory : IComputerFactory
    {
        public IComputerBrand computerBrand()
        {
            return new DELL();
        }

        public IComputerProcessor computerProcessor()
        {
            return new I5();
        }

        public virtual IComputerType computerType()
        {
            return new Desktop();
        }
    }
    public class DELLLaptopFactory : DELLFactory
    {

        public override IComputerType computerType()
        {
            return new Laptop();
        }
    }
}
