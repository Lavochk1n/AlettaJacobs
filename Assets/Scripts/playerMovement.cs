using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 13f;
    public float gravity = -9.81f;
    public float gDistance = 0.4f;
    public LayerMask groundMask;
    public Transform groundCheck;

    

   public static bool setPos3 = false;
   public static bool setPos4 = false;
   public static bool setPos5 = false;
 
    public int _i = 0;


    Vector3 moveDirection;
    bool isGrounded;

    public Vector3 positionToSet;
   // public bool setPos = false;

   

    void Start()
    {
        //if (positionToSet != Vector3.zero)
        //{
        //    transform.position = positionToSet;
        //    Debug.Log("Position has been set to variable");
        //    positionToSet = Vector3.zero;
        //}
        //    transform.position = new Vector3(300.5f, 48f, -409.5f);
        
    }

    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, gDistance, groundMask);

        if (isGrounded && moveDirection.y < 0)
        {
            moveDirection.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);

        moveDirection.y += gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);

        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu");
        }


            if (buttonscript.setPos2 == true)
        {
            positionToSet = new Vector3(300.5f, 48f, -409.5f);
            Debug.Log("Variable has been set to coordinates");
            transform.position = positionToSet;
         


            if (_i == 2)
            {
                transform.Rotate(0f, -90f, 0f, Space.World);
                if (transform.position == positionToSet)
                {
                   
                    buttonscript.setPos2 = false;
                    Debug.Log("Position has been set to variable succesfully");
                }
            }
            if (_i <= 2)
            {
            _i++;
            }
            else
            {
               _i = 0;
            }

            
        }

        if (setPos3 == true)
        {
            positionToSet = new Vector3(0f, 2f, 0f);
            Debug.Log("Variable has been set to coordinates");
            transform.position = positionToSet;



            if (_i == 2)
            {
             //   transform.Rotate(0f, -90f, 0f, Space.World);
                if (transform.position == positionToSet)
                {

                    setPos3 = false;
                    Debug.Log("Position has been set to variable succesfully");
                }
            }
            if (_i <= 2)
            {
                _i++;
            }
            else
            {
                _i = 0;
            }


        }


        if (setPos4 == true)
        {
            positionToSet = new Vector3(355f, 49f, -450f);
            Debug.Log("Variable has been set to coordinates");
            transform.position = positionToSet;


            if (_i == 2)
            {
                //   transform.Rotate(0f, -90f, 0f, Space.World);
                if (transform.position == positionToSet)
                {

                    setPos4 = false;
                    Debug.Log("Position has been set to variable succesfully");
                }
            }
            if (_i <= 2)
            {
                _i++;
            }
            else
            {
                _i = 0;
            }


        }


        if (setPos5 == true)
        {
            positionToSet = new Vector3(304f, 64f, -455f);
            Debug.Log("Variable has been set to coordinates");
            transform.position = positionToSet;


            if (_i == 2)
            {
                   transform.Rotate(0f, -90f, 0f, Space.World);
                if (transform.position == positionToSet)
                {

                    setPos5 = false;
                    Debug.Log("Position has been set to variable succesfully");
                }
            }
            if (_i <= 2)
            {
                _i++;
            }
            else
            {
                _i = 0;
            }


        }





    }
    
}
