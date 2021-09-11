using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private GameObject powerupPrefab;
    
    private float spawnRange = 9;
    private int enemyCount;
    public int waveNumber = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemyWave(waveNumber);
        Instantiate(powerupPrefab, GenerateRandomSpawnPos(), powerupPrefab.transform.rotation);
    }

    private void SpawnEnemyWave(int waveNumber)
    {
        for (int i = 0; i < waveNumber; i++)
        {
            Instantiate(enemyPrefab, GenerateRandomSpawnPos(), enemyPrefab.transform.rotation);
        }
    }

    private Vector3 GenerateRandomSpawnPos()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomSpawnPos = new Vector3(spawnPosX, 0, spawnPosZ);
        return randomSpawnPos;
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<Enemy>().Length;
        if (enemyCount == 0)
        {
            waveNumber++;
            SpawnEnemyWave(waveNumber);
        }
    }
}
