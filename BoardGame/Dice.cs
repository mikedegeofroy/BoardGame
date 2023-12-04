namespace BoardGame;

public class Dice
{
    private readonly Random _random;

    public Dice()
    {
        _random = new Random();
    }
    public int Roll()
    {
        return _random.Next(1, 6);
    }
}