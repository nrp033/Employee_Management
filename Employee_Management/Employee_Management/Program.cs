namespace Employee_Management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WageCalculator Dmart = new WageCalculator("Dmart", 20, 20, 100);
            WageCalculator Reliance = new WageCalculator("Reliance", 20, 20, 100);
            Dmart.ComputeEmpWage();
            Console.WriteLine(Dmart.toString());
            Reliance.ComputeEmpWage();
            Console.WriteLine(Reliance.toString());

            Console.ReadLine();
        }
    }
}
