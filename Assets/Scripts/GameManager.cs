using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public EnemySpawnManager enemySpawnManager;
    public EnemyHealth enemyHealth;
    public PlayerHealth playerHealth;
    public EnemyLeft enemyleft;
   
    public float surviveTime = 0.0f;
    public int enemiesLeft;
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
        enemiesLeft = enemyleft.enemycount;
    }

    void Update()
    {
        enemyDie();
        playerDie();
        enemiesLeft = enemyleft.enemycount;
    }

    public bool enemyDie()
    {
        enemyHealth = new EnemyHealth();
        enemySpawnManager = new EnemySpawnManager();
        if (enemyHealth.EnemyCurHP <= 0)
        {
            
            gameObject.SetActive(false);
            enemySpawnManager.CreateEnemy();
            enemyleft.enemykilled();
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

    public void EneGame()
    {
        Debug.Log("GAME OVER");
    }

}
