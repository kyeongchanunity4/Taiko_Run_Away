using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryBtn : MonoBehaviour
{
    public void Retry()
    {
        // Retry��ư�� Ŭ���� ����ȭ������ ���ư�
        // ���߿� ���ξ����� ����
        SceneManager.LoadScene("DevScene_Chan");
    }
}
