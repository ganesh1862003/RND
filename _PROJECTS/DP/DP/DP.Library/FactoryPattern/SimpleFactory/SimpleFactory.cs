using FactoryPattern.InterFaces;
using FactoryPattern.BusinessLogic;
using System;

namespace FactoryPattern
{
    public class SimpleFactory
    {
        public ISimpleFactoryInterFace GetEmployee(int EmployeeTypeId)
        {
            ISimpleFactoryInterFace returnValue = null;
            if (EmployeeTypeId == Convert.ToInt32(EmployeeType.Permanent.GetHashCode()))
            {
                returnValue = new SimpleFactoryPermamentEmp();
            }
            else if (EmployeeTypeId == Convert.ToInt32(EmployeeType.Contract.GetHashCode()))
            {
                returnValue = new SimpleFactoryContractEmp();
            }
            return returnValue;
        }

        public void GetEmployeeData(int EmployeeTypeId)
        {
            SimpleFactory a = new SimpleFactory();
            ISimpleFactoryInterFace iSimp = a.GetEmployee(EmployeeTypeId);
            Console.WriteLine("BONUS : " + iSimp.getBonus().ToString() + " ;PAY " + iSimp.getPay().ToString());
        }

        
    }
}
