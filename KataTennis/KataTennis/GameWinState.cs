using static KataTennis.TennisGame;

namespace KataTennis;

public class GameWinState : IScoreState
{
    TennisGame game = new TennisGame();
    public TennisGame Game { get => game; set => game = value; }

    public void BallWin(Player player)
    {
        if (player == Player.Server)
        {
            Console.WriteLine(ReturnScoreString(player, game.ServerScore, game.ReceiverScore));
            game.ServerScore++;
        }
        else if (player == Player.Receiver)
        {
            Console.WriteLine(ReturnScoreString(player, game.ServerScore, game.ReceiverScore));
            game.ReceiverScore++;
        }
    }
    public GameWinState(TennisGame game, Player player, bool isPlayerWon)
    {
        if(isPlayerWon == true) Console.WriteLine($"{player} wins");
    }
}
