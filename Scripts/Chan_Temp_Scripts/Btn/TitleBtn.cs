using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleBtn : MonoBehaviour
{
    public void Title()
    {
        // Title��ư�� ������ �� ó�� ȭ������ ���ư�
        SceneManager.LoadScene(0);
    }
}
