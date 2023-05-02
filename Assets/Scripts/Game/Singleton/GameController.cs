using UnityEngine;

public sealed class GameController : GameControllerBase
{
    [SerializeField]
    private UIManager uiManager;

    [SerializeField]
    private PlayerController playerController;

    protected override PlayerControllerBase PlayerController => playerController;

    protected override UIManagerBase UiManager => UiManager;

    public override void UpdateScore(int scoreAdd)
    {
        PlayerController?.UpdateScore(scoreAdd);
    }

    protected override void SetGameOver()
    {
        UiManager?.OnGameOver();
        PlayerController?.OnGameOver();
        base.SetGameOver();
    }
}