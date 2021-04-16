using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class potion : MonoBehaviour
{
    public GameObject MyPlayer;
    public GameObject potions;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") 
        {
            MyPlayer.GetComponent<PlayerHealth>().PotionHP();
            potions.gameObject.SetActive(false);
        }

        
    }

}
