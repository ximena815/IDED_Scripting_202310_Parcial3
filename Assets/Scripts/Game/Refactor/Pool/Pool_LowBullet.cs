public class Pool_LowBullet : PoolBase
{
    public static Pool_LowBullet Instance;
    private void Awake()
    {
        if (Instance != null) Destroy(this);
        else { Instance = this; DontDestroyOnLoad(this); }
    }
}
