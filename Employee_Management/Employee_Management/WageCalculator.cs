using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management
{
    internal class WageCalculator
    {

        const int IS_FullTime = 1;
        const int IS_PartTime = 2;

        private string Company;
        private int EmpRatePerHr;
        private int MaxWorkinDays;
        private int MaxMonthHrs;
        private int TotalEmpWage;

        public WageCalculator(string Company, int EmpRatePerHr, int MaxWorkinDays, int MaxMonthHrs)

        {
           this. Company = Company;
            this.EmpRatePerHr = EmpRatePerHr;
            this.MaxWorkinDays = MaxWorkinDays;
           this. MaxMonthHrs = MaxMonthHrs;
        }
        public void ComputeEmpWage()
        {

            int TotalMonthWage = 0;  //stores Employee Wage For Month 
            int EmpWorkingHr = 0;    //Stores Employee Working Hours for Day
            int EmpWorkingDays = 0; //Working Days in Month
            int TotalEmpHrs = 0;
            while (TotalEmpHrs < MaxMonthHrs && EmpWorkingDays < MaxWorkinDays)
            {
                EmpWorkingDays++; //Increament Working Day by 1 in Month

                Random rd = new Random();
                int EmpCheck = rd.Next(0, 3);

                switch (EmpCheck)   //Checking Condition
                {
                    case IS_FullTime:
                        EmpWorkingHr = 8;
                        break;

                    case IS_PartTime:
                        EmpWorkingHr = 4;
                        break;

                    default:
                        EmpWorkingHr = 0;
                        break;

                }

                TotalEmpHrs += EmpWorkingHr;   //Calculating Total Employee Working Hours In Month
                Console.WriteLine("\tDay #: " + EmpWorkingDays + " Employee Working Hours : " + TotalEmpHrs);
            }

            TotalMonthWage = MaxMonthHrs * EmpRatePerHr;    //Calculating Emplyee Wage For Month
            Console.WriteLine("\n\tEmployee Wage For Company " + Company + " is " + TotalMonthWage + "\n");





        }
    }
}
