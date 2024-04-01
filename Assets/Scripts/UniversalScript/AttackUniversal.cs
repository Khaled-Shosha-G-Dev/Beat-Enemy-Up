using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackUniversal : MonoBehaviour
{
    [SerializeField] private LayerMask collisionLayer;
    [SerializeField] private float radius = 1f;
    [SerializeField] private float Damage = 2f;
    [SerializeField] private bool isPlayer, isEnemy;
    [SerializeField] private GameObject hitFX;
     
    // Update is called once per frame
    void Update()
    {
        DetectCollision();
    }
    private void DetectCollision()
    {
        Collider[] hit = Physics.OverlapSphere(transform.position, radius,collisionLayer);

        if(hit.Length > 0 ) 
        {
            if (isPlayer)
            {
                Vector3 hitFX_Pos = hit[0].transform.position;
                hitFX_Pos.y += 1.3f;
                if (hit[0].transform.forward.x>0) {
                    hitFX_Pos.x += .3f;
                }
                else if (hit[0].transform .forward.x<0)
                {
                    hitFX_Pos.x -=.3f;
                }
                Instantiate(hitFX, hitFX_Pos, Quaternion.identity);
            }
            gameObject.SetActive(false);
        }
    }//detect collision
}
