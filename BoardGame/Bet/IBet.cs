namespace BoardGame.Bet;

public interface IBet
{
    Resource Type { get; }
    void GiveReward(int diceRoll);
}