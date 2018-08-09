using FactoryPattern.InterFaces;

namespace FactoryPattern.BusinessLogic
{
    public class SimpleFactoryPermamentEmp : ISimpleFactoryInterFace
    {
        public decimal getBonus()
        {
            return 10;
        }

        public decimal getPay()
        {
            return 8;
        }
    }
    public class SimpleFactoryContractEmp : ISimpleFactoryInterFace
    {
        public decimal getBonus()
        {
            return 5;
        }

        public decimal getPay()
        {
            return 12;
        }
    }
}
