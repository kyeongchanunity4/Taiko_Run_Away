using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStartBtn : MonoBehaviour
{
    public void GameStart()
    {
        // GameStart 버튼 눌렀을 시 게임 화면으로 넘어감
        SceneManager.LoadScene("DevScene_Chan");
    }
}
