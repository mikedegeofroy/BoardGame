namespace BoardGame.Bet;

public class BetPackage
{
    private readonly List<Bet> _bets;

    public BetPackage(params Bet[] bets)
    {
        _bets = new List<Bet>(bets);
    }

    public IReadOnlyCollection<Bet> GetBets()
    {
        return _bets;
    }
}