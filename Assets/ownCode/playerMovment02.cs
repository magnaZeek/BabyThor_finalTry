using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovment02 : MonoBehaviour
{
    public CharacterController2D controller;
    public float runSpeed = 40f;
    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        horizontalMove = Input.GetAxisRaw("Horizontal02") * runSpeed;

        if (Input.GetButtonDown("Jump02"))
        {
            jump = true;
        }
        if (Input.GetButtonDown("Crouch02"))
        {
            crouch = true;
        }
        else if (Input.GetButtonUp("Crouch02"))
        {
            crouch = false;
        }
    }

    void FixedUpdate()
    {
        //movement
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }
}

