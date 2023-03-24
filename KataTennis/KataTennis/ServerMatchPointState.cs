using static KataTennis.TennisGame;

namespace KataTennis;

public class ServerMatchPointState : IScoreState
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
    public ServerMatchPointState(TennisGame game)
    {
        if (game.ServerScore + 1 == 3 && game.ReceiverScore < 3)
        {
            Console.WriteLine("Receiver: Match Point");
        }
    }
}
