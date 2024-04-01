using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ComboAttacks
{
    Punch1=1,
    Punch2,
    Punch3,

    Kick1,
    Kick2
}

public class PlayerAttack : MonoBehaviour
{

    private CharacterAnimation playerAnim;
    // Start is called before the first frame update
    void Awake()
    {
        playerAnim = GetComponentInChildren<CharacterAnimation>();
    }

    // Update is called once per frame
    void Update()
    {
        ComboAttack();
    }

    private void ComboAttack()
    {
        int randomPunch = Random.Range(1,4);
        if (Input.GetKeyDown(KeyCode.F))
        {
            ComboAttacks selectedAttack = (ComboAttacks)randomPunch;
            if(selectedAttack == ComboAttacks.Punch1)
                playerAnim.Punch_1();
            else if(selectedAttack == ComboAttacks.Punch2)
                playerAnim.Punch_2();
            else if(selectedAttack == ComboAttacks.Punch3)
                playerAnim.Punch_3();
        }
        int randomKick = Random.Range(4,6);
        if(Input.GetKeyDown(KeyCode.G)) 
        {
            ComboAttacks selectedAttack = (ComboAttacks)randomKick;
            if( selectedAttack == ComboAttacks.Kick1)
                playerAnim.Kick_1();
            else if( selectedAttack == ComboAttacks.Kick2)
                playerAnim.Kick_2();
        }
    }
}
