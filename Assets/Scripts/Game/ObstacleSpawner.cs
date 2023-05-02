using UnityEngine;

public sealed class ObstacleSpawner : ObstacleSpawnerBase
{
    protected override void SpawnObject()
    {
        Instantiate(
            ObstaclePrefabs[ObjectIndex],                // Retrieves the prefab to instantiate
            new Vector2(Random.Range(MinX, MaxX), YPos), // Sets the position to instantiate in 2D (Z is always 0)
            Quaternion.identity);
    }
}