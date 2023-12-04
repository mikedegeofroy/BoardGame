using BoardGame.Bet;

namespace BoardGame.Player.Strategies;

public class ConcentratedHigh : IBettingStrategy
{
    public BetPackage GetBet(IPlayer player, int coins)
    {
        return new BetPackage(
            new Bet.Bet(player, 3, Resource.Food)
        );
    }
}