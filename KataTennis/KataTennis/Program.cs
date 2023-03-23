using KataTennis;

Console.WriteLine("Welcome to Kata Tennis");
Menu();

static void Menu()
{
    Console.WriteLine();
    Console.WriteLine("Choose player scored: Server or Receiver");
    string playerWon = Console.ReadLine();
    switch(playerWon.ToLower())
    {
        case "server":
            TennisGame.Player server = TennisGame.Player.Server;
            TennisGame.BallWin(server);
            if(TennisGame.isPlayerWon == false)
                Menu();
            break;
        case "receiver":
            TennisGame.Player receiver = TennisGame.Player.Receiver;
            TennisGame.BallWin(receiver);
            if (TennisGame.isPlayerWon == false)
                Menu();
            break;
        default:
            Menu();
            break;
    }
}
