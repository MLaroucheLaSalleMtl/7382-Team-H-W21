using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    public static EnemySpawnManager Instance;
    [SerializeField] public GameObject enemyPrefab;
    [SerializeField] public GameObject[] spawnPoints;
    public Player player;

    public int mLastSpawnIndex = -1;// make sure enemy won't spawn at the same point, -1 unique

    private void Awake()
    {
        Instance = this;
        
    }

    // Start is called before the first frame update
    void Start()
    {
       


        for (int i = 0; i < 6; i++)// in total of six, this is for starting the game
        {
            if (player.positionRaycast(spawnPoints[i]))// player can't see the spawn point 
            {
                var enemyItem = Instantiate(enemyPrefab, spawnPoints[i].transform.position, Quaternion.identity);
                var enemyAI = enemyItem.GetComponent<EnemyAI>();
                if (enemyAI == null) { enemyItem.AddComponent<EnemyAI>(); }
                enemyAI.target = player.transform;
            }
            //CreateEnemy();
        }
    }

    int mIndex = 0;
    public void CreateEnemy()// this is for after killing a enemy,
    {
        
        while (true)
        {
            var _index = Random.Range(0, spawnPoints.Length);// to generate a enemy at random
            if (player.positionRaycast(spawnPoints[_index]) && mLastSpawnIndex != _index)//to check can't see by the player, and not from the same spawnpoint
            {
                GameObject enemyItem = Instantiate(enemyPrefab, spawnPoints[_index].transform.position, Quaternion.Euler(new Vector3(0, 0, 0)));
                mLastSpawnIndex = _index;//update a new last spawn point

                var enemyAI = enemyItem.GetComponent<EnemyAI>();
                if (enemyAI == null) { enemyItem.AddComponent<EnemyAI>(); }
                enemyAI.target = player.transform;
                enemyItem.name = "Enemy_" + mIndex + "       randomIndex_" + _index;//the name for generated enemy,and how random it is 
                mIndex++;
                break;
            }
        }
    }
}
