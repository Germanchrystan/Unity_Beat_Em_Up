using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationDelegate : MonoBehaviour
{

    public GameObject leftArmAttackPoint, 
    rightArmAttackPoint, 
    leftFootAttackPoint, 
    rightFootAttackPoint;

    public float standUpTimer = 2f;


    private CharacterAnimation animationScript;

    void Awake() 
    {
        animationScript = GetComponent<CharacterAnimation>();
    }
//=============================================================//
    void leftArmAttackOn()
    {
        leftArmAttackPoint.SetActive(true);
    }

    void leftArmAttackOff()
    {
        if(leftArmAttackPoint.activeInHierarchy)
        {
            leftArmAttackPoint.SetActive(false);
        }
    }
//=============================================================//
    void rightArmAttackOn()
    {
        rightArmAttackPoint.SetActive(true);
    }

    void rightArmAttackOff()
    {
        if(rightArmAttackPoint.activeInHierarchy)
        {
            rightArmAttackPoint.SetActive(false);
        }
    }
//=============================================================//
    void leftFootAttackOn()
    {
        leftFootAttackPoint.SetActive(true);
    }

    void leftFootAttackOff()
    {
        if(leftFootAttackPoint.activeInHierarchy)
        {
            leftFootAttackPoint.SetActive(false);
        }
    }
//=============================================================//
    void rightFootAttackOn()
    {
        rightFootAttackPoint.SetActive(true);
    }

    void rightFootAttackOff()
    {
        if(rightFootAttackPoint.activeInHierarchy)
        {
            rightFootAttackPoint.SetActive(false);
        }
    }
//=============================================================//
    void TagLeftArm()
    {
        leftArmAttackPoint.tag = "LeftArm";
    }

    void UntagLeftArm()
    {
        leftArmAttackPoint.tag = "Untagged";
    }
//=============================================================//
    void TagRightArm()
    {
        rightArmAttackPoint.tag = "RightArm";
    }

    void UntagRightArm()
    {
        rightArmAttackPoint.tag = "Untagged";
    }
//=============================================================//
    void TagLeftFoot()
    {
        leftFootAttackPoint.tag = "LeftLeg";
    }

    void UntagLeftFoot()
    {
        leftFootAttackPoint.tag = "Untagged";
    }

//=============================================================//
    void TagRightFoot()
    {
        rightFootAttackPoint.tag = "RightLeg";
    }

    void UntagRightFoot()
    {
        rightFootAttackPoint.tag = "Untagged";
    }
//=============================================================//

    void EnemyStandUp()
    {
        Debug.Log("STANDUP");
        StartCoroutine(StandUpAfterTime());
    }

    IEnumerator StandUpAfterTime()
    {
        yield return new WaitForSeconds(standUpTimer);
        animationScript.StandUp();
    }
}
