public class Pool_LowObstacle : PoolBase
{
    public static Pool_LowObstacle Instance;
    private void Awake()
    {
        if (Instance == null) { Instance = this; }
        else { Destroy(this); }
    }
}
