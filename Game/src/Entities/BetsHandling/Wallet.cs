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

    public Result DebitWallet(int value)
    {
        if (MoneySum - value < 0)
        {
            return Result.Failure(WalletErrors.NotEnoughMoney);
        }
        MoneySum -= value;
        return Result.Success();
    }
    #endregion
}
