using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField]
    private float playTime = 60F;

    public float RemainingPlayTime { get; private set; }

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

            // Game over stuff
            enabled = false;
        }
    }
}