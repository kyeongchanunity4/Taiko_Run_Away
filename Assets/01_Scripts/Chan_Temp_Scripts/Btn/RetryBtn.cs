using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryBtn : MonoBehaviour
{
    public void Retry()
    {
        // Retry버튼을 클릭시 게임화면으로 돌아감
        // 나중에 메인씬으로 변경
        SceneManager.LoadScene("DevScene_Chan");
    }
}
