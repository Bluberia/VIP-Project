using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IKHandler : MonoBehaviour
{

    public Transform rightHandObj;
    public Transform rightElbowObj;
    public Transform leftHandObj;
    public Transform leftElbowObj;

    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnAnimatorIK(int layerIndex)
    {
        anim.SetIKPositionWeight(AvatarIKGoal.RightHand, 1);
        anim.SetIKRotationWeight(AvatarIKGoal.RightHand, 1);
        anim.SetIKPosition(AvatarIKGoal.RightHand, rightHandObj.position);
        anim.SetIKRotation(AvatarIKGoal.RightHand, rightHandObj.rotation);

        anim.SetIKHintPositionWeight(AvatarIKHint.RightElbow, 1);
        anim.SetIKHintPosition(AvatarIKHint.RightElbow, rightElbowObj.position);

        anim.SetIKPositionWeight(AvatarIKGoal.LeftHand, 1);
        anim.SetIKRotationWeight(AvatarIKGoal.LeftHand, 1);
        anim.SetIKPosition(AvatarIKGoal.LeftHand, leftHandObj.position);
        anim.SetIKRotation(AvatarIKGoal.LeftHand, leftHandObj.rotation);

        anim.SetIKHintPositionWeight(AvatarIKHint.LeftElbow, 1);
        anim.SetIKHintPosition(AvatarIKHint.LeftElbow, leftElbowObj.position);
    }
}
