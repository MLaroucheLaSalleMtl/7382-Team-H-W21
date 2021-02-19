using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Cinemachine;

public class Cinemachineinputsystem : MonoBehaviour
{
    private CinemachineFreeLook vCam;// cinemachine vietual camera

    // Start is called before the first frame update
    void Start()
    {
        vCam = GetComponent<CinemachineFreeLook>(); //cache the camera component
    }

    public void OnLook(InputAction.CallbackContext context)
    {
        Vector2 v = context.ReadValue<Vector2>();
        vCam.m_XAxis.m_InputAxisValue = v.x;
        vCam.m_YAxis.m_InputAxisValue = v.y;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
