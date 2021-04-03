using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Attack : MonoBehaviour
{

    private Animator animator; //reference to the animator component
    List<string> animlist = new List<string>(new string[] { "Combo1", "Combo2", "Combo3", "Combo4" });
    public int ComboNumber;
    public float Reset;
    public float ResetTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && ComboNumber < 4)
        {
            animator.SetTrigger(animlist[ComboNumber]);
            ComboNumber++;
            Reset = 0f;
        }
        if (ComboNumber > 0)
        {
            Reset += Time.deltaTime;
            if (Reset > ResetTime)
            {
                animator.SetTrigger("Reset");
                ComboNumber = 0;
            }
        }
        if (ComboNumber == 4)
        {
            ResetTime = 4f;
            ComboNumber = 0;
        }
        else
        {
            ResetTime = 1f;
        }
    }
}
