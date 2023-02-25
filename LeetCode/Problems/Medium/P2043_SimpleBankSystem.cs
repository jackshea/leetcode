namespace LeetCode.Problems.Medium;

public class Bank
{
    private readonly int accountQty;
    private readonly long[] balance;

    public Bank(long[] balance)
    {
        this.balance = balance;
        accountQty = balance.Length;
    }

    public bool Transfer(int account1, int account2, long money)
    {
        if (!CheckAccount(account1, money) || !CheckAccount(account2, 0)) return false;
        balance[account1 - 1] -= money;
        balance[account2 - 1] += money;
        return true;
    }

    public bool Deposit(int account, long money)
    {
        if (!CheckAccount(account, 0)) return false;

        balance[account - 1] += money;
        return true;
    }

    public bool Withdraw(int account, long money)
    {
        if (!CheckAccount(account, money)) return false;

        balance[account - 1] -= money;
        return true;
    }

    private bool CheckAccount(int account, long money)
    {
        return account >= 1 && account <= accountQty && balance[account - 1] >= money;
    }
}