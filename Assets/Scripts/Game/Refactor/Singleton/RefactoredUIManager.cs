using System;

public class RefactoredUIManager : UIManagerBase
{
    public static RefactoredUIManager Instance;
    protected override PlayerControllerBase PlayerController => RefactoredPlayerController.Instance;
    protected override GameControllerBase GameController => RefactoredGameController.Instance;

    private void Awake()
    {
        if (Instance == null) { Instance = this; }
        else { Destroy(this); }
    }
    
    protected override void Start()
    {
        base.Start();

        RefactoredGameController.UpdateUI += UpdateScoreLabel;
        RefactoredGameController.GameOver += OnGameOver;
        RefactoredPlayerController.ChangeIcon += EnableIcon;
    }
}