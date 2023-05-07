public class Pool_HardBullet : PoolBase
{
    public static Pool_HardBullet Instance;
    private void Awake()
    {
        if (Instance == null) { Instance = this; }
        else { Destroy(this); }
    }
}
