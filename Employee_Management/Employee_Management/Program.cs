namespace Employee_Management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int IS_FullTime = 1;
            Random rd = new Random();
            int EmpCheck = rd.Next(0, 2);

            if (EmpCheck == IS_FullTime)
            {
                Console.WriteLine("\n\n\tEmployee is Present !");
            }
            else
            {
                Console.WriteLine("\n\n\tEmployee is Absent !");
            }
            Console.ReadKey();

        }
    }
}
