using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    private float EnemyMaxHP = 200;
    public float EnemyCurHP;
    private float EnemyMinHP = 0; 

    // Start is called before the first frame update
    void Start()
    {
        EnemyCurHP = EnemyMaxHP;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


   // If the Player hits the enemy, enemy gets damage.
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "PlayerWeapon")
        {
            EnemyCurHP -= 10;
            MinHealth();
        }
    }

    public void MaxHealth()
    {
        if (EnemyCurHP > EnemyMaxHP)
        {
            EnemyCurHP = EnemyMaxHP;
        }
    }

    private void MinHealth()
    {
        if (EnemyCurHP < EnemyMinHP)
        {
            EnemyCurHP = EnemyMinHP;
        }
    }
}
