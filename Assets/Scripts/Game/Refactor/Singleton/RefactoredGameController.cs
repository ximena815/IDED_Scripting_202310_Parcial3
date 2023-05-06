using System;

public sealed class RefactoredGameController : GameControllerBase
{
    public static RefactoredGameController Instance;
    protected override PlayerControllerBase PlayerController => RefactoredPlayerController.Instance;
    protected override UIManagerBase UiManager => RefactoredUIManager.Instance;
    protected override ObstacleSpawnerBase Spawner => RefactoredObstacleSpawner.Instance;

    public static event Action<int> UpdateScore;
    public static event Action GameOver;

    private void Awake()
    {
        if (Instance != null) Destroy(this);
        else { Instance = this; DontDestroyOnLoad(this); }
    }
    
    protected override void OnScoreChanged(int hp)
    {
        if (UpdateScore != null) UpdateScore(hp);
    }

    protected override void SetGameOver()
    {
        base.SetGameOver();
        if (GameOver != null) GameOver();
    }
}