using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationAttack : MonoBehaviour
{
    public bool IsStart;
    public bool CanAttack;
    void AnimationStart()
    {
        IsStart = true;
        CanAttack = true;
    }
    void AnimationEnd()
    {
        CanAttack = true;
        IsStart = false;
    }
}
