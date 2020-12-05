using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Controls: A, D, Left, Right to move. Space to jump
public class CharacterController : MonoBehaviour
{
    //access Rigidbody
    private Rigidbody rb;

    //variable for movement speed - for how fast player runs. Public - you can make changes in the inspector
    public float speed = 10f;

    //character facing right (bool is a true or false value)
    private bool facingRight = true;

    //grounded is false
    bool grounded;
    //choose ground check in inspector
    public Transform groundCheck;
    //radius of ground check 
    float groundRadius = 0.5f;
    //which layers are ground
    public LayerMask whatIsGround;

    //variable for how high player jumps
    public float jumpForce = 300f;

    void Start()
    {

        //rb is Rigidbody2D
        rb = GetComponent<Rigidbody>();
    }


    //FixedUpdate should be used instead of Update when dealing with a Rigidbody 
    void FixedUpdate()
    {
      
       
        //variable 'horizontal' for keyboard input on "Horizontal" axis. Unity has keyboard inputs mapped - so 'a' = left and 'd' = right
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        rb.velocity = new Vector3(horizontal * speed, 0,vertical*speed);

        //grounded is when groundcheck object is on the ground
        //grounded = Physics.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);

        //if character is moving left (i.e. not facing right) flip the character 
        if (horizontal > 0 && !facingRight)
        {
            Flip(horizontal);
        }
        else if (horizontal < 0 && facingRight)
        {
            Flip(horizontal);
        }

     

        
       
    }

    //jump - if on the ground and the input key is 'space' add force in y axis equal to 'jumpForce'
     void Update()
    {

        }
       







    
    //create function 'Flip' to flip the world so that we do not need a left and right animation
    private void Flip(float horizontal)
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}