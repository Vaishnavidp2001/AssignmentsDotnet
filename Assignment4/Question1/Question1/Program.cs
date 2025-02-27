namespace Assignment4.Question1
{
    public class Program
    {
        static int user = 0;

        public Program()
        {
            user++;
        }
        static void Main(string[] args)
        {
            Program pgm = new Program();
            Program p1 = new Program();
            Program p3 = new Program();


            Console.WriteLine(user);


        }
    }
}
