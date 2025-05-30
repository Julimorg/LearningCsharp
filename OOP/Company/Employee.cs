using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Learning.OOP.Company
{
    public class Employee : Company
    {
        private int empId;

        private string empName;
        private int empPhone;
        private string empWork;
        private double empSalary;

        public Employee(
            int compId,
            string compName,
            string compSymbol,
            string compType,
            int compPhone,
            int empId,
            string empName,
            int empPhone,
            string empWork,
            double empSalary
            ) : base(compId, compName, compSymbol, compType, compPhone)
        {
            this.empId = empId;
            this.empName = empName;
            this.empPhone = empPhone;
            this.empWork = empWork;
            this.empSalary = empSalary;
        }

        public  override string CompanyIntroduce() {
            // return $"{base.CompanyIntroduce()}";
            return $"[{empId}]: {empName} - {empPhone} - {empSalary} - {empWork}"; 
        }




    }
}