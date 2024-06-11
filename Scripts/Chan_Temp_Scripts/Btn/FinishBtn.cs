using UnityEngine;

public class FinishBtn : MonoBehaviour
{
    public GameObject endPanel;
    public GameObject pausePanel;

    //Finish 버튼을 클릭시 게임 종료와 함께 엔드 패널 활성화
    public void Finish()
    {
        Time.timeScale = 0.0f;
        Score.instance.SetEndPanelScore();
        pausePanel.SetActive(false);
        endPanel.SetActive(true);
    }
}
