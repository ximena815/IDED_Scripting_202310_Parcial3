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
        GameObject obstacle;
        switch (Random.Range(0, 3))
        {
            case 0:
                obstacle = obstacleLowPool.RetrieveInstance();
                break;
            case 1:
                obstacle = obstacleMidPool.RetrieveInstance();
                break;
            case 2:
                obstacle = obstacleHardPool.RetrieveInstance();
                break;
            default:
                obstacle = obstacleLowPool.RetrieveInstance();
                break;
        }
        obstacle.transform.position = new Vector2(Random.Range(MinX, MaxX), YPos);
    }
}