namespace C05_003_StaticDataAndMembers
{
    public class SavingsAccount
    {
        // Instance-level data.
        public double currBalance;

        // A static point of data.
        public static double currInterestRate = 0.04;

        //public SavingsAccount(double balance)
        //{
        //    currBalance = balance;
        //}

        // Notice that our constructor is setting
        // the static currInterestRate value.
        public SavingsAccount(double balance)
        {
            currInterestRate = 0.04; // This is static data!
            currBalance = balance;
        }

        // Static members to get/set interest rate.
        public static void SetInterestRate(double newRate)
        {
            currInterestRate = newRate;
        }

        public static double GetInterestRate()
        {
            return currInterestRate;
        }
    }
}