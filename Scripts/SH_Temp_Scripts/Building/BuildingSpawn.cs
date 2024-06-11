using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingSpawn : MonoBehaviour
{
    // 빌딩 스폰 포인트 : x = -35 y = 0 z = (-)8
    [SerializeField] private ObjectPool pool;
    private Vector3 leftSpawnPoint = new Vector3(-35, 0, -8);
    private Vector3 rightSpawnPoint = new Vector3(-35, 0, 8);
    private Vector3 buildingScale = new Vector3(0.3f, 0.3f, 0.3f);
    private float buildingRespawnTime;
    private float curTime = 5f;

    private void Awake()
    {
        pool = GetComponent<ObjectPool>();
    }

    private void Update()
    {
        buildingRespawnTime = GameManager.Instance.objectRespawn;
        curTime += Time.deltaTime;
        if(curTime > buildingRespawnTime)
        {
            SpawnBuilding();
            curTime = 0;
        }
    }

    private void SpawnBuilding()
    {
        GameObject leftObject = pool.SpawnFromPool("Building");
        leftObject.transform.position = leftSpawnPoint;
        leftObject.transform.localScale = buildingScale;
        GameObject rightObject = pool.SpawnFromPool("Building");
        rightObject.transform.position = rightSpawnPoint;
        rightObject.transform.localScale = buildingScale;
    }
}
