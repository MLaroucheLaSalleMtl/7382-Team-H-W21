using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public EnemySpawnManager enemySpawnManager;

    public bool enemyDied;

    public int enemyMaxHP = 100;
    public int enemyCurrentHP = 0;
    public int enemiesLeft = 0;
    public int enemiesKilled = 0;
    public float SurvivalTime = 0.0f;

    void Start()
    {
        enemyCurrentHP = enemyMaxHP;
        enemySpawnManager.callEnemySpawn();
    }

    public void enemyDie()
    {
        if (enemyCurrentHP <= 0)
        {
            gameObject.SetActive(false);
        }
    }

    public void enemyKilled()
    {
        if (enemyDied == true)
        {
            enemyDie();
            enemiesKilled += 1;
        }

    }
    public void enemyLeft()
    {
        if (enemyDied == true)
        {
            
        }
    }
    public void survivalTime() { }
    public void loadLevels() { }

    void Update()
    {
        
    }
}
