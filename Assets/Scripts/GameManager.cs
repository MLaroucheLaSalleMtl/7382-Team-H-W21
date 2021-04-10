using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public EnemySpawnManager enemySpawnManager;
    public EnemyHealth enemyHealth;
    public PlayerHealth playerHealth;
    
    public float surviveTime = 0.0f;
    public int enemiesKilled = 0;
    public int spawnedEnemies;

    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<GameManager>();
            }
            return instance;
        }
    }

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        enemySpawnManager.enemySpawn();
    }

    void Update()
    {
        enemyDie();
        playerDie();
    }

    public bool enemyDie()
    {
        if (enemyHealth.EnemyCurHP <= 0)
        {
            enemiesKilled += 1;
            gameObject.SetActive(false);
            enemySpawnManager.enemySpawn();
        }
        return true;
    }

    public bool playerDie()
    {
        if (playerHealth.PlayerCurHP <= 0)
        {
            gameObject.SetActive(false);
        }
        return true;
    }

    public void survivalTime() 
    { 

    }

}
