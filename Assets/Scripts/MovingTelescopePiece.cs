using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovingTelescopePiece : MonoBehaviour
{

    // if u click on a telescope piece it should become a child of the player camera
    // if u click again while close to a telescope piece (blueprint) the position of the moving piece = position blue print piece. Also make moving piece child of telescope again.
    public bool isLocked = false;
    public bool pressingE = false;
    public bool mousePressed = false;
    public bool hasHit = false;
    public bool pieceDropped = false;

    public Rigidbody rB;
    

    public GameObject pieceToMove;
    public GameObject pieceToMove2;
    public GameObject pieceToMove3;
    public GameObject pieceToMove4;
    public GameObject pieceToMove5;
    public GameObject pieceToMove6;
    public GameObject pieceToMove7;
    public GameObject pieceToMove8;
    public GameObject pieceToMove9;
    public GameObject pieceToMove10;
    public GameObject pieceToMoveTo1;
    public GameObject pieceToMoveTo2;
    public GameObject pieceToMoveTo3;
    public GameObject pieceToMoveTo4;
    public GameObject pieceToMoveTo5;
    public GameObject pieceToMoveTo6;
    public GameObject pieceToMoveTo7;
    public GameObject pieceToMoveTo8;
    public GameObject pieceToMoveTo9;
    public GameObject pieceToMoveTo10;
    public GameObject pieceToDrop;
    public GameObject camera1;

    public float dropDistance = 0.1f;
    public float forwardSpeed = 1f;
    public float backwardSpeed = 1f;
    public int _i = 0;


    public void DropObject(GameObject pieceToMove1)
    {
        float Distance1 = Vector3.Distance(pieceToMove1.transform.position, pieceToMoveTo1.transform.position);
        if (Distance1 < dropDistance)
        {
            isLocked = false;
            pieceToMove1.transform.position = pieceToMoveTo1.transform.position;
            pieceToMove1.transform.rotation = pieceToMoveTo1.transform.rotation;
            pieceToMove1.transform.parent = null;
        }
        float Distance2 = Vector3.Distance(pieceToMove1.transform.position, pieceToMoveTo2.transform.position);
        if (Distance2 < dropDistance)
        {
            isLocked = false;
            pieceToMove1.transform.position = pieceToMoveTo2.transform.position;
            pieceToMove1.transform.rotation = pieceToMoveTo2.transform.rotation;
            pieceToMove1.transform.parent = null;
        }


        float Distance3 = Vector3.Distance(pieceToMove1.transform.position, pieceToMoveTo3.transform.position);
        if (Distance3 < dropDistance)
        {
            isLocked = false;
            pieceToMove1.transform.position = pieceToMoveTo3.transform.position;
            pieceToMove1.transform.rotation = pieceToMoveTo3.transform.rotation;
            pieceToMove1.transform.parent = null;
        }

        float Distance4 = Vector3.Distance(pieceToMove1.transform.position, pieceToMoveTo4.transform.position);
        if (Distance4 < dropDistance)
        {
            isLocked = false;
            pieceToMove1.transform.position = pieceToMoveTo4.transform.position;
            pieceToMove1.transform.rotation = pieceToMoveTo4.transform.rotation;
            pieceToMove1.transform.parent = null;
        }


        float Distance5 = Vector3.Distance(pieceToMove1.transform.position, pieceToMoveTo5.transform.position);
        if (Distance5 < dropDistance)
        {
            isLocked = false;
            pieceToMove1.transform.position = pieceToMoveTo5.transform.position;
            pieceToMove1.transform.rotation = pieceToMoveTo5.transform.rotation;
            pieceToMove1.transform.parent = null;
        }


        float Distance6 = Vector3.Distance(pieceToMove1.transform.position, pieceToMoveTo6.transform.position);
        if (Distance6 < dropDistance)
        {
            isLocked = false;
            pieceToMove1.transform.position = pieceToMoveTo6.transform.position;
            pieceToMove1.transform.rotation = pieceToMoveTo6.transform.rotation;
            pieceToMove1.transform.parent = null;
        }


        float Distance7 = Vector3.Distance(pieceToMove1.transform.position, pieceToMoveTo7.transform.position);
        if (Distance7 < dropDistance)
        {
            isLocked = false;
            pieceToMove1.transform.position = pieceToMoveTo7.transform.position;
            pieceToMove1.transform.rotation = pieceToMoveTo7.transform.rotation;
            pieceToMove1.transform.parent = null;
        }


        float Distance8 = Vector3.Distance(pieceToMove1.transform.position, pieceToMoveTo8.transform.position);
        if (Distance8 < dropDistance)
        {
            isLocked = false;
            pieceToMove1.transform.position = pieceToMoveTo8.transform.position;
            pieceToMove1.transform.rotation = pieceToMoveTo8.transform.rotation;
            pieceToMove1.transform.parent = null;
        }

        float Distance9 = Vector3.Distance(pieceToMove1.transform.position, pieceToMoveTo9.transform.position);
        if (Distance9 < dropDistance)
        {
            isLocked = false;
            pieceToMove1.transform.position = pieceToMoveTo9.transform.position;
            pieceToMove1.transform.rotation = pieceToMoveTo9.transform.rotation;
            pieceToMove1.transform.parent = null;
        }

        float Distance10 = Vector3.Distance(pieceToMove1.transform.position, pieceToMoveTo10.transform.position);
        if (Distance10 < dropDistance)
        {
            isLocked = false;
            pieceToMove1.transform.position = pieceToMoveTo10.transform.position;
            pieceToMove1.transform.rotation = pieceToMoveTo10.transform.rotation;
            pieceToMove1.transform.parent = null;
        }

        float Distance11 = Vector3.Distance(pieceToMove.transform.position, pieceToMoveTo1.transform.position);
        float Distance12 = Vector3.Distance(pieceToMove2.transform.position, pieceToMoveTo2.transform.position);
        float Distance13 = Vector3.Distance(pieceToMove3.transform.position, pieceToMoveTo3.transform.position);
        float Distance14 = Vector3.Distance(pieceToMove4.transform.position, pieceToMoveTo4.transform.position);
        float Distance15 = Vector3.Distance(pieceToMove5.transform.position, pieceToMoveTo5.transform.position);
        float Distance16 = Vector3.Distance(pieceToMove6.transform.position, pieceToMoveTo6.transform.position);

        float Distance17 = Vector3.Distance(pieceToMove7.transform.position, pieceToMoveTo7.transform.position);
        float Distance172 = Vector3.Distance(pieceToMove7.transform.position, pieceToMoveTo8.transform.position);
        float Distance173 = Vector3.Distance(pieceToMove7.transform.position, pieceToMoveTo9.transform.position);
        float Distance18 = Vector3.Distance(pieceToMove8.transform.position, pieceToMoveTo8.transform.position);
        float Distance182 = Vector3.Distance(pieceToMove8.transform.position, pieceToMoveTo7.transform.position);
        float Distance183 = Vector3.Distance(pieceToMove8.transform.position, pieceToMoveTo9.transform.position);
        float Distance19 = Vector3.Distance(pieceToMove9.transform.position, pieceToMoveTo9.transform.position);
        float Distance192 = Vector3.Distance(pieceToMove9.transform.position, pieceToMoveTo7.transform.position);
        float Distance193 = Vector3.Distance(pieceToMove9.transform.position, pieceToMoveTo8.transform.position);


        float Distance20 = Vector3.Distance(pieceToMove10.transform.position, pieceToMoveTo10.transform.position);
        if (Distance11 < 1 && Distance12 < 1 && Distance13 < 1 && Distance14 < 1 && Distance15 < 1 && Distance16 < 1 && (Distance17 < 1 || Distance172 < 1 || Distance173 < 1) && (Distance182 < 1 || Distance183 < 1 || Distance18 < 1) && (Distance192 < 1 || Distance193 < 1 || Distance19 < 1) && Distance20 < 1)
        {
            SceneManager.LoadScene("New Building");
            Feedbacktext.fRight1 = true;
            playerMovement.setPos4 = true;
            Createinteractionpopup4.c4 = false;
            Debug.Log("Puzzle complete");
        }
        else
        {
           // SceneManager.LoadScene("gameRoom2");
            
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        
        pieceToDrop = null;
    }

    // Update is called once per frame
    void Update()
    {
      
        if (Input.GetMouseButton(0))
        { // if left button pressed...

            Ray ray;
            ray = new Ray(camera1.GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition), camera1.GetComponent<Camera>().transform.forward);
            // or ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 1000f) && hasHit == false)
            {
                //switch (hit.transform)
                //{
                //    case pieceToMove.transform:
                //        pieceToMove.transform.parent = camera1.transform;
                //        break;
                //    case pieceToMove2.transform:
                //        pieceToMove2.transform.parent = camera1.transform;
                //        break;
                //    default: 

                //        break;
                //}


                if (hit.transform == pieceToMove.transform)
                {
                    pieceToMove.transform.parent = camera1.transform;
                    pieceToDrop = pieceToMove;
                    hasHit= true;
                }
                if (hit.transform == pieceToMove2.transform)
                {
                    pieceToMove2.transform.parent = camera1.transform;
                    pieceToDrop = pieceToMove2;
                    hasHit = true;
                }
                if (hit.transform == pieceToMove3.transform)
                {
                    pieceToMove3.transform.parent = camera1.transform;
                    pieceToDrop = pieceToMove3;
                    hasHit = true;
                }
                if (hit.transform == pieceToMove4.transform)
                {
                    pieceToMove4.transform.parent = camera1.transform;
                    pieceToDrop = pieceToMove4;
                    hasHit = true;
                }
                if (hit.transform == pieceToMove5.transform)
                {
                    pieceToMove5.transform.parent = camera1.transform;
                    pieceToDrop = pieceToMove5;
                    hasHit = true;
                }
                if (hit.transform == pieceToMove6.transform)
                {
                    pieceToMove6.transform.parent = camera1.transform;
                    pieceToDrop = pieceToMove6;
                    hasHit = true;
                }
                if (hit.transform == pieceToMove7.transform)
                {
                    pieceToMove7.transform.parent = camera1.transform;
                    pieceToDrop = pieceToMove7;
                    hasHit = true;
                }
                if (hit.transform == pieceToMove8.transform)
                {
                    pieceToMove8.transform.parent = camera1.transform;
                    pieceToDrop = pieceToMove8;
                    hasHit = true;
                }
                if (hit.transform == pieceToMove9.transform)
                {
                    pieceToMove9.transform.parent = camera1.transform;
                    pieceToDrop = pieceToMove9;
                    hasHit = true;
                }
                if (hit.transform == pieceToMove10.transform)
                {
                    pieceToMove10.transform.parent = camera1.transform;
                    pieceToDrop = pieceToMove10;
                    hasHit = true;
                }
               
                if (pieceToDrop != null)
                {
                    rB = pieceToDrop.GetComponent<Rigidbody>();
                }
               


            }
            if (mousePressed == false)
            {
                mousePressed = true;
            }
            //if (Input.GetKey(KeyCode.Q))
            //{
            //    if (rB != null)
            //    {
            //        forwardSpeed = 1f;
            //        pieceToDrop.transform.rotation = camera1.transform.rotation;
            //        rB.velocity = transform.forward * forwardSpeed;
            //    }
            //}
            //else if (forwardSpeed == 1)
            //{
            //    if (rB != null)
            //    {
            //        forwardSpeed = 0f;
            //        rB.velocity = transform.forward * forwardSpeed;
            //    }
            //}
            //if (Input.GetKey(KeyCode.E))
            //{
            //    if (rB != null)
            //    {
            //        backwardSpeed = 1f;
            //        pieceToDrop.transform.rotation = camera1.transform.rotation;
            //        rB.velocity = -transform.forward * backwardSpeed;
            //    }
            //}
            //else if (backwardSpeed == 1)
            //{
            //    if (rB != null)
            //    {
            //        backwardSpeed = 0f;
            //        rB.velocity = -transform.forward * backwardSpeed;
            //    }
            //}

            // if (pieceDropped == false)
            //   {

            if (_i == 120)
            {
                if (pieceToDrop != null)
                {
                    DropObject(pieceToDrop);
               
                //    _i = 0;
                    // reset collision or rigidbody
                 //   rB.isKinematic = true;
                    //    rB.detectCollisions = false;

                    //rB.isKinematic = false;
                    //    rB.detectCollisions = true;

                }
            }
            else if (_i < 120)
            {
                _i += 1;
            }



            //         pieceDropped = true;
            //     }






        }
        else if (mousePressed == true)
        {
            if (pieceToDrop != null)
            {
                //    DropObject(pieceToDrop);
                //    Debug.Log("Object dropped");
             //   rB.isKinematic = true;
                _i = 0;

            }
            pieceDropped = false;
            hasHit = false;
            mousePressed = false;
        }

        else if (pieceToMove.transform.parent != null || pieceToMove2.transform.parent != null || pieceToMove3.transform.parent != null || pieceToMove4.transform.parent != null || pieceToMove5.transform.parent != null || pieceToMove6.transform.parent != null || pieceToMove7.transform.parent != null || pieceToMove8.transform.parent != null || pieceToMove9.transform.parent != null || pieceToMove10.transform.parent != null)
        {
            pieceToMove.transform.parent = null;
            pieceToMove2.transform.parent = null;
            pieceToMove3.transform.parent = null;
            pieceToMove4.transform.parent = null;
            pieceToMove5.transform.parent = null;
            pieceToMove6.transform.parent = null;
            pieceToMove7.transform.parent = null;
            pieceToMove8.transform.parent = null;
            pieceToMove9.transform.parent = null;
            pieceToMove10.transform.parent = null;

        }



        


    }

   


}
