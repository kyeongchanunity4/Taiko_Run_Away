using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleBtn : MonoBehaviour
{
    public void Title()
    {
        // Title버튼을 눌렀을 시 처음 화면으로 돌아감
        SceneManager.LoadScene(0);
    }
}
