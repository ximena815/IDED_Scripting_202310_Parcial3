using System;
using UnityEngine;

public class RefactoredPlayerController : PlayerControllerBase
{
    public static RefactoredPlayerController Instance;
    protected override bool NoSelectedBullet => throw new System.NotImplementedException();

    private PoolBase currentBulletPool;

    [SerializeField] private float bulletLifeTime = 2f;

    public static event Action<int> ChangeIcon;

    private void Awake()
    {
        if (Instance == null) { Instance = this; }
        else { Destroy(this); }
    }

    protected override void Start()
    {
        base.Start();
        RefactoredGameController.UpdateScore += UpdateScore;
        RefactoredGameController.GameOver += OnGameOver;
    }
    
    protected override void Shoot()
    {
        GameObject bullet = currentBulletPool.RetrieveInstance();
        if (bullet != null)
        {
            bullet.transform.position = spawnPos.position;
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * shootForce, ForceMode.Force);
            StartCoroutine(bullet.GetComponent<PoolableObject>().Cycle(bulletLifeTime));
        }
    }

    protected override void SelectBullet(int index)
    {
        switch (index)
        {
            case 0:
                currentBulletPool = Pool_LowBullet.Instance;
                break;
            case 1:
                currentBulletPool = Pool_MidBullet.Instance;
                break;
            case 2: ;
                currentBulletPool = Pool_HardBullet.Instance;
                break;
            default:
                currentBulletPool = Pool_LowBullet.Instance;
                break;
        }
        if (ChangeIcon != null) ChangeIcon(index);
    }
}