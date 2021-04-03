using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRaycast : MonoBehaviour
{
    public float raycastDistance = 100f;
    public GameObject enemySpawn;

    // Start is called before the first frame update
    void Start()
    {
        positionRaycast();
        
    }
    //find the direction of the ray
    void positionRaycast()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, raycastDistance))
        {
            Quaternion spawnRotation = Quaternion.FromToRotation(Vector3.up, hit.normal);
            GameObject clone = Instantiate(enemySpawn, hit.point, spawnRotation);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
