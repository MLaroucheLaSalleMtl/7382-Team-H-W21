using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    [SerializeField]public GameObject enemyPrefab;
    [SerializeField]public GameObject[] spawnPoints;
    public Player player;

    public EnemyHealth enemyHealth;

    public Vector3 spawnLocation;

    private void Awake()
    {
        spawnPoints = GameObject.FindGameObjectsWithTag("SpawnPoint");
    }

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("PlayerWeapon").GetComponent<Player>();
        enemyPrefab = (GameObject)Resources.Load("Enemy", typeof(GameObject));
        spawnLocation = enemyPrefab.transform.position;
        enemySpawn();
    }

    public void enemySpawn()
    {
        int spawn = Random.Range(0, spawnPoints.Length);

        if (player.positionRaycast(spawnPoints[0]))
            Debug.Log("Wall found");
        GameObject.Instantiate(enemyPrefab, spawnPoints[spawn].transform.position, transform.rotation);   
    }

    // Update is called once per frame
    private void Update()
    {
        
    }
}
