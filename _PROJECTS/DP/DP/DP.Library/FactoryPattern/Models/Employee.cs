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

        public int EmployeeTypeId { get => _EmployeeTypeId; set => _EmployeeTypeId = value; }
        public decimal Bonus { get => _Bonus; set => _Bonus = value; }
        public decimal Salary { get => _Salary; set => _Salary = value; }
        public decimal HouseAllowance { get => _HouseAllowance; set => _HouseAllowance = value; }
        public decimal MedicalAllowance { get => _MedicalAllowance; set => _MedicalAllowance = value; }
        
    }
}
