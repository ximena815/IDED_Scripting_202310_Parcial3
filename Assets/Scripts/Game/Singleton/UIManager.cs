using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private Image[] bulletIcons;

    [SerializeField]
    private Text
        scoreLabel,
        timeLabel;

    [SerializeField]
    private PlayerController playerController;

    [SerializeField]
    private GameController gameController;

    [SerializeField]
    private GameObject gameOverPanel;

    public void RestartLevel()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }

    // Start is called before the first frame update
    private void Start()
    {
        if (playerController == null)
        {
            Debug.LogError("Can't initialize without player");
            enabled = false;
            scoreLabel.text = "Invalid";
            timeLabel.text = "99:99:99";
        }
        else
        {
            gameOverPanel?.SetActive(false);
            enabled = true;
            EnableIcon(0);
        }
    }

    // Update is called once per frame
    private void Update()
    {
        if (scoreLabel != null)
        {
            scoreLabel.text = playerController.Score.ToString();
        }

        if (timeLabel != null)
        {
            float currentTime = gameController.RemainingPlayTime + 1;
            timeLabel.text = currentTime.ToTimeFormatString();

            if (currentTime <= 1F)
            {
                enabled = false;
                gameOverPanel?.SetActive(true);
            }
        }
    }

    private void EnableIcon(int iconIndex)
    {
        switch (iconIndex)
        {
            case 1:
                ToggleUIControl(bulletIcons[0], true);
                ToggleUIControl(bulletIcons[1], false);
                ToggleUIControl(bulletIcons[2], false);
                break;

            case 2:
                ToggleUIControl(bulletIcons[1], true);
                ToggleUIControl(bulletIcons[0], false);
                ToggleUIControl(bulletIcons[2], false);
                break;

            default:
                ToggleUIControl(bulletIcons[2], true);
                ToggleUIControl(bulletIcons[0], false);
                ToggleUIControl(bulletIcons[1], false);

                break;
        }
    }

    private void ToggleUIControl(Graphic uiControl, bool val)
    {
        uiControl.enabled = val;
        uiControl.gameObject.SetActive(val);
    }
}