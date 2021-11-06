using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using static ;

public class PlayerMovement : MonoBehaviour
{
    //
    private PlayerAnimation playerAnimation;
    private Rigidbody myBody;

    public float walkSpeed = 3f;
    public float zSpeed = 1.5f;

    private float rotationY = -90f;
    private float rotationSpeed = 15f;

    void Awake()
    {
        playerAnimation = GetComponentInChildren<PlayerAnimation>();
        myBody = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RotatePlayer();
        AnimatePlayerWalk();
    }

    void FixedUpdate() 
    {
        DetectMovement();
    }

    void RotatePlayer()
    {
        if(UnityEngine.Input.GetAxis("Horizontal") > 0)
        {
            transform.rotation = Quaternion.Euler(0f, -Mathf.Abs(rotationY), 0f);
        } 
        else if(Input.GetAxis("Horizontal") < 0)
        {
            transform.rotation = Quaternion.Euler(0f, Mathf.Abs(rotationY), 0f);
        }
    }

    void DetectMovement() 
    {

        myBody.velocity = new Vector3(
            UnityEngine.Input.GetAxis("Horizontal") * (-walkSpeed),
            myBody.velocity.y,
            UnityEngine.Input.GetAxis("Vertical") * (-zSpeed)
        );
    }

    void AnimatePlayerWalk()
    {
        if(UnityEngine.Input.GetAxis("Horizontal") != 0
        || UnityEngine.Input.GetAxis("Vertical") != 0)
        {
            playerAnimation.Walk(true);            
        } 
        else 
        {
            playerAnimation.Walk(false);
        }
    }
}
