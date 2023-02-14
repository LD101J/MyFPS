using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //we need to get inputs from keyboard
    //we need float moveSpeed, we need the position of teros, i need rigidbody
    //i need
    #region Variables for moving
    [SerializeField] private float moveSpeed;
    [SerializeField] private Transform terosPos;
    [SerializeField] private CharacterController terosCharacterController;
     private Vector3 moveInput;
    #endregion
    #region Variables for jumping
    #endregion
    #region Variables for gravity
    Vector3 velocity;
    [SerializeField] private float gravity;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private bool isGrounded = true;
    [SerializeField] private float jumpHeight;
    [SerializeField] private float groundDistance = 0.4f;
    [SerializeField] private LayerMask groundMask;
    #endregion


    private void Start()
    {
        //isGrounded = true;
        GetComponent<Rigidbody2D>(); //getting & acessing rigidbody
    }
    private void Update()
    {
        #region PlayerMovement
        float verticalMovement;
        float horizontalMovement; //localVariables

        //put the horizontal input to the horizontal movement
        horizontalMovement = Input.GetAxis("Horizontal") * moveSpeed;
        verticalMovement = Input.GetAxis("Vertical") * moveSpeed;
        //store the inputs in the vector 3 coordinates
        Vector3 rightMovement = transform.right * horizontalMovement;
        Vector3 fowardMovement = transform.forward * verticalMovement;
        moveInput = fowardMovement + rightMovement;
        #endregion
        #region Velocity
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        velocity.y -= gravity * Time.deltaTime;
        terosCharacterController.Move(velocity * Time.deltaTime);
        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            
            velocity.y = Mathf.Sqrt(jumpHeight * +2f * gravity);
            Debug.Log("Jump");
        }
        #endregion
    }
    private void FixedUpdate()
    {
        terosCharacterController.Move(moveInput * Time.deltaTime);
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.magenta;
        Gizmos.DrawSphere(groundCheck.position, groundDistance);
    }
}
