﻿namespace KataTennis;

public class TennisGame
{
    public enum Player
    {
        Server,
        Receiver
    }

    public int counter;
    private static int serverScore;
    private static int receiverScore;

    public int ServerScore { get => serverScore; set => serverScore = value; }
    public int ReceiverScore { get => receiverScore; set => receiverScore = value; }

    public static void BallWin(Player player)
    {
        if (player == Player.Server)
        {
            serverScore++;
            Console.WriteLine(ReturnScoreString(player, serverScore, receiverScore));
        }
        else if (player == Player.Receiver)
        {
            receiverScore++;
            Console.WriteLine(ReturnScoreString(player, serverScore, receiverScore));
        }
    }

    public static string ReturnScoreString(Player player, int score1, int score2)
    {
        serverScore = score1;
        receiverScore = score2;

        Dictionary<int, string> scoreDictionary = new Dictionary<int, string>();
        scoreDictionary.Add(0, "Love");
        scoreDictionary.Add(1, "Fifteen");
        scoreDictionary.Add(2, "Thirty");
        scoreDictionary.Add(3, "Forty");

        if (player == Player.Server)
        {
            if (scoreDictionary.ContainsKey(serverScore) && ((serverScore+1) + receiverScore != 6) && (serverScore+1) <= 3)
            {
                return $"{scoreDictionary[serverScore+1]} {scoreDictionary[receiverScore]}";
            }
            else
            {
                if ((serverScore+1 - receiverScore) == 0)
                    return "Server: Deuce";
                else if ((serverScore+1 - receiverScore) == 1)
                    return "Server: Advantage";
                else
                    return "Server Won!";
            }
        }
        else if (player == Player.Receiver)
        {
            if (scoreDictionary.ContainsKey(receiverScore) && (serverScore + (receiverScore+1) != 6) && (receiverScore+1) <= 3)
            {
                return $"{scoreDictionary[serverScore]} {scoreDictionary[receiverScore + 1]}";
            }
            else
            {
                if ((receiverScore+1 - serverScore) == 0)
                    return "Receiver: Deuce";
                else if ((receiverScore+1 - serverScore) == 1)
                    return "Receiver: Advantage";
                else
                    return "Receiver Won!";
            }
        }

        return "";
    }


}