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