using UnityEngine;

public class PauseBtn : MonoBehaviour
{
    public static bool isPause;
    public GameObject pausePanel;
    public GameObject pauseBtn;

    private void Start()
    {
        isPause = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pausePanel)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    // ���� ��
    public void Resume()
    {
        pausePanel.SetActive(false); // �Ͻ����� �г� ��Ȱ��ȭ
        pauseBtn.SetActive(true); // �Ͻ����� ��ư Ȱ��ȭ
        Time.timeScale = 1.0f;
        isPause = false;
    }

    // ���� �Ͻ����� ���� �� 
    public void Pause()
    {
        pausePanel.SetActive(true); // �Ͻ����� �г� Ȱ��ȭ
        pauseBtn.SetActive(false); // �Ͻ����� ��ư ��Ȱ��ȭ
        Time.timeScale = 0.0f;
        isPause = true;
    }
}
