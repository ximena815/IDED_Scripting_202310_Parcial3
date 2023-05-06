public class RefactoredPlayerController : PlayerControllerBase
{
    public static RefactoredPlayerController Instance;
    protected override bool NoSelectedBullet => throw new System.NotImplementedException();

    private void Awake()
    {
        if (Instance != null) Destroy(this);
        else { Instance = this; DontDestroyOnLoad(this); }
    }

    protected override void Start()
    {
        base.Start();
        RefactoredGameController.UpdateScore += UpdateScore;
        RefactoredGameController.GameOver += OnGameOver;
    }
    
    protected override void Shoot()
    {
        //base.Shoot();
    }

    protected override void SelectBullet(int index)
    {
        //base.SelectBullet(index);
    }
}