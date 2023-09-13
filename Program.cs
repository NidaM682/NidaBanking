class Program{
    static void DisplayAccountDetails(Account account2){
        Console.WriteLine($"Account Number: {account2.AccountNumber}");
        Console.WriteLine($"Balance: ${account2.Balance}");
    }
    static void Main(string [] args){
        SavingsAccount savingsAccount = new SavingsAccount(1600, 78.0);
        CheckingAccount checkingAccount = new CheckingAccount(2000,680.0);

        savingsAccount.Deposit(2000);
        DisplayAccountDetails(savingsAccount);
        savingsAccount.CalculateInterest();
        DisplayAccountDetails(savingsAccount);

        Console.WriteLine();

        checkingAccount.Deposit(100);
        DisplayAccountDetails(checkingAccount);
        checkingAccount.Withdraw(600);
        DisplayAccountDetails(checkingAccount);
    }
}