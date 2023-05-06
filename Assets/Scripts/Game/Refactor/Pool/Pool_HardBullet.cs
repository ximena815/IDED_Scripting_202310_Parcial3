public class Pool_HardBullet : PoolBase
{
    public static Pool_HardBullet Instance;
    private void Awake()
    {
        if (Instance != null) Destroy(this);
        else { Instance = this; DontDestroyOnLoad(this); }
    }
}
