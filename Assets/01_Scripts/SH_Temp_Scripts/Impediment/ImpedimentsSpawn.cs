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

    private Vector3[] specialSpawnPoints =
    {
        new Vector3(-25, 1, 0),
        new Vector3(-25, 1, -4)
    };

    private int maxObjectCount = 2;
    private float impedimentRespawnTime;
    private float curTime;
    private int isSpecialPercent;

    private void Awake()
    {
        pool = GetComponent<ObjectPool>();
    }

    private void Update()
    {
        impedimentRespawnTime = GameManager.Instance.objectRespawn;
        curTime += Time.deltaTime;
        if(curTime > impedimentRespawnTime)
        {
            isSpecialPercent = Random.Range(0, 10);
            if(isSpecialPercent >= 0 && isSpecialPercent < 4)
            {
                SpawnSpecialImpediment();
            }
            else
            {
                SpawnImpediment();
            }
            curTime = 0;
        }
    }

    private void SpawnImpediment()
    {
        int curObjectCount = Random.Range(1, maxObjectCount+1);
        GameObject impediment1 = pool.SpawnFromPool("Impediment");
        int impediment1_spawnPointIndex = Random.Range(0, spawnPoints.Length); 
        impediment1.transform.position = spawnPoints[impediment1_spawnPointIndex];
        if(curObjectCount > 1)
        {
            GameObject impediment2 = pool.SpawnFromPool("Impediment");
            impediment2.transform.position = spawnPoints[GetRandomExcluding(0, spawnPoints.Length, impediment1_spawnPointIndex)];
        }
    }

    private void SpawnSpecialImpediment()
    {
        GameObject specialImpediment = pool.SpawnFromPool("SpecialImpediment");
        int specialImpediment_spawnPointIndex = Random.Range(0, specialSpawnPoints.Length);
        specialImpediment.transform.position = specialSpawnPoints[specialImpediment_spawnPointIndex];
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
