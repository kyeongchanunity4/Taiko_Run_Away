using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStartBtn : MonoBehaviour
{
    public void GameStart()
    {
        // GameStart ��ư ������ �� ���� ȭ������ �Ѿ
        SceneManager.LoadScene(1);
    }
}
