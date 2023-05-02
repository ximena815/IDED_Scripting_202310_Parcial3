public class Obstacle : ObstacleBase
{
    private static GameController gameController;

    protected override GameControllerBase GameController
    {
        get
        {
            if (gameController == null)
            {
                gameController = FindObjectOfType<GameController>();
            }

            return gameController;
        }
    }

    protected override void NotifyObstacleDestroyed()
    {
        GameController?.SendMessage("OnObstacleDestroyed", HP);
    }
}