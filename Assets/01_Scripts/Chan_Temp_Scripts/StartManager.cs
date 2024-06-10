using UnityEngine;

public class StartManager : MonoBehaviour
{
    public GameObject gameTitle;
    public GameObject gameStoryBtn;
    public GameObject explainBtn;
    public GameObject gameStartBtn;

    private void Start()
    {
        gameTitle.SetActive(true);
        gameStoryBtn.SetActive(true);
        explainBtn.SetActive(true);
        gameStartBtn.SetActive(true);
    }
}
