using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyHPCam : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject Player_Cam;
    // Update is called once per frame
    
    private void Awake()
    {
        Player_Cam = GameObject.FindGameObjectWithTag("MainCamera");
    }
   

    void Update()
    {
        transform.LookAt(transform.position + Player_Cam.transform.rotation * Vector3.back, Player_Cam.transform.rotation * Vector3.down);
    }
    
}
