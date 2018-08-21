using System;
using FactoryPattern.Models;
using FactoryPattern.BusinessLogic;

namespace FactoryPattern.AbstractFactory
{
    public class EmployeeSystemFactory
    {
        public IComputerFactory CreateFactory(Employee emp)
        {
            IComputerFactory returnValue = null;
            if (emp.EmployeeTypeId == Convert.ToInt32(EmployeeType.Permanent.GetHashCode()))
            {
                if (emp.JobDetails == "Manager")
                {
                    returnValue = new MACLaptopFactory();
                }
                else
                {
                    returnValue = new MACFactory();
                }
            }
            else if (emp.EmployeeTypeId == Convert.ToInt32(EmployeeType.Contract.GetHashCode()))
            {
                if (emp.JobDetails == "Manager")
                {
                    returnValue = new DELLLaptopFactory();
                }
                else
                {
                    returnValue = new DELLFactory();
                }
            }
            return returnValue;
        }
    }
}
