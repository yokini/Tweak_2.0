using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacleScript : MonoBehaviour
{
    // Script to spawn obstacles
    // Declaring variables 
    public GameObject[] obstacles;
    public float timeBetweenSpawn;
    private float spawnTime;
    // Declaring variables for a specified area
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    
    void Update()
    {
        // Assigning the rate at which the obstacles are spawned
        if (Time.time > spawnTime)
        {
            Spawn();
            spawnTime = Time.time + timeBetweenSpawn;
        }
        // Instantiating obstacles faster over time
        timeBetweenSpawn = timeBetweenSpawn - 0.0001f;
    }

    // Function to instantiate Obstacle prefabs from the array
    void Spawn()
    {
        // Assign a random number to n, for random instantiation
        int n = Random.Range(0, obstacles.Length);
        // Randomize position within specified area
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        // Instantiating random obstacle at said position
        Instantiate(obstacles[n], transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }
}
