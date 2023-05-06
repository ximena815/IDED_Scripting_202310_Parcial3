using System;

public class RefactoredUIManager : UIManagerBase
{
    public static RefactoredUIManager Instance;
    protected override PlayerControllerBase PlayerController => throw new System.NotImplementedException();

    protected override GameControllerBase GameController => throw new System.NotImplementedException();

    private void Awake()
    {
        if (Instance != null) Destroy(this);
        else { Instance = this; DontDestroyOnLoad(this); }
    }
}