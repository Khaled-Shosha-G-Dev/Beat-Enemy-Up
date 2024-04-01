using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationDelegate : MonoBehaviour
{
    [SerializeField] private GameObject leftHandAttack , rightHandAttack,leftLegAttack,rightLegAttack;

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LeftHandAttackPointOn()
    {
        leftHandAttack.SetActive(true);    
    }
    private void LeftHandAttackPointOff()
    {
        if(leftHandAttack.activeInHierarchy)
            leftHandAttack.SetActive(false);    
    }private void RightHandAttackPointOn()
    {
        rightHandAttack.SetActive(true);    
    }
    private void RightHandAttackPointOff()
    {
        if(rightHandAttack.activeInHierarchy)
            rightHandAttack.SetActive(false);    
    }private void LeftLegAttackPointOn()
    {
        leftLegAttack.SetActive(true);    
    }
    private void LeftLegAttackPointOff()
    {
        if(leftLegAttack.activeInHierarchy)
            leftLegAttack.SetActive(false);    
    }private void RightLegAttackPointOn()
    {
        rightLegAttack.SetActive(true);    
    }
    private void RightLegAttackPointOff()
    {
        if(rightLegAttack.activeInHierarchy)
            rightLegAttack.SetActive(false);    
    }
}
