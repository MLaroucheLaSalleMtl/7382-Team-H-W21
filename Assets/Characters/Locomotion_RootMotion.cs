using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; 

public class Locomotion_RootMotion : MonoBehaviour
{

    private Animator anim; //reference to the animator
    private Vector2 move; //inputsystem

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>(); //cache the component animator.

    }
    public void OnMove(InputAction.CallbackContext context)
    {
        move = context.ReadValue<Vector2>();
    }
    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("H", move.x);
        anim.SetFloat("V", move.y);

    }
}
