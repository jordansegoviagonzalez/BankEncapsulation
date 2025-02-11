namespace BankEncapsulation;
// 'namespace' is used to organized and group related classes and types.
// 'BankEncapsulation' is the name of trhe namespace for this projects.




public class BankAccount
// 'public' makes the class accessible from other parts of the program.
// 'BankAccount' is the name of the class that contains the business logic for the account.
{
    private double _balance = 0;
    // 'private' restricts access to the _balance field to within this class.
    // '_balance' stores the current balance of the account, initialized to 0.

    public void Deposit(double amount)
    // 'public' allows the method to be called from the outside of the class.
    // 'void' means this method does not return any value, but performs an action (deposit).
    // 'Deposit' is the method name.
    // 'double amount' is the parameter that represent the amount of money to deposit into the account.
    {
        _balance += amount;
    }

    public double GetBalance()
    {
        return _balance;
    }

}