namespace BoardGame.Player;

public interface IPlayer
{
    Bet.BetPackage GetBet();

    void Reward(int reward);

    int GetCoins();
}