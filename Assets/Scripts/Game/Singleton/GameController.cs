using UnityEngine;

public sealed class GameController : GameControllerBase
{
    [SerializeField]
    private UIManager uiManager;

    [SerializeField]
    private PlayerController playerController;

    [SerializeField]
    private ObstacleSpawner obstacleSpawner;

    protected override PlayerControllerBase PlayerController => playerController;

    protected override UIManagerBase UiManager => uiManager;

    protected override ObstacleSpawner Spawner => obstacleSpawner;

    public override void OnScoreChanged()
    {
        UiManager?.UpdateScoreLabel();
    }

    protected override void SetGameOver()
    {
        UiManager?.OnGameOver();
        PlayerController?.OnGameOver();
        Spawner?.OnGameOver();
        base.SetGameOver();
    }
}