using BoardGame.Bet;
using BoardGame.Player.Strategies;

namespace BoardGame.Player;

public class CustomStrategyPlayer : IPlayer
{
    private readonly IBettingStrategy _strategy;
    private int _coins;

    public CustomStrategyPlayer(IBettingStrategy strategy, int coins)
    {
        _strategy = strategy;
        _coins = coins;
    }

    public BetPackage GetBet()
    {
        return _strategy.GetBet(this, _coins);
    }

    public void Reward(int reward)
    {
        _coins += reward;
    }
    
    public int GetCoins()
    {
        return _coins;
    }
}