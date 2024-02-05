using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Adjust character movement speed
    public float moveSpeed;

    //Give physics to the character 
    public Rigidbody2D rb;

    //call animator class 
    public Animator anim;

    //call vector in move function
    private Vector2 moveDirection;


    // Update is called once per frame
    // processing input per frame, calling the movement and animation
    void Update()
    {
        //Call ProcessInputs function
        ProcessInputs();

        //Call Animate function
        Animate();
    }
    private void FixedUpdate()
    {
        //Call Move function
        Move();
    }

    //Movement 
    void ProcessInputs()
    {
        //Set input for x axis, so when we press the 'a' and 'd' or left or right arrow the character move horizontally
        float moveX = Input.GetAxisRaw("Horizontal");

        //Set input for y axis, so when we press the 'w' and 'a' or up or down arrow the character move vertically
        float moveY = Input.GetAxisRaw("Vertical");

        //Add direction
        moveDirection = new Vector2(moveX, moveY);
    }

    //calculating velocity 
    private void Move()
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }

    //Make function for animation
    void Animate()
    {
        //Set animator when character move towards x direction
        anim.SetFloat("AnimMoveX", moveDirection.x);

        //Set animator when character move towards y direction
        anim.SetFloat("AnimMoveY", moveDirection.y);
    }
}
