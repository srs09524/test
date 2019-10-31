using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public float spawnDelay = 0.1f;
    private float timeSinceLastSpawn;


    ObjectPool objectPool;

    private void Start()
    {
        objectPool = ObjectPool.Instance;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timeSinceLastSpawn += Time.deltaTime;
        if (timeSinceLastSpawn > spawnDelay)
        {

        objectPool.SpawnPoolObject("Pill", transform.position, Quaternion.identity);
        timeSinceLastSpawn = 0f;
       // Instantiate(g_object, transform.position, Quaternion.identity);   

        }
        
    }
}
