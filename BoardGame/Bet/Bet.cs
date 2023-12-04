using BoardGame.Player;

namespace BoardGame.Bet;

public class Bet : IBet
{
    private readonly IPlayer _player;
    private int _size;
    public Resource Type { get; }

    public Bet(IPlayer player, int size, Resource resource)
    {
        _player = player;
        _size = size;
        Type = resource;
    }

    public void GiveReward(int diceRoll)
    {
        switch (diceRoll)
        {
            case < 2:
                _size -= 1;
                return;
            case < 5:
                _player.Reward(_size * 2);
                return;
            case < 6:
                _player.Reward(_size * 2 + _size);
                break;
        }
    }
};