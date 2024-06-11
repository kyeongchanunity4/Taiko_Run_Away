using UnityEngine;

public class VariousBtn : MonoBehaviour
{
    public GameObject gameTitle;
    public GameObject gameStoryBtn;
    public GameObject explainBtn;
    public GameObject gameStartBtn;
    public GameObject gameStoryPanel;
    public GameObject explainPanel;

    public void GameStory()
    {
        gameTitle.SetActive(false);
        gameStoryBtn.SetActive(false);
        explainBtn.SetActive(false);
        gameStartBtn.SetActive(false);
        gameStoryPanel.SetActive(true);
        explainPanel.SetActive(false);
    }

    public void ExplainGame()
    {
        gameTitle.SetActive(false);
        gameStoryBtn.SetActive(false);
        explainBtn.SetActive(false);
        gameStartBtn.SetActive(false);
        gameStoryPanel.SetActive(false);
        explainPanel.SetActive(true);
    }

    public void OutButton()
    {
        gameTitle.SetActive(true);
        gameStoryBtn.SetActive(true);
        explainBtn.SetActive(true);
        gameStartBtn.SetActive(true);
        gameStoryPanel.SetActive(false);
        explainPanel.SetActive(false);
    }
}
