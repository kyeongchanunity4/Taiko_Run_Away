using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<GameManager>();

                if (_instance == null)
                {
                    GameObject singletonObject = new GameObject();
                    _instance = singletonObject.AddComponent<GameManager>();
                    singletonObject.name = typeof(GameManager).ToString() + " (Singleton)";

                    DontDestroyOnLoad(singletonObject);
                }
            }
            return _instance;
        }
    }
    public float objectSpeed = 10f;
    public float objectRespawn = 3f;
    private float objectSpeedAtHighest = 20f;
    private float objectRespawnAtHighest = 1.5f;
    private float gameTime = 0;
    private float difficultyControllTime = 30f;

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject); // �� ������Ʈ�� �� ���� �� �ı����� �ʵ��� �մϴ�.
        }
        else if (_instance != this)
        {
            Destroy(gameObject); // ���� �ν��Ͻ��� ������ �� ������Ʈ�� �ı��մϴ�.
        }
    }

    private void Update()
    {
        gameTime += Time.deltaTime;
        if(gameTime > difficultyControllTime)
        {
            if((objectSpeed + 2f) <= objectSpeedAtHighest)
                objectSpeed += 2f;
            if((objectRespawn - 0.5f) >= objectRespawnAtHighest)
                objectRespawn -= 0.5f;
            gameTime = 0;
        }
    }
}
