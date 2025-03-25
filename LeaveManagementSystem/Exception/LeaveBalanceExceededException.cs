using System;


namespace LeaveManagementSystem.Exception
{
    public class LeaveBalanceExceededException : IOException
    {
        public LeaveBalanceExceededException(string userId, int requestedDays, int availableDays)
           : base($"User {userId} tried to request {requestedDays} days, but only {availableDays} days are available.")
        {
        }
    }
}
