using static KataTennis.TennisGame;

namespace KataTennis;

public class ReceiverMatchPointState : IScoreState
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
    public ReceiverMatchPointState(TennisGame game)
    {
        if(game.ReceiverScore+1 == 3 && game.ServerScore < 3)
        {
            Console.WriteLine("Receiver: Match Point");
        }
    }
}
