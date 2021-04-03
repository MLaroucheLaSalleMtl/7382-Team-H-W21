using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    public GameObject enemy;
    public Transform[] spawnPoints;

    public float enemyMaxHP = 200.0f;
    public float enemyCurrentHP;

    public int x;
    public int z;
    public int enemyCount;

    // Start is called before the first frame update
    void Start()
    {
        enemyCurrentHP = enemyMaxHP;
    }

    public void callEnemySpawn()
    {
        StartCoroutine(enemySpawn());
    }

    IEnumerator enemySpawn()
    {
        while (enemyCount < 10)
        {
            x = Random.Range(511, 517);
            z = Random.Range(446, 452);
            Instantiate(enemy, new Vector3(x, 65, z), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            enemyCount += 1;
        }
    }
    //find a best spawn point and instantiate the enemy there
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
