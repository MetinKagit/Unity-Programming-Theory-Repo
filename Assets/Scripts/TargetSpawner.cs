using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawner : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public Transform spawnPoint; // Define the spawn point
    public float minX; 
    public float maxX;
    void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    IEnumerator SpawnEnemies()
    {
        while (true)
        {
            GameObject enemyToSpawn = enemyPrefabs[Random.Range(0, enemyPrefabs.Length)];
            float spawnPosX = Random.Range(minX, maxX); // Generate a random x-coordinate within the spawn range
            Vector3 spawnPos = new Vector3(spawnPosX, spawnPoint.position.y, spawnPoint.position.z); // Create a new spawn position
            Instantiate(enemyToSpawn, spawnPos, Quaternion.identity); // Use the new spawn position
            yield return new WaitForSeconds(2);
        }
    }
}
