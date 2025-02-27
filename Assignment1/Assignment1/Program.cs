namespace Assignmanet_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region //Question1
            string name;
            int age;
            double percentage;
            Console.WriteLine("Please Enter");
            Console.WriteLine("Name");
            name = Console.ReadLine();
            Console.WriteLine("Age");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Percentage:");
            percentage = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Name is{name}, age is {age}, Percentage is {percentage}");
            #endregion

            #region //Qusetion2
            Console.WriteLine("Enter Age: ");
            bool isproper;
            isproper = int.TryParse(Console.ReadLine(), out age);
            Console.WriteLine(isproper ? age : "Bad Input");
            #endregion


            #region //Qusetion3
            string email;
            Console.WriteLine("Enter Email: ");
            email = Console.ReadLine();
            Console.WriteLine(email.Length > 0 ? email : "Enter cannot be empty");
            #endregion


            DateTime date;
            Console.Write("Discharge Date (yyyy-MM-dd): ");
            string input = Console.ReadLine();

            // Validate user input
            if (DateTime.TryParse(input, out date))
            {
                Console.WriteLine($"Discharge Date: {date:dddd, dd MMMM yyyy}");
            }
            else
            {
                Console.WriteLine("Not Discharged (Invalid Date Format)");
            }

;

        }
    }
}
