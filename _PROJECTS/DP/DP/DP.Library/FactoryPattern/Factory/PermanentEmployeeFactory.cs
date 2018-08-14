using System;
using System.Collections.Generic;
using System.Text;
using FactoryPattern.InterFaces;
using FactoryPattern.Models;
using FactoryPattern.BusinessLogic;

namespace FactoryPattern.Factory
{
    public class PermanentEmployeeFactory : BaseAbstractFactory
    {
        public PermanentEmployeeFactory(Employee emp) : base(emp)
        {
        }

        public override ISimpleFactoryInterFace Create()
        {
            SimpleFactoryPermamentEmp manager = new SimpleFactoryPermamentEmp();
            _emp.HouseAllowance = manager.getHouseAllowance();
            return manager;
        }
    }
}
