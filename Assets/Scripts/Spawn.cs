using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    private float nextSpawnTime;

    public GameObject cloud;

    private float spawnDelay = 4f;

    

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        if (ShouldSpawn())
        {
            SpawnObject();
        }

        

    }

    private void SpawnObject()
    {
        nextSpawnTime = Time.time + spawnDelay;
        Vector3 randomCloud = new Vector3(Random.Range(0, 10), Random.Range(5, 10)*2, 0);
        Instantiate(cloud, randomCloud, Quaternion.identity);
    }

    private bool ShouldSpawn()
    {
        return Time.time >= nextSpawnTime;
    }
}
