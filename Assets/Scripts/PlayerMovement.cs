using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //
    //private PlayerAnimation playerAnimation;
    private Rigidbody myBody;

    public float walkSpeed = 3f;
    public float zSpeed = 1.5f;

    private float rotationY = -90f;
    private float rotationSpeed = 15f;

    void Awake()
    {
        //playerAnimation = GetComponent<InChildren<PlayerAnimation>();
        myBody = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DetectMovement() 
    {
        myBody.velocity = new Vector3(
            Input.GetAxisRow("Horizontal") * (-walkSpeed),
            myBody.velocity.y,
            Input.GetAxisRow("Vertical") * (-zSpeed)
        );
    }
}
