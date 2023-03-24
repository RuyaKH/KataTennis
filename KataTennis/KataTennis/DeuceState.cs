using static KataTennis.TennisGame;

namespace KataTennis;

public class DeuceState : IScoreState
{
    TennisGame game = new TennisGame();
    public TennisGame Game { get => game; set => game = value; }

    public void BallWin(TennisGame.Player player)
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
    public DeuceState(TennisGame game,Player player)
    {
        if (player == Player.Server)
        {
            if ((game.ServerScore + 1 - game.ReceiverScore) == 0)
                Console.WriteLine("Server: Deuce");
        }
        else if (player == Player.Receiver)
        {
            if ((game.ReceiverScore + 1 - game.ServerScore) == 0)
                Console.WriteLine("Receiver: Deuce");
        }
    }
}

