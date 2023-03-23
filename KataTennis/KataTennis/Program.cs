using KataTennis;

Console.WriteLine("Welcome to Kata Tennis");
Menu();

static void Menu()
{
    Console.WriteLine("Choose player won: Server or Receiver");
    string playerWon = Console.ReadLine();
    switch(playerWon.ToLower())
    {
        case "server":
            TennisGame.Player server = TennisGame.Player.Server;
            TennisGame.BallWin(server);
            break;
        case "receiver":
            TennisGame.Player receiver = TennisGame.Player.Server;
            TennisGame.BallWin(receiver);
            break;
        default:
            Menu();
            break;
    }
}
