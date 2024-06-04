using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawner : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public Transform spawnPoint; // Define the spawn point

    void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    IEnumerator SpawnEnemies()
    {
        while (true)
        {
            GameObject enemyToSpawn = enemyPrefabs[Random.Range(0, enemyPrefabs.Length)];
            Instantiate(enemyToSpawn, spawnPoint.position, Quaternion.identity); // Use the spawn point position
            yield return new WaitForSeconds(2);
        }
    }
}
