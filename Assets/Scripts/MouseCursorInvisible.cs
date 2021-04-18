using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCursorInvisible : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MouseLocked();
    }

   public void MouseLocked()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void MouseUnlocked()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
             
    }

}
