using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float maxHP;
    public float currentHP;
    public GameObject HPBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHP = maxHP;
    }

    public void deductHP(float DeductHP)
    {
        maxHP -= DeductHP;
        if (maxHP <= 0)
        {
            enemyDead();
        }
    }

    public void enemyDead()
    {
        Destroy(gameObject);
    }

    void decreaseHP()
    {
        float damagedHP = currentHP / maxHP;
        setHPBar(damagedHP);
    }

    public void setHPBar(float enemyHP)
    {
        HPBar.transform.localScale = new Vector3(enemyHP, HPBar.transform.localScale.y, HPBar.transform.localScale.z);
    }

}
