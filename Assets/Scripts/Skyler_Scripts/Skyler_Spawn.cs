using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skyler_Spawn : MonoBehaviour
{
    private float nextSpawnTime;

    public GameObject cloud;

    private float spawnDelay = 0.5f;

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
        Vector3 randomCloud = new Vector3(Random.Range(0, 20), Random.Range(4, 10), 0);
        Instantiate(cloud, randomCloud, Quaternion.identity);
    }

    private bool ShouldSpawn()
    {
        return Time.time >= nextSpawnTime && Skyler_MinigameManager.Instance.timer.currentTime != 0 && Skyler_MinigameManager.Instance.playerHealth != 0;
    }
}
