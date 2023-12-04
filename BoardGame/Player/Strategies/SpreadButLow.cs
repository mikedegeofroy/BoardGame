using BoardGame.Bet;

namespace BoardGame.Player.Strategies;

public class SpreadButLow : IBettingStrategy
{
    public BetPackage GetBet(IPlayer player, int coins)
    {
        return new BetPackage(
            new Bet.Bet(player, 1, Resource.Food),
            new Bet.Bet(player, 1, Resource.Clothes),
            new Bet.Bet(player, 1, Resource.Toys)
        );
    }
}