using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [System.Serializable]
    public class Pool
    {
        public string tag;
        public GameObject[] prefabs;
        public int size;
    }

    public List<Pool> pools = new List<Pool>();
    public Dictionary<string, Queue<GameObject>> PoolDictionary;

    private void Awake()
    {
        PoolDictionary = new Dictionary<string, Queue<GameObject>>();
        int prefabsIndex;
        foreach(var pool in pools)
        {
            Queue<GameObject> queue = new Queue<GameObject>();
            for(int i = 0; i < pool.size; i++)
            {
                prefabsIndex = Random.Range(0, pool.prefabs.Length);
                GameObject obj = Instantiate(pool.prefabs[prefabsIndex], transform);
                obj.SetActive(false);
                queue.Enqueue(obj);
            }

            PoolDictionary.Add(pool.tag, queue);
        }
    }

    public GameObject SpawnFromPool(string tag)
    {
        if (!PoolDictionary.ContainsKey(tag))
        {
            return null;
        }

        GameObject obj = PoolDictionary[tag].Dequeue();
        PoolDictionary[tag].Enqueue(obj);

        obj.SetActive(true);
        return obj;
    }
}
