public class RefactoredGameController : GameControllerBase
{
    protected override PlayerControllerBase PlayerController => throw new System.NotImplementedException();

    protected override UIManagerBase UiManager => throw new System.NotImplementedException();

    public override void UpdateScore(int scoreAdd)
    {
        throw new System.NotImplementedException();
    }
}