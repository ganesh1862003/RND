﻿using FactoryPattern.Models;
using FactoryPattern.BusinessLogic;

namespace FactoryPattern.Factory
{
    public class ContractEmployeeFactory : BaseAbstractFactory
    {
        public ContractEmployeeFactory(Employee emp) : base(emp)
        {
        }

        public override ISimpleFactoryInterFace Create()
        {
            SimpleFactoryContractEmp manager = new SimpleFactoryContractEmp();
            _emp.MedicalAllowance = manager.getMedicalAllowance();
            return manager;
        }
    }
}
