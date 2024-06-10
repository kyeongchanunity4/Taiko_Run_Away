using UnityEngine;

public class StartManager : MonoBehaviour
{
    public GameObject gameTitle;
    public GameObject gameStoryBtn;
    public GameObject explainBtn;
    public GameObject gameStartBtn;
    public GameObject gameStoryPanel;
    public GameObject explainPanel;

    private void Start()
    {
        gameTitle.SetActive(true);
        gameStoryBtn.SetActive(true);
        explainBtn.SetActive(true);
        gameStartBtn.SetActive(true);
        gameStoryPanel.SetActive(false);
        explainPanel.SetActive(false);
    }
}
