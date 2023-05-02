using UnityEngine;

public abstract class GameControllerBase : MonoBehaviour
{
    [SerializeField]
    private float playTime = 60F;

    public float RemainingPlayTime { get; private set; }

    protected abstract PlayerControllerBase PlayerController { get; }
    protected abstract UIManagerBase UiManager { get; }

    protected abstract ObstacleSpawner Spawner { get; }

    //public abstract void OnObstacleDestroyed(int hp);

    public abstract void OnScoreChanged();

    public void OnObstacleDestroyed(int hp)
    {
        UpdateScore(hp);
        OnScoreChanged();
    }

    protected virtual void SetGameOver()
    {
        enabled = false;
    }

    protected void UpdateScore(int scoreAdd)
    {
        PlayerController?.UpdateScore(scoreAdd);
    }

    private void Start()
    {
        RemainingPlayTime = playTime;
    }

    // Update is called once per frame
    private void Update()
    {
        UpdateTime();
    }

    private void UpdateTime()
    {
        RemainingPlayTime -= Time.deltaTime;

        if (RemainingPlayTime <= 0F)
        {
            RemainingPlayTime = 0F;

            SetGameOver();
        }
    }
}