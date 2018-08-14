using System;
using FactoryPattern.Models;
using FactoryPattern.BusinessLogic;
namespace FactoryPattern.Factory
{
    public class FactoryMethod
    {
        public BaseEmployeeFactory CreateFactory(Employee emp)
        {
            BaseEmployeeFactory returnValue = null;
            if (emp.EmployeeTypeId == Convert.ToInt32(EmployeeType.Permanent.GetHashCode()))
            {
                returnValue = new PermanentEmployeeFactory(emp);
            }
            else if (emp.EmployeeTypeId == Convert.ToInt32(EmployeeType.Contract.GetHashCode()))
            {
                returnValue = new ContractEmployeeFactory(emp);
            }
            return returnValue;
        }
        public void GetEmployeeMethodData(Employee emp)
        {
            BaseEmployeeFactory a = new FactoryMethod().CreateFactory(emp);
            a.ApplySalary();            
        }
    }
}
