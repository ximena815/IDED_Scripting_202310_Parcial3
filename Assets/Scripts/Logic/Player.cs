public class Player
{
    public uint Score { get; private set; }

    public void UpdateScore(uint scoreAdd) => Score += scoreAdd;
}