using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationDelegate : MonoBehaviour
{

    public GameObject leftArmAttackPoint, 
    rightArmAttackPoint, 
    leftFootAttackPoint, 
    rightFootAttackPoint;
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
}
