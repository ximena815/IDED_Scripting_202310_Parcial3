using UnityEngine;

public class RefactoredObstacleSpawner : ObstacleSpawnerBase
{
    [SerializeField]
    private IPool obstacleLowPool;

    [SerializeField]
    private IPool obstacleMidPool;

    [SerializeField]
    private IPool obstacleHardPool;

    protected override void SpawnObject()
    {
        throw new System.NotImplementedException();
    }
}