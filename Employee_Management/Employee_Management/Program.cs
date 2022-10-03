namespace Employee_Management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderArray builder = new EmpWageBuilderArray();
            builder.addCompanyEmpWage("Dmart", 20, 25, 100);
            builder.addCompanyEmpWage("Reliance", 20, 26, 80);
            builder.addCompanyEmpWage("Tata Motors", 20, 26, 120);
            builder.computeEmpWage();
            Console.ReadLine();
        }
    }
}
