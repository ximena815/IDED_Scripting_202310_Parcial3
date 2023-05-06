public class Pool_LowObstacle : PoolBase
{
    public static Pool_LowObstacle Instance;
    private void Awake()
    {
        if (Instance != null) Destroy(this);
        else { Instance = this; DontDestroyOnLoad(this); }
    }
}
