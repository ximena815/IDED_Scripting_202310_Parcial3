using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float playTime = 60F;

    private Player player = new Player();
    public float RemainingPlayTime { get; private set; }

    public string PlayerScore { get => player?.Score.ToString(); }

    // Start is called before the first frame update
    private System.Collections.IEnumerator Start()
    {
        RemainingPlayTime = playTime;
        yield return null;
        enabled = true;
    }

    // Update is called once per frame
    private void Update()
    {
        UpdateTime();
        ProcessInput();
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

    private static void ProcessInput()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Fire
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            //Switch to bullet 1
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            //Switch to bullet 2
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            //Switch to bullet 3
        }
    }
}