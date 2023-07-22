using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public HealthController enemyPrefab;
    public static int enemyCount;
    public static int aliveEnemies;
    public static int killEnemy;
    public static float minSpawnDelay = 1f;
    public static float maxSpawnDelay = 15f;
    public Transform[] EnemyPosition;
    public static bool againSpawn = false;
    public int hpUP = 2;
    public static float speedUP = 0.1f;

    void Start()
    {
        MonstersUp.s_MonstersUp.OnMonstersUpgradeed += OnMonsterUpgraded;
        StartCoroutine(SpawnEnemy());
    }

    public void Update()
    {

        if (againSpawn == true)
        {
            StartCoroutine(SpawnEnemy());
            againSpawn = false;
        }
    }

    IEnumerator SpawnEnemy()
    {
        while (true)
        {
            float delay = Random.Range(minSpawnDelay, maxSpawnDelay);
            yield return new WaitForSeconds(delay);



            HealthController newZombie = Instantiate(enemyPrefab, EnemyPosition[Random.Range(0, 15)].position, Quaternion.identity);
            newZombie.SetHp(hpUP);
            enemyCount++;
            aliveEnemies++;
           

        }
    }

    public void OnMonsterUpgraded()
    {
        maxSpawnDelay--;
        hpUP++;
        speedUP += 0.1f;
        if (maxSpawnDelay == 0)
        {
            maxSpawnDelay = 1;
        }

    }
}