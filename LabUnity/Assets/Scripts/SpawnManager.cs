using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public GameObject powerupPrefab;
    private int animalIndex;
    private int spawnRangeX = 14;

    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomObjects",startDelay,spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnRandomObjects()
    {
        //Randomly generate random animal in random posiition
        animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPosEnemy = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 2, 16);
        Vector3 spawnPosPowerup = new Vector3(Random.Range(-spawnRangeX,spawnRangeX),2,Random.Range(-spawnRangeX,spawnRangeX));
        Instantiate(animalPrefabs[animalIndex], spawnPosEnemy, animalPrefabs[animalIndex].transform.rotation);
        Instantiate(powerupPrefab, spawnPosPowerup, powerupPrefab.transform.rotation);
    }
}