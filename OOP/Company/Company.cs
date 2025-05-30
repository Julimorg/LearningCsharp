using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Learning.OOP.Company
{
    public class Company
    {
        private int compId;
        private string compName;
        private string compSymbol;
        private string compType;

        private int compPhone;

        public Company(int compId, string compName, string compSymbol, string compType, int compPhone)
        {
            this.compId = compId;
            this.compName = compName;
            this.compSymbol = compType;
            this.compPhone = compPhone;
        }

        public int CompId { get; set; }
        public string CompName { get; set; }
        public string CompSymbol { get; set; }
        public string CompType { get; set; }
        public int CompPhone { get; set; }

        public virtual string CompanyIntroduce()
        {
            return $"{compId} - {compName} - {compSymbol} - {compType} - {compPhone}";
        }

    }
}