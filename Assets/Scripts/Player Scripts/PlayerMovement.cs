using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterAnimation playerAnim;
    private Rigidbody myBody;

    [SerializeField]  private float walkSpeed=3f;
    [SerializeField]  private float zSpeed=1.5f;

    private float rotaionY=-90f;
    private float rotaionSpeed=15f;
    // Start is called before the first frame update
    void Awake()
    {
        myBody = GetComponent<Rigidbody>();
        playerAnim = GetComponentInChildren<CharacterAnimation>();
    }

    // Update is called once per frame
    void Update()
    {
        RotatePlayer();
        AnimatePlayerMovement();
    }

    private void FixedUpdate()
    {
        DetectMovement();
    }
    private void DetectMovement()
    {
        myBody.velocity = new Vector3(  
            Input.GetAxisRaw(Axis.HORIZONTAL_AXIS)*(-walkSpeed),
            myBody.velocity.y,
            Input.GetAxisRaw(Axis.VERTICAL_AXIS)*(-zSpeed)
            );

    }//Movement
    private void RotatePlayer()
    {
        if (Input.GetAxisRaw(Axis.HORIZONTAL_AXIS) > 0)
            transform.rotation = Quaternion.Euler(0, rotaionY ,0);
        if(Input.GetAxisRaw (Axis.HORIZONTAL_AXIS) < 0)
            transform.rotation = Quaternion.Euler(0,Mathf.Abs(rotaionY),0);
    }//Rotate

    private void AnimatePlayerMovement()
    {
        if (Input.GetAxisRaw(Axis.HORIZONTAL_AXIS) != 0 || Input.GetAxisRaw(Axis.VERTICAL_AXIS) != 0)
            playerAnim.Walk(true);
        else 
            playerAnim.Walk(false);
    } // player walk
}
