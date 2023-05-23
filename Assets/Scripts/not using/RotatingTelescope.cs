using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingTelescope : MonoBehaviour
{

    public float mouseSensitivity = 100f;
    public float xRotation = 0f;
    public Transform playerBody;

    public bool pressingE;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            pressingE = true;
        }

        if (Input.GetKeyUp(KeyCode.E))
        {
            pressingE = false;
        }

        if (pressingE == true)
        {

            float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
             
            playerBody.Rotate(Vector3.down * mouseX);
            playerBody.Rotate(Vector3.left * mouseY);
        }
    }

}

   