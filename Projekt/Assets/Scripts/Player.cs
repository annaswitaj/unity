using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  
    [SerializeField] private Transform groundCheckTransform=null;
    [SerializeField] private LayerMask playerMask;

    private bool jumpKeyWasPressed;
    private float horizontalInput;
    private Rigidbody rigidbodyComponent;


    public int superJumpsRemaining=0;
    public float movementSpeed = 1f;
 
    void Start()
    {
        
        rigidbodyComponent = GetComponent<Rigidbody>();

    }

    void Update()
    {
        //check ifspace key is pressed down
        if(Input.GetKeyDown(KeyCode.Space))
        {
            jumpKeyWasPressed = true;
        }
        horizontalInput = Input.GetAxis("Horizontal");
      
    }

    //fixedUpdate is called once every phisics update
    private void FixedUpdate()
    {
        
        rigidbodyComponent.velocity = new Vector3(horizontalInput*2, rigidbodyComponent.velocity.y, 0);
      
        if (Physics.OverlapSphere(groundCheckTransform.position,0.1f, playerMask).Length==0)
        {
            return;
        }
        
        if (jumpKeyWasPressed)
        {
            float jumpPower = 5f;
            if(superJumpsRemaining>0)
            {
                jumpPower *= 2;
                superJumpsRemaining--;
            }
            rigidbodyComponent.AddForce(Vector3.up * jumpPower, ForceMode.VelocityChange);
            jumpKeyWasPressed = false;
        }

     
    }

 


}
