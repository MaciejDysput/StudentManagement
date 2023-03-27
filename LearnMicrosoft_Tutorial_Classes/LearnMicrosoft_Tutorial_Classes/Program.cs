
using LearnMicrosoft_Tutorial_Classes;


Console.WriteLine("Enter name");
string name = Console.ReadLine();
Console.WriteLine("Enter your balance");
decimal balance = decimal.Parse(Console.ReadLine());


Console.WriteLine("Enter what u want to do");
Console.WriteLine("Press 1 to enter bank account");
Console.WriteLine("Enter 0 to leave");
int option = int.Parse(Console.ReadLine());
bool menu = true;

do
{
    switch (option)
    {
        case 0: menu = false; break;
        case 1:
            try
            {
                var account = new BankAccount(name, balance);
                Console.WriteLine($"{account.Number} was created by {account.Owner} and has {account.Balance} initla balance");
                Console.WriteLine("Enter your account Withdrawal");
                int withdrawal = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter note to your account withdrawal");
                string noteWithdrawal = Console.ReadLine();
                account.MakeDeposit(withdrawal, DateTime.Now, noteWithdrawal);
                Console.WriteLine(account.Balance);
                Console.WriteLine("Enter your account Deposit");
                int deposit = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter note to your account Deposit");
                string noteDeposit = Console.ReadLine();
                account.MakeDeposit(deposit, DateTime.Now, noteDeposit);
                Console.WriteLine(account.Balance);
                Console.WriteLine("\t\t");
                Console.WriteLine(account.GetAccountHistory());
            }

            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught creating account with negative balance");
                Console.WriteLine(e.ToString());
                return;
            }
            break;
        default:
            break;
    }
} while (menu);