public class Pool_HardObstacle : PoolBase
{
    public static Pool_HardObstacle Instance;
    private void Awake()
    {
        if (Instance != null) Destroy(this);
        else { Instance = this; DontDestroyOnLoad(this); }
    }
}
