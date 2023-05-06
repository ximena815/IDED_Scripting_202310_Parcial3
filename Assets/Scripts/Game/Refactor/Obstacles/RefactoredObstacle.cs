public abstract class RefactoredObstacle : ObstacleBase
{
    protected override GameControllerBase GameController => RefactoredGameController.Instance;

    protected override void DestroyObstacle(bool notify = false)
    {
        RefactoredGameController.Instance.DestroyObstacle(HP);
        GetComponent<PoolableObject>().RecycleObject();
    }
}