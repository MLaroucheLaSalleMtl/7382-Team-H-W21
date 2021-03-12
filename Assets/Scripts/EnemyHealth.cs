using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float enemyMaxHP = 100.0f;
    public float enemyCurrentHP;
    int damage = 5;

    // Start is called before the first frame update
    void Start()
    {
        enemyCurrentHP = enemyMaxHP;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            enemyCurrentHP -= damage;
        }
    }

    public void enemyDead()
    {
        if (enemyCurrentHP <= 0)
        {
            gameObject.SetActive(false);
        }
    }

    void Update()
    {
        enemyDead();
    }

}
