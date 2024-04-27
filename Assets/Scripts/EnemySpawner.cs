using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] Vector3 minSpawnPos, maxSpawnPos;
    [SerializeField] int desiredEnemyCount = 10;
    EnemyAttack[] enemies;
    int enemyCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpawnEnemies();
    }
    void SpawnEnemies()
    {
        bool isEnemyCountAboveOrHigherThanDesired = false;
        enemies = FindObjectsOfType<EnemyAttack>();
        enemyCount = enemies.Length;
        if (enemyCount >= desiredEnemyCount) isEnemyCountAboveOrHigherThanDesired = true;
        if (isEnemyCountAboveOrHigherThanDesired == true) return;

        float SpawnPosX = Random.Range(minSpawnPos.x, maxSpawnPos.x);
        float SpawnPosY = Random.Range(minSpawnPos.y, maxSpawnPos.y);
        float SpawnPosZ = Random.Range(minSpawnPos.z, maxSpawnPos.z);
        Vector3 spawnPos = new Vector3(SpawnPosX, SpawnPosY, SpawnPosZ);
        Instantiate(enemyPrefab,spawnPos,Quaternion.identity);
    }
}