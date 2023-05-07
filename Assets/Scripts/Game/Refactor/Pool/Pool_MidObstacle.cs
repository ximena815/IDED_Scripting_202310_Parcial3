public class Pool_MidObstacle : PoolBase
{
    public static Pool_MidObstacle Instance;
    private void Awake()
    {
        if (Instance == null) { Instance = this; }
        else { Destroy(this); }
    }
}
