namespace BankTellerExercise
{
    public class CheckingAccount : BankAccount
    {

        public CheckingAccount(string accountHolder, string accountNumber) : base(accountHolder, accountNumber)
        {

        }

        public CheckingAccount(string accountHolder, string accountNumber, int balance) : base(accountHolder, accountNumber, balance)
        {

        }

        public override int Withdraw(int amountToWithdraw)
        {
            // Only allow the withdraw if the balance isn't going to go below -$100
            if (Balance - amountToWithdraw > -100)
            {
                // Withdraw the $$
                base.Withdraw(amountToWithdraw);
                // If the balance dips below 0, assess $10 charge
                if (Balance < 0)
                {
                    base.Withdraw(10);
                }
            }
            return Balance;
        }
    }
}
