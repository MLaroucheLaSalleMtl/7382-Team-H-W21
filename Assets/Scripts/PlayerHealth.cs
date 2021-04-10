using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerHealth : MonoBehaviour
{
    private float PlayerMaxHP = 100 ;
    public float PlayerCurHP;
    private float PlayerMinHP = 0;
    // Start is called before the first frame update
    void Start()
    {
        PlayerCurHP = PlayerMaxHP;
    }

    // Update is called once per frame
    void Update()   
    {
       
    }

    //If the player is detected by Enemy's Weapon get 10 damage
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "EnemyWeapon")
        {
            PlayerCurHP -= 30;
            MinHealth();
        }
    }

    //If the player get potion restore 30HP
    public void PotionHP()
    {
        PlayerCurHP += 30;
        MaxHealth();
    }

    public void MaxHealth()
    {
        if (PlayerCurHP > PlayerMaxHP)
        {
            PlayerCurHP = PlayerMaxHP;
        }
    }

    private void MinHealth()
    {
        if (PlayerCurHP < PlayerMinHP)
        {
            PlayerCurHP = PlayerMinHP;
        }
    }
}