using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public EnemySpawnManager enemySpawn;
    public GameObject spawnPoint;

    RaycastHit hit;

    // Start is called before the first frame update
    void Start()
    {
        //positionRaycast(spawnPoint);
    }

    private void Update()
    {
        positionRaycast(spawnPoint);
    }

    // Update is called once per frame
    public bool positionRaycast(GameObject spawnPoint)
    {
        var ray = new Ray(transform.position, spawnPoint.transform.position - transform.position);
        if (Physics.Raycast(ray, out var hit, 500))
        {
            if (hit.transform.gameObject.tag != "SpawnPoint" && hit.transform.gameObject.tag != "Player")
            {
                return true;
            }
        }
        return false;
    }

    
}
