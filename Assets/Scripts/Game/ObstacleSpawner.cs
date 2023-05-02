using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField]
    private bool debug;

    [SerializeField]
    private GameObject[] obstaclePrefabs;

    [SerializeField]
    [Range(0.5F, 2F)]
    private float instanceRate = 1.25F;

    private float
        minX,
        maxX,
        yPos;

    private int ObjectIndex
    {
        get
        {
            int result = 0;

            if (obstaclePrefabs.Length > 1)
            {
                result = Random.Range(result, obstaclePrefabs.Length);
            }

            return result;
        }
    }

    // Start is called before the first frame update
    private void Start()
    {
        SetBounds();
        InvokeRepeating("SpawnObject", 1F, instanceRate);
    }

    private void SetBounds()
    {
        if (debug)
        {
            maxX = 0;
            minX = 0;
            yPos = GameUtils.GetScreenDimensions().y;

            return;
        }

        // Retrieves the screen dimensions from camera to calculate a point in world coordinates matching the top right screen corner
        Vector2 bounds = GameUtils.GetScreenDimensions();

        // Only uses a fraction of the screen width to spawn objects
        maxX = bounds.GetUseableScreenWidth(GameUtils.SCREEN_WIDTH_PERCENT);
        minX = -maxX;

        // Always spawn objects from top
        yPos = bounds.y;
    }

    public void OnGameOver()
    {
        CancelInvoke("SpawnObject");
    }

    private void SpawnObject()
    {
        Instantiate(
            obstaclePrefabs[ObjectIndex],                // Retrieves the prefab to instantiate
            new Vector2(Random.Range(minX, maxX), yPos), // Sets the position to instantiate in 2D (Z is always 0)
            Quaternion.identity);
    }
}