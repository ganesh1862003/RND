using System;
using FactoryPattern.Models;
using FactoryPattern.BusinessLogic;
using FactoryPattern.AbstractFactory;
namespace FactoryPattern.Factory
{
    public class FactoryMethod
    {
        public BaseAbstractFactory CreateFactory(Employee emp)
        {
            BaseAbstractFactory returnValue = null;
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
            BaseAbstractFactory a = new FactoryMethod().CreateFactory(emp);
            a.ApplySalary();
            Console.WriteLine("BONUS : " + emp.Bonus.ToString() + " ;PAY " + emp.Salary.ToString() + " ;House " + emp.HouseAllowance.ToString() + " ;Medical " + emp.MedicalAllowance.ToString());
        }
        public void GetEmployeeAbstractFactoryData(Employee emp)
        {
            BaseAbstractFactory a = new FactoryMethod().CreateFactory(emp);
            a.ApplySalary();
            IComputerFactory computerFactory = new EmployeeSystemFactory().CreateFactory(emp);
            EmployeeSystemManager employeeSystemManager = new EmployeeSystemManager(computerFactory);
            emp.ComputerDetails =  employeeSystemManager.GetSystemDetails();
            Console.WriteLine("BONUS : " + emp.Bonus.ToString() + " ;PAY " + emp.Salary.ToString() + " ;House " + emp.HouseAllowance.ToString() + " ;Medical " + emp.MedicalAllowance.ToString() + " ;ComputerDetails " + emp.ComputerDetails.ToString());
        }
    }
}
