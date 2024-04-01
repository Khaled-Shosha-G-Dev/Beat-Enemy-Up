using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour
{
    [SerializeField]private float health = 100f;

    private CharacterAnimation animationScript;
    private EnemyMovement enemyMovement;
    private bool characterDied;
    private bool isPlayer;
    // Start is called before the first frame update
    void Awake()
    {
        animationScript = GetComponentInChildren<CharacterAnimation>();

    }

    private void ApplayDamage(float damage , bool knockDown)
    {
        if(characterDied) 
            return;
        health -= damage;

        if(health<=0f)
        {
            animationScript.Death();
            characterDied = true;
            
            if(isPlayer) { }
            return;
        }

        if(!isPlayer)
        {
            if(knockDown)
            {
                if(Random.Range(0,2)>0)
                    animationScript.KnockDown();
            }
            else
            {
                if (Random.Range(0, 3) > 1)
                    animationScript.Hit();
            }
        }
    }
}
