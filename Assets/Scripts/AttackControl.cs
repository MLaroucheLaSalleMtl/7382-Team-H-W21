using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class AttackControl : MonoBehaviour
{
    Collider MCollider;
    // Start is called before the first frame update
    void Start()
    {
        MCollider = GetComponent<Collider>();

    }

    // Update is called once per frame
    private void Update()
    {
        // var ray1 = new Ray(mLeftHandCollider.transform.position, Vector3.forward);
        if (MCollider.enabled)
        {
            Collider[] colliders = Physics.OverlapBox(transform.position + new Vector3(0, .5f, 0), new Vector3(.5f, .5f, .5f));
            
            for (int i = 0; i < colliders.Length; i++)
            {
                if (colliders[i].gameObject.tag == "Enemy")//when colliders on players limb touch object "enemy",go to method ReduceHP in enemy.cs
                {
                    Debug.Log(gameObject.name + " " + colliders[i].gameObject.name);//console check
                    var enemy = colliders[i].gameObject.GetComponent<Enemy>();
                    if (enemy)
                    {
                        enemy.ReduceHp();//call reducehp                       
                    }
                }
            }
        }
    }
}
