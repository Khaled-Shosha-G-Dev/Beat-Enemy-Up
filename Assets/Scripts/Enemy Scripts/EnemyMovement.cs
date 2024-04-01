using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private CharacterAnimation enemyAnim;
    private Rigidbody myBody;
    [SerializeField] private float speed = 5f;

    private Transform playerTarget;

    public float attackDistance=1f;
    private float chacePlayerAfterAttack = 1f;

    private float currentAttackTime;
    private float defaultAttackTime=2f;

    private bool followPalyer , attackPlayer;

    private void Awake()
    {
        enemyAnim = GetComponentInChildren<CharacterAnimation>();
        myBody = GetComponentInChildren<Rigidbody>();
        playerTarget = GameObject.FindWithTag(Tags.PLAYER_TAG)?.transform;
    }
    // Start is called before the first frame update
    void Start()
    {
        followPalyer = true;
        currentAttackTime = defaultAttackTime;
    }

    // Update is called once per frame
    private void Update()
    {
        Attack();
    }
    void FixedUpdate()
    {
        FollowTarget();
    }

    private void FollowTarget()
    {
        if (!followPalyer)
            return;
        if (Vector3.Distance(transform.position, playerTarget.position) > attackDistance)
        {
            transform.LookAt(playerTarget.position);
            myBody.velocity = transform.forward*speed;
            if (myBody.velocity.sqrMagnitude != 0)
                enemyAnim.Walk(true);
        }
        else if (Vector3.Distance(transform.position, playerTarget.position) <= attackDistance)
        {
            myBody.velocity = Vector3.zero;
            enemyAnim.Walk(false);

            followPalyer=false;
            attackPlayer=true;
        }
    }
    private void Attack()
    {
        if (!attackPlayer)
            return;
        currentAttackTime += Time.deltaTime;
        if(currentAttackTime > defaultAttackTime ) 
        {
            enemyAnim.EnemyAttack(Random.Range(0, 3));
            currentAttackTime=0;
        }
        if(Vector3.Distance(transform.position, playerTarget.position)>attackDistance+chacePlayerAfterAttack) 
        {
            attackPlayer = false;
            followPalyer = true;
        }
    }
}
