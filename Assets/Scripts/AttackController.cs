using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackController : MonoBehaviour
{
    public Animator animator;
    List<string> animlist = new List<string>(new string[] { "Attack1", "Attack2", "Attack3",});
    public int ComboNumber;
    public float Reset;
    public float ResetTime;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && ComboNumber < 3)
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
        if (ComboNumber == 3)
        {
            ResetTime = 3f;
            ComboNumber = 0;
        }
        else
        {
            ResetTime = 1f;
        }
    }
}
