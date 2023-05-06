public class Pool_MidBullet : PoolBase
{
    public static Pool_MidBullet Instance;
    private void Awake()
    {
        if (Instance != null) Destroy(this);
        else { Instance = this; DontDestroyOnLoad(this); }
    }
}
