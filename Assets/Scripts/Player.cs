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
       
        //positionRaycast();
    }

    private void Update()
    {
        positionRaycast(spawnPoint);
    }

    // Update is called once per frame
    public bool positionRaycast(GameObject spawnPoint)
    {

        bool findObject = false;
        float maxDistance = Vector3.Distance(transform.position, spawnPoint.transform.position);
        //start from the character, and going to the direction of the spawn point
        //Vector3.Distance();
        Vector3 direction = spawnPoint.transform.position - transform.position;
        Ray ray = new Ray(transform.position, direction);
        if (Physics.Raycast(ray, maxDistance))
        {
            findObject = true;
            Debug.DrawRay(ray.origin, hit.point);
            enemySpawn.enemySpawn();
        }
        return findObject;
    }

    //public void callEnemySpawn()
    //{
    //    StartCoroutine(enemySpawn());
    //}

    //IEnumerator enemySpawn()
    //{
    //    while (enemyCount < 10)
    //    {
    //        x = Random.Range(511, 517);
    //        z = Random.Range(446, 452);
    //        Instantiate(enemy, new Vector3(x, 65, z), Quaternion.identity);
    //        yield return new WaitForSeconds(0.1f);
    //        enemyCount += 1;
    //    }
    //}
}
