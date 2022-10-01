namespace Employee_Management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int IS_FullTime = 1;
            int EmpRatePerHr = 20;
            int EmpWage = 0;
            int EmpWorkingHr = 0;
            Random rd = new Random();
            int EmpCheck = rd.Next(0, 2);

            if (EmpCheck == IS_FullTime)
            {
                EmpWorkingHr = 8;
            }
            else
            {
                EmpWorkingHr = 0;

                Console.WriteLine("Employee is Absent !");
            }
            EmpWage = EmpWorkingHr * EmpRatePerHr;
            Console.WriteLine("Employee Wage For Day = " +EmpWage);
            Console.ReadKey();

        }
    }
}
