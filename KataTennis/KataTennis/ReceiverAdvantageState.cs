using static KataTennis.TennisGame;

namespace KataTennis;

public class ReceiverAdvantageState : IScoreState
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
    public ReceiverAdvantageState()
    {
        if ((game.ReceiverScore + 1 - game.ServerScore) == 1)
            Console.WriteLine("Receiver: Advantage");
    }
}
