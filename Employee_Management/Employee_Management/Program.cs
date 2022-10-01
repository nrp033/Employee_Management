namespace Employee_Management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int IS_FullTime = 1;
            const int IS_PartTime = 2;

            const int EmpRatePerHr = 20;  //Employee Rate Per Hours
            const int MaxWorkingDays = 20;   //Max Working Days In Month
            const int MaxMonthHrs = 100;  //Max Hours In Month


            int TotalMonthWage = 0;  //stores Employee Wage For Month 
            int EmpWorkingHr = 0;    //Stores Employee Working Hours for Day
            int EmpWorkingDays = 0; //Working Days in Month
            int TotalEmpHrs = 0;
           while(TotalEmpHrs < MaxMonthHrs && EmpWorkingDays < MaxWorkingDays )
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
                Console.WriteLine("\tDay #: "+EmpWorkingDays+" Employee Working Hours : "+TotalEmpHrs);
           }

            TotalMonthWage = MaxMonthHrs * EmpRatePerHr;    //Calculating Emplyee Wage For Month
            Console.WriteLine("\n\n\t******* Employee Wage For Month : " +TotalMonthWage+" *******");
            Console.ReadKey();

        }
    }
}
