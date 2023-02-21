using ATM;

void printOptions()
{
    Console.WriteLine("Please choose from one of the following...");
    Console.WriteLine("1. Deposit");
    Console.WriteLine("2. Withdraw");
    Console.WriteLine("3. Show Balance");
    Console.WriteLine("4. Exit");
}

void deposit(CardHolder currentUser)
{
    Console.WriteLine("How much $ would you like to deposit? ");
    double deposit = double.Parse(Console.ReadLine());
}