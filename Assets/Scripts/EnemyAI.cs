using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyAI : MonoBehaviour
{
    /// <summary>
    /// Make Enemy AI to chase the Player
    /// </summary>
    
    public Transform target; //destination
    private NavMeshAgent nav;
    private Animator anim;
    
    private void Awake()
    {
        nav = GetComponent<NavMeshAgent>();
    }

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, target.position);
        
        if (distance > 1.5)
        {
            nav.updatePosition = true;
            nav.SetDestination(target.position);
            anim.SetBool("Run", true);
            anim.SetBool("Attack1", false);
        }
        else
        {
            nav.updatePosition = false;
            anim.SetBool("Run", false);
            anim.SetBool("Attack1", true);
        }
    }

    
}
