namespace Employee_Management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int IS_FullTime = 1;
            int IS_PartTime = 2;
            int EmpRatePerHr = 20;
            int EmpWage = 0;
            int EmpWorkingHr = 0;
            Random rd = new Random();
            int EmpCheck = rd.Next(0, 3);

            if (EmpCheck == IS_FullTime)
            {
                EmpWorkingHr = 8;
            }
            else if (EmpCheck == IS_PartTime)
            {
                EmpWorkingHr = 4;
            }
            else
            {
                EmpWorkingHr = 0;

                Console.WriteLine("Employee is Absent !");
            }

            EmpWage = EmpWorkingHr * EmpRatePerHr;

            Console.WriteLine("\n\tEmployee Wage For Day = " +EmpWage);
            Console.ReadKey();

        }
    }
}
