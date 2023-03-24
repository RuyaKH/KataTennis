namespace KataTennis;

public interface IScoreState
{
    public TennisGame Game { get; set; }

    public void BallWin(TennisGame.Player player)
    {

    }

}
