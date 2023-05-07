public class Pool_MidBullet : PoolBase
{
    public static Pool_MidBullet Instance;
    private void Awake()
    {
        if (Instance == null) { Instance = this; }
        else { Destroy(this); }
    }
}
