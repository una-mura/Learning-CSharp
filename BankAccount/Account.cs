namespace BankAccount;

public class Account : IBankOperations
{
    public string AccountNumber { get; } 
    public string AgencyNumber { get; }
    private readonly double creditValue;
    private double inAccountCredit { get; set; }
    private double inAccountValue { get; set; }


    public Account(string accountNumber, string agencyNumber, double creditValue)
    {
        AccountNumber = accountNumber;
        AgencyNumber = agencyNumber;

        this.creditValue = creditValue;
        inAccountCredit = creditValue;
        inAccountValue = 0.0;
    }

    public double CheckBalance() => inAccountValue + inAccountCredit;

    public void DepositMoney(double value)
    {
        var debt = inAccountCredit - creditValue;

        if (debt < 0)
        {
            inAccountCredit += Math.Abs(debt);
            inAccountValue += value + debt;
        }

        else inAccountValue += value;
    }

    public bool WithdrawMoney(double value)
    {
        var withdraw = inAccountValue - value;
        var success = false;
        
        if (withdraw >= 0)
        {
            inAccountValue -= value;
            success = true;
        }

        else if (Math.Abs(withdraw) <= inAccountCredit)
        {
            inAccountValue = 0;
            inAccountCredit += withdraw;
            success = true;
        }

        return success;
    }
}