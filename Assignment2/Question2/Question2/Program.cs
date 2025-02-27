namespace Operators_Looping_and_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Taking basic salary as input
            Console.WriteLine("Enter Basic Salary: ");
            double basicSalary = Convert.ToDouble(Console.ReadLine());

            // Taking performance rating as input
            Console.WriteLine("Enter Perfomance Rating (0-10))");
            double rating = Convert.ToDouble(Console.ReadLine());

            // Calculating tax deduction (10% of basic salary)
            double taxDeduction = 0.10 * basicSalary;

            double bonus = 0;
            if (rating >= 8)
            {
                bonus = 0.20 * basicSalary;
            }
            else if (rating >= 5)
            {
                bonus = 0.10 * basicSalary;
            }

            double netSalary = basicSalary - taxDeduction + bonus;

            Console.WriteLine("\nSalary Details: ");
            Console.WriteLine($"Basic Salary:{basicSalary}");
            Console.WriteLine($"Tax Deduction (10%): {taxDeduction}");
            Console.WriteLine($"Bonus:{bonus}");
            Console.WriteLine($"Net Salary: {netSalary}");
        }
    }
}
