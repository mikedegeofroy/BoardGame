namespace BoardGame;

// Hold the bets
// Decides the result of those bets
// Decides if the bets stay
public class Market
{
    private readonly List<Bet.Bet> _bets;
    private readonly Dice _dice;

    public Market(Dice dice)
    {
        _dice = dice;
        _bets = new List<Bet.Bet>();
    }

    public void SetBet(Bet.Bet bet)
    {
        _bets.Add(bet);
    }
    
    public void SetBet(Bet.BetPackage bet)
    {
        _bets.AddRange(bet.GetBets());
    }

    public void RunSales()
    {
        foreach (Resource resource in Enum.GetValuesAsUnderlyingType<Resource>())
        {
            SellResource(resource);
        }
    }

    private void SellResource(Resource resource)
    {
        var diceRoll = _dice.Roll();
        var resourceBets = _bets.Where(x => x.Type == resource);
        foreach (var bet in resourceBets.ToList())
        {
            bet.GiveReward(diceRoll);
            if (diceRoll > 2)
                _bets.Remove(bet);
        }
    }
}