namespace Employee_Management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int IS_FullTime = 1;
            const int IS_PartTime = 2;
            int EmpRatePerHr = 20;
            int EmpWage = 0;
            int EmpWorkingHr = 0;
            Random rd = new Random();
            int EmpCheck = rd.Next(0, 3);
            switch (EmpCheck)
            {
                case IS_FullTime:
                    EmpWorkingHr = 8;
                    break;
                case IS_PartTime:
                    EmpWorkingHr = 4;
                    break;
                default:
                    EmpWorkingHr = 0;
                    Console.WriteLine("\n\tEmployee is Absent !");
                    break;

            }
           

            EmpWage = EmpWorkingHr * EmpRatePerHr;

            Console.WriteLine("\n\tEmployee Wage For Day = " +EmpWage);
            Console.ReadKey();

        }
    }
}
