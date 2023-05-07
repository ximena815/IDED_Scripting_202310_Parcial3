public class Pool_HardObstacle : PoolBase
{
    public static Pool_HardObstacle Instance;
    private void Awake()
    {
        if (Instance == null) { Instance = this; }
        else { Destroy(this); }
    }
}
