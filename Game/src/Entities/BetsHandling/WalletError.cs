/*
Errors that can arise with the wallet component.
*/

public static class WalletErrors
{
    public static readonly Error NotEnoughMoney = new(
        "Wallet.NotEnoughMoney",
        "You don't have enough money to place a bet."
    );
}
