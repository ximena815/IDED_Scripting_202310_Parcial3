public class Pool_MidObstacle : PoolBase
{
    public static Pool_MidObstacle Instance;
    private void Awake()
    {
        if (Instance != null) Destroy(this);
        else { Instance = this; DontDestroyOnLoad(this); }
    }
}
