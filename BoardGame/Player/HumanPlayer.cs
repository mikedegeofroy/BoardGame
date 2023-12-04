using BoardGame.Bet;

namespace BoardGame.Player;

public class HumanPlayer : IPlayer
{
    private int _coins;

    public HumanPlayer(int coins)
    {
        _coins = coins;
    }

    public BetPackage GetBet()
    {
        throw new NotImplementedException();
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