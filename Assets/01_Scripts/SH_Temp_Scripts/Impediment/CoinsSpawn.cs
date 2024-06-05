using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsSpawn : MonoBehaviour
{
    [SerializeField] private ObjectPool pool;
    private Vector3[] spawnPoints =
    {
        new Vector3(-25, 1, 3),
        new Vector3(-25, 1, 0),
        new Vector3(-25, 1, -3)
    };

    private Vector3 curSpawnPoint;

    private float spawnPointSwapTime = 2.5f;
    private float curTimeForSwap;
    private float coinRespawnTime = 0.5f;
    private float curTime;

    private void Awake()
    {
        curSpawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
        pool = GetComponent<ObjectPool>();
    }

    private void Update()
    {
        curTimeForSwap += Time.deltaTime;
        curTime += Time.deltaTime;

        if(curTimeForSwap > spawnPointSwapTime)
        {
            curSpawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
            curTimeForSwap = 0;
        }

        if(curTime > coinRespawnTime)
        {
            SpawnCoin();
            curTime = 0;
        }
    }

    private void SpawnCoin()
    {
        GameObject coin = pool.SpawnFromPool("Coin");
        coin.transform.position = curSpawnPoint;
        coin.transform.rotation = new Quaternion(90, 90, 0, 0);
        coin.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
    }
}
