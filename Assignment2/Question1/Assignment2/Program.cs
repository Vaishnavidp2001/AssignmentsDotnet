using System;

class TrainTicketBooking
{
    static void Main()
    {
        int totalCost = 0;
        string userInput = "";

        Console.WriteLine("Welcome to the Train Ticket Booking System!");
        Console.WriteLine("Available Ticket Types:");
        Console.WriteLine("General - Rs. 200");
        Console.WriteLine("AC      - Rs. 1000");
        Console.WriteLine("Sleeper - Rs. 500");

        // Loop until the user types "exit"
        while (true)
        {
            Console.Write("\nEnter ticket type (General/AC/Sleeper) or type 'exit' to finish: ");
            userInput = Console.ReadLine().ToLower();

            // Check for exit condition
            if (userInput == "exit")
                break;

            // Determine ticket price using switch-case
            int ticketPrice = 0;
            switch (userInput)
            {
                case "general":
                    ticketPrice = 200;
                    break;
                case "ac":
                    ticketPrice = 1000;
                    break;
                case "sleeper":
                    ticketPrice = 500;
                    break;
                default:
                    Console.WriteLine("Invalid ticket type. Please try again.");
                    continue; // Skip to next iteration if ticket type is invalid
            }

            // Get the number of tickets from the user
            Console.Write("Enter the number of tickets: ");
            int numberOfTickets;
            if (!int.TryParse(Console.ReadLine(), out numberOfTickets) || numberOfTickets < 1)
            {
                Console.WriteLine("Invalid number. Please enter a valid positive integer.");
                continue;
            }

            // Calculate booking cost and update the total cost
            int bookingCost = ticketPrice * numberOfTickets;
            totalCost += bookingCost;
            Console.WriteLine($"Cost for this booking: Rs. {bookingCost}");
        }

        // Display the total cost for all bookings
        Console.WriteLine($"\nTotal cost of all bookings: Rs. {totalCost}");
    }
}
