using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private Image
        bullet1Icon,
        bullet2Icon,
        bullet3Icon;

    [SerializeField]
    private Text
        scoreLabel,
        timeLabel;

    [SerializeField]
    private PlayerController playerController;

    [SerializeField]
    private GameObject gameOverPanel;

    public void RestartLevel()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0, UnityEngine.SceneManagement.LoadSceneMode.Single);
    }

    // Start is called before the first frame update
    private System.Collections.IEnumerator Start()
    {
        if (playerController == null)
        {
            Debug.LogError("Can't initialize without player");
        }
        else
        {
            gameOverPanel?.SetActive(false);
        }

        yield return null;
        enabled = true;
    }

    // Update is called once per frame
    private void Update()
    {
        if (scoreLabel != null)
        {
            scoreLabel.text = playerController.PlayerScore;
        }

        if (timeLabel != null)
        {
            float currentTime = playerController.RemainingPlayTime;
            timeLabel.text = System.TimeSpan.FromSeconds(currentTime).ToString(@"mm\:ss");

            if (currentTime <= 1F)
            {
                enabled = false;
                gameOverPanel?.SetActive(true);
            }
        }
    }

    private void ToggleImageVisual(int iconIndex)
    {
        switch (iconIndex)
        {
            case 1:
                ToggleUIControl(bullet2Icon, true);
                ToggleUIControl(bullet1Icon, false);
                ToggleUIControl(bullet3Icon, false);
                break;

            case 2:
                ToggleUIControl(bullet3Icon, true);
                ToggleUIControl(bullet1Icon, false);
                ToggleUIControl(bullet2Icon, false);
                break;

            default:
                ToggleUIControl(bullet1Icon, true);
                ToggleUIControl(bullet2Icon, false);
                ToggleUIControl(bullet3Icon, false);

                break;
        }
    }

    private void ToggleUIControl(Graphic uiControl, bool val)
    {
        uiControl.enabled = val;
        uiControl.gameObject.SetActive(val);
    }
}