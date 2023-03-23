using KataTennis;

namespace KataTennisTests
{
    public class TennisTests
    {
        [TestCase(TennisGame.Player.Server, 1, 0, "Thirty Love")]
        [TestCase(TennisGame.Player.Receiver, 0, 0, "Love Fifteen")]
        [TestCase(TennisGame.Player.Server, 2, 0, "Forty Love")]
        [TestCase(TennisGame.Player.Server, 3, 0, "Server Won!")]
        [TestCase(TennisGame.Player.Server, 3, 3, "Server: Advantage")]
        [TestCase(TennisGame.Player.Receiver, 3, 3, "Receiver: Advantage")]
        public void WhenPlayerScores_ReturnScoreString(TennisGame.Player playerTurn, int score1, int score2, string expected)
        {
            string result = TennisGame.ReturnScoreString(playerTurn, score1, score2); ;
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}