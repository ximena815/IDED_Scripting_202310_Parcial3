using UnityEngine;

public class RefactoredObstacleSpawner : ObstacleSpawnerBase
{
    public static RefactoredObstacleSpawner Instance;
    
    [SerializeField]
    private PoolBase obstacleLowPool;

    [SerializeField]
    private PoolBase obstacleMidPool;

    [SerializeField]
    private PoolBase obstacleHardPool;

    private void Awake()
    {
        if (Instance == null) { Instance = this; }
        else { Destroy(this); }
    }
    
    protected override void SpawnObject()
    {
        throw new System.NotImplementedException();
    }
}