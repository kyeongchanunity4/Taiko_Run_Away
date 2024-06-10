using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Condition : MonoBehaviour
{
    public int curValue;
    public int startValue;
    public int maxValue;

    public GameObject hpImagePrefab;
    public Transform hpContainer;
    private List<GameObject> hpImages = new List<GameObject>();

    //엔드 패널
    public GameObject pauseBtn;
    public GameObject endPanel;

    private void Start()
    {
        startValue = maxValue;
        curValue = startValue;

        for (int i = 0; i < curValue; i++)
        {
            GameObject healthImage = Instantiate(hpImagePrefab, hpContainer);
            hpImages.Add(healthImage);
        }
    }

    private void Update()
    {
        //라이프가 전부 깍였을 시 게임 종료
        if (curValue == 0)
        {
            Time.timeScale = 0.0f;
            pauseBtn.SetActive(false);
            endPanel.SetActive(true);
        }
    }

    public void DecreaseHP()
    {
        if(curValue > 0)
        {
            curValue--;
            Destroy(hpImages[curValue]);
            hpImages.RemoveAt(curValue);
        }
    }

    public void IncreaseHP()
    {
        if(curValue < maxValue)
        {
            GameObject healthImage = Instantiate (hpImagePrefab, hpContainer);
            hpImages.Insert(curValue, healthImage);
            curValue++;
        }
    }
}