public abstract class RefactoredObstacle : ObstacleBase
{
    protected override GameControllerBase GameController => RefactoredGameController.Instance;

    protected override void DestroyObstacle(bool notify = false)
    {
        if (notify) RefactoredGameController.Instance.DestroyObstacle(HP);
        GetComponent<PoolableObject>().RecycleObject();
    }
}