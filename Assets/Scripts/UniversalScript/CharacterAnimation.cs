using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimation : MonoBehaviour
{
    private Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    public void Walk(bool move)
    {
        anim.SetBool(Animation.MOVEMENT, move);
    }
    
    public void Punch_1()
    {
        anim.SetTrigger(Animation.PUNCH_1_TRIGGER);
    }
    public void Punch_2()
    {
        anim.SetTrigger(Animation.PUNCH_2_TRIGGER);
    }
    public void Punch_3()
    {
        anim.SetTrigger(Animation.PUNCH_3_TRIGGER);
    }


    public void Kick_1() 
    {
        anim.SetTrigger(Animation.KICK_1_TRIGGER);
    }
    public void Kick_2() 
    {
        anim.SetTrigger(Animation.KICK_2_TRIGGER);
    }

    public void EnemyAttack(int attack)
    {
        if(attack == 0)
        {
            anim.SetTrigger(Animation.ATTACK_1_TRIGGER);
        }
        if (attack == 1)
        {
            anim.SetTrigger(Animation.ATTACK_2_TRIGGER);
        }
        if (attack == 2)
        {
            anim.SetTrigger(Animation.ATTACK_3_TRIGGER);
        }
    }//enemy attack

    public void PlayIdelAnimation()
    {
        anim.Play(Animation.IDEL_ANIMATION);
    }

    public void KnockDown()
    {
        anim.SetTrigger(Animation.KNOCK_DOWN_TRIGGER);
    }

    public void StandUp()
    {
        anim.SetTrigger(Animation.STAND_UP_TRIGGER);
    }

    public void Hit()
    {
        anim.SetTrigger(Animation.HIT_TRIGGER);
    }

    public void Death()
    {
        anim.SetTrigger(Animation.DEATH_TRIGGER);
    }
}
