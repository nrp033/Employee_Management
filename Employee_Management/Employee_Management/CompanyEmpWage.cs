using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management
{
    internal class CompanyEmpWage
    {


        public string company;
        public int RatePerHr;
        public int MaxWorkingDays_Month;
        public int MaxWorkingHrs_Month;
        public int totalEmpWage;
        public CompanyEmpWage(string company, int RatePerHr, int MaxWorkingDays_Month, int MaxWorkingHr_Month)
        {
            this.company = company;
            this.RatePerHr = RatePerHr;
            this.MaxWorkingDays_Month = MaxWorkingDays_Month;
            this.MaxWorkingHrs_Month = MaxWorkingHr_Month;
        }
        public void setTotalEmpWage(int TotalEmpWage)
        {
            this.totalEmpWage = TotalEmpWage;
        }
        public string toString()
        {
            return "\nTotal Employee Wage for Company  " + this.company + " is : " + this.totalEmpWage+"\n";
        }
    }
}
