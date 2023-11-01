using BankAccount;

Console.Write("Account number: ");
var accountNum = Console.ReadLine();
    
Console.Write("Agency number: ");
var agencyNum = Console.ReadLine();
    
Console.Write("Initial credit value: $");
var creditVal = Convert.ToDouble(Console.ReadLine());

var myBankAccount = new Account(accountNum!, agencyNum!, creditVal);

while (true)
{
    Console.WriteLine("\nWelcome! What would you like to do?\n");
    
    Console.WriteLine("1. Check balance");
    Console.WriteLine("2. Deposit money");
    Console.WriteLine("3. Withdraw money");
    Console.WriteLine("4. End session\n");
    
    Console.Write("Selection: ");
    var selection = Convert.ToInt32(Console.ReadLine());

    switch (selection)
    {
        case 1:
            Console.WriteLine("\nBank Extract\n");
            Console.WriteLine($"Account: {myBankAccount.AccountNumber}");
            Console.WriteLine($"Agency: {myBankAccount.AgencyNumber}");
            Console.WriteLine($"Current balance: ${myBankAccount.CheckBalance()}");
            break;
        
        case 2:
            Console.Write("Deposit value: $");
            myBankAccount.DepositMoney(Convert.ToDouble(Console.ReadLine()));
            break;
        
        case 3:
            Console.Write("Withdraw value: ");
            Console.WriteLine
            (
                myBankAccount.WithdrawMoney(Convert.ToDouble(Console.ReadLine()))
                    ? "Successful withdrawal!"
                    : "Failed withdrawal!"
            );
            break;
        
        case 4:
            break;
        
        default:
            Console.WriteLine("Invalid selection.");
            break;
    }

    if (selection == 4) break;
}