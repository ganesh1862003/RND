namespace FactoryPattern.AbstractFactory
{
    public class MACFactory : IComputerFactory
    {
        public IComputerBrand computerBrand()
        {
            return new MAC();
        }

        public IComputerProcessor computerProcessor()
        {
            return new I7();
        }

        public virtual IComputerType computerType()
        {
            return new Desktop();
        }
    }
    public class MACLaptopFactory : MACFactory
    {

        public override IComputerType computerType()
        {
            return new Laptop();
        }
    }
}
