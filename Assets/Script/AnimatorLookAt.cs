using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorLookAt : MonoBehaviour
{
    public Transform focus;

    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnAnimatorIK(int layerIndex)
    {
        anim.SetLookAtWeight(1);
        anim.SetLookAtPosition(focus.position);
    }
}