public sealed class RefactoredGameController : GameControllerBase
{
    protected override PlayerControllerBase PlayerController => throw new System.NotImplementedException();

    protected override UIManagerBase UiManager => throw new System.NotImplementedException();

    protected override ObstacleSpawner Spawner => throw new System.NotImplementedException();

    protected override void OnScoreChanged(int scoreAdd)
    {
        throw new System.NotImplementedException();
    }
}