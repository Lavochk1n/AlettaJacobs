using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintingMovement : MonoBehaviour
{


    public CharacterController controller;
    public float speed = 13f;
    



    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        controller.Move(move * Time.deltaTime * speed);

        //Vector3 move = transform.right * x + transform.up * y;

    }
}
