public class RefactoredObstacle : ObstacleBase
{
    protected override GameControllerBase GameController => throw new System.NotImplementedException();

    protected override void NotifyObstacleDestroyed()
    {
        throw new System.NotImplementedException();
    }
}