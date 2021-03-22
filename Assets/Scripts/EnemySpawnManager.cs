using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    public GameObject enemy;
    public int x;
    public int z;
    public int enemyCount;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(enemyDrop());
    }

    IEnumerator enemyDrop()
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
