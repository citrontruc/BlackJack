/*
Errors that can arise with the wallet component.
*/

using BlackJack.Utils.Errors;

namespace BlackJack.Entities.BetsHandling;

public static class WalletErrors
{
    public static readonly Error NotEnoughMoney = new(
        "Wallet.NotEnoughMoney",
        "You don't have enough money to place a bet."
    );
}
