using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Models
{
    public class Employee
    {
        private int _EmployeeTypeId;
        private decimal _Bonus;
        private decimal _Salary;
        private decimal _HouseAllowance;
        private decimal _MedicalAllowance;

        public decimal EmployeeTypeId { get => _EmployeeTypeId; set => EmployeeTypeId = _EmployeeTypeId; }
        public decimal Bonus { get => _Bonus; set => Bonus = _Bonus; }
        public decimal Salary { get => _Salary; set => Bonus = _Salary; }
        public decimal HouseAllowance { get => _HouseAllowance; set => Bonus = _HouseAllowance; }
        public decimal MedicalAllowance { get => _MedicalAllowance; set => Bonus = _MedicalAllowance; }
        
    }
}
