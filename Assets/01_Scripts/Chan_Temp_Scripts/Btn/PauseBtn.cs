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

    // 게임 중
    public void Resume()
    {
        pausePanel.SetActive(false); // 일시정지 패널 비활성화
        pauseBtn.SetActive(true); // 일시정지 버튼 활성화
        Time.timeScale = 1.0f;
        isPause = false;
    }

    // 게임 일시정지 했을 시 
    public void Pause()
    {
        pausePanel.SetActive(true); // 일시정지 패널 활성화
        pauseBtn.SetActive(false); // 일시정지 버튼 비활성화
        Time.timeScale = 0.0f;
        isPause = true;
    }
}
