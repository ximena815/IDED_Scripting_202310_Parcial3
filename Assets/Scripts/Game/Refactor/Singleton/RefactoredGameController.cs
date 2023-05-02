public sealed class RefactoredGameController : GameControllerBase
{
    protected override PlayerControllerBase PlayerController => throw new System.NotImplementedException();

    protected override UIManagerBase UiManager => throw new System.NotImplementedException();

    protected override ObstacleSpawner Spawner => throw new System.NotImplementedException();

    public override void OnScoreChanged()
    {
        throw new System.NotImplementedException();
    }
}