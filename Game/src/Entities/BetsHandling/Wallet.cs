/*
A wallet to represent a player's current money count.
*/

public class Wallet
{
    public int MoneySum;

    # region Constructor
    public Wallet(int initialSum)
    {
        MoneySum = initialSum;
    }
    #endregion

    #region Wallet operations
    public void CreditWallet(int value)
    {
        MoneySum += value;
    }

    public void DebitWallet(int value)
    {
        if (MoneySum - value < 0)
        {
            throw new InvalidOperationException("You don't have enough money to credit wallet");
        }
        MoneySum -= value;
    }
    #endregion
}
