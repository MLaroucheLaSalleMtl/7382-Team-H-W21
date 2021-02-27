using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    private NavMeshAgent enemy;
    public GameObject player;
    public float EnemyDistanceRun = 1000.0f;

    // Start is called before the first frame update
    void Start()
    {
        enemy = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.transform.position);

        if (distance < EnemyDistanceRun)
        {
            Vector3 dirToPlayer = transform.position - player.transform.position;
            Vector3 newPosition = transform.position - dirToPlayer;
            enemy.SetDestination(newPosition);
        }
    }
}
