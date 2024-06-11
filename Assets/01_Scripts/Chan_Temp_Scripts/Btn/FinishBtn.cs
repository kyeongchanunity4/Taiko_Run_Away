using UnityEngine;

public class FinishBtn : MonoBehaviour
{
    public GameObject endPanel;
    public GameObject pausePanel;

    //Finish ��ư�� Ŭ���� ���� ����� �Բ� ���� �г� Ȱ��ȭ
    public void Finish()
    {
        Time.timeScale = 0.0f;
        Score.instance.SetEndPanelScore();
        pausePanel.SetActive(false);
        endPanel.SetActive(true);
    }
}
