using Assignment4._Question2;


namespace Assignment4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager pgm = new Manager("Vaishnavi", 100000.344, 1234.34);

            pgm.displayDetails();
            Employee emp = new Employee("Vaish", 45000.32);

            emp.displayDetails();
        }
    }
}
