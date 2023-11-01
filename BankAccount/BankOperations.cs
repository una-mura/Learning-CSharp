namespace BankAccount;

public interface IBankOperations
{
    public double CheckBalance();
    public void DepositMoney(double value);
    public bool WithdrawMoney(double value);
}