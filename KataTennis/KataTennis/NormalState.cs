using static KataTennis.TennisGame;

namespace KataTennis;

public class NormalState : IScoreState
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

    public NormalState(Dictionary<int,string> scoreDictionary, TennisGame game, Player player)
    {
        int serverScore = game.ServerScore;
        int receiverScore = game.ReceiverScore;
        if (player == Player.Server)
        {
            if (scoreDictionary.ContainsKey(serverScore) && ((serverScore + 1) + receiverScore != 6) && (serverScore + 1) <= 3)
            {
                Console.WriteLine($"{scoreDictionary[serverScore + 1]} {scoreDictionary[receiverScore]}");
            }
        }
        else if(player == Player.Receiver)
        {
            if (scoreDictionary.ContainsKey(receiverScore) && (serverScore + (receiverScore + 1) != 6) && (receiverScore + 1) <= 3)
            {
                Console.WriteLine($"{scoreDictionary[serverScore]} {scoreDictionary[receiverScore + 1]}");
            }
        }
    }
}
