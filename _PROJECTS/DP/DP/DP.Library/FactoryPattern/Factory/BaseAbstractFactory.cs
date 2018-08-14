using FactoryPattern.Models;
using FactoryPattern.InterFaces;
namespace FactoryPattern.Factory
{
    public abstract class BaseAbstractFactory
    {
        protected Employee _emp;
        public BaseAbstractFactory(Employee emp) { _emp = emp; }

        public Employee ApplySalary()
        {
            ISimpleFactoryInterFace manager = this.Create();
            _emp.Bonus = manager.getBonus();
            _emp.Salary = manager.getPay();
            return _emp;
        }
        public abstract ISimpleFactoryInterFace Create();
    }
}
