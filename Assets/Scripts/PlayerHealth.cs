using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    
    public float playerMaxHP = 100.0f;
    public float playerCurrentHP;
    int damage = 30;
    

    // Start is called before the first frame update
    void Start()
    {
        playerCurrentHP = playerMaxHP;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            playerCurrentHP -= damage;
        }
    }

    public void playerDead()
    {
        if (playerCurrentHP <= 0)
        {
            gameObject.SetActive(false);
        }
    }

    void Update()
    {
        playerDead();
    }
}
