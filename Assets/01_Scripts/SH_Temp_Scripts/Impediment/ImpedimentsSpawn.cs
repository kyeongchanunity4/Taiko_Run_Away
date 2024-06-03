using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpedimentsSpawn : MonoBehaviour
{
    [SerializeField] private ObjectPool pool;
    private Vector3[] spawnPoints = 
    { 
        new Vector3(-25, 1, 3), 
        new Vector3(-25, 1, 0), 
        new Vector3(-25, 1, -3) 
    };
    private int maxObjectCount = 2;
    private float impedimentRespawnTime = 5f;
    private float curTime;

    private void Awake()
    {
        pool = GetComponent<ObjectPool>();
    }

    private void Update()
    {
        curTime += Time.deltaTime;
        if(curTime > impedimentRespawnTime)
        {
            SpawnImpediment();
            curTime = 0;
        }
    }

    private void SpawnImpediment()
    {
        int curObjectCount = Random.Range(1, maxObjectCount+1);
        GameObject impediment1 = pool.SpawnFromPool("Impediment");
        int impediment1_spawnPointIndex = Random.Range(0, spawnPoints.Length); 
        impediment1.transform.position = spawnPoints[Random.Range(0, spawnPoints.Length)];
        if(curObjectCount > 1)
        {
            GameObject impediment2 = pool.SpawnFromPool("Impediment");
            impediment2.transform.position = spawnPoints[GetRandomExcluding(0, spawnPoints.Length, impediment1_spawnPointIndex)];
        }
    }

    private int GetRandomExcluding(int min, int max, int exclude)
    {
        int randomValue;
        do
        {
            randomValue = Random.Range(min, max);
        } while (randomValue == exclude);

        return randomValue;
    }
}
