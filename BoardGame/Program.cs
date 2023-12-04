// See https://aka.ms/new-console-template for more information

using BoardGame;
using BoardGame.Player;
using BoardGame.Player.Strategies;

var market = new Market(new Dice());

var p1 = new CustomStrategyPlayer(new ConcentratedHigh(), 10);
var p2 = new CustomStrategyPlayer(new SpreadButLow(), 10);

for (var i = 0; i < 100; ++i) {
    market.SetBet(p1.GetBet());
    market.SetBet(p2.GetBet());
    
    market.RunSales();
    
    Console.WriteLine("{0}, {1}", p1.GetCoins(), p2.GetCoins());
}


