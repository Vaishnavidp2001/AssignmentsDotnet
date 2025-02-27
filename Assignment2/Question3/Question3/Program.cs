namespace WalletBalanceChecker_Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> userWallets = new Dictionary<string, double>()
        {
            {"user1", 1500.50},
            {"user2", 2500.75},
            {"user3", 1000.00},
            {"user4", 500.25},
            {"user5", 3000.00}
        };

            string userId = "";

            // Loop until a valid user ID is entered
            while (true)
            {
                Console.Write("Enter your User ID: ");
                userId = Console.ReadLine();

                // Check if the entered ID exists in the dictionary
                if (userWallets.ContainsKey(userId))
                {
                    Console.WriteLine($"\nWallet balance for {userId}: Rs. {userWallets[userId]}");
                    break; // Exit the loop after displaying the balance
                }
                else
                {
                    Console.WriteLine("Invalid User ID. Please try again.\n");
                }
            }
        }
    }
}
