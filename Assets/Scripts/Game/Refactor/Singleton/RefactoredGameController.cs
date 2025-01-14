using System;

public sealed class RefactoredGameController : GameControllerBase
{
    public static RefactoredGameController Instance;
    protected override PlayerControllerBase PlayerController => RefactoredPlayerController.Instance;
    protected override UIManagerBase UiManager => RefactoredUIManager.Instance;
    protected override ObstacleSpawnerBase Spawner => RefactoredObstacleSpawner.Instance;
    
    public static event Action<int> UpdateScore;
    public static event Action UpdateUI;
    public static event Action GameOver;

    private void Awake()
    {
        if (Instance == null) { Instance = this; }
        else { Destroy(this); }
    }

    public void DestroyObstacle(int hp)
    {
        OnObstacleDestroyed(hp);
    }
    
    protected override void OnScoreChanged(int hp)
    {
        if (UpdateScore != null) UpdateScore(hp);
        if (UpdateUI != null) UpdateUI();
    }

    protected override void SetGameOver()
    {
        base.SetGameOver();
        if (GameOver != null) GameOver();
    }
}