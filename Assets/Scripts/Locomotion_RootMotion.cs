using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; 

public class Locomotion_RootMotion : MonoBehaviour
{
    private Animator anim; //reference to the animator component
    private Vector2 move; //Inputsystem
    List<string> animlist = new List<string>(new string[] { "Attack", "Attack2", "Attack3", "Attack4" });
    public int ComboNum;
    public float Reset;
    public float ResetTime;
    private bool Jump = false;
    

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>(); //cache the animator component

    }

    public void OnJump(InputAction.CallbackContext context)
    {
        Jump = context.performed;
    }

    public void Onmove(InputAction.CallbackContext context)
    {
        move = context.ReadValue<Vector2>();
    }
   
    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("H", move.x);
        anim.SetFloat("V", move.y);

        

        if(Jump)
        {
            Jump = false;
            anim.SetTrigger("Jump");
        }

    }
}
