using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTelescopePiece : MonoBehaviour
{

    // if u click on a telescope piece it should become a child of the player camera
    // if u click again while close to a telescope piece (blueprint) the position of the moving piece = position blue print piece. Also make moving piece child of telescope again.
    public bool isLocked = false;
    public bool pressingE = false;
    public bool mousePressed = false;
    

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
    public GameObject camera1;

    public float dropDistance = 40f;

    
    
       

    

    public void DropObject(GameObject pieceToMove1)
    {
        float Distance1 = Vector3.Distance(pieceToMove1.transform.position, pieceToMoveTo1.transform.position);
        if (Distance1 < dropDistance)
        {
            isLocked = false;
            pieceToMove1.transform.position = pieceToMoveTo1.transform.position;
        }
        //float Distance2 = Vector3.Distance(pieceToMove1.transform.position, pieceToMoveTo2.transform.position);
        //if (Distance2 < dropDistance)
        //{
        //    isLocked = false;
        //    pieceToMove1.transform.position = pieceToMoveTo2.transform.position;
        //}


        //float Distance3 = Vector3.Distance(pieceToMove1.transform.position, pieceToMoveTo3.transform.position);
        //if (Distance3 < dropDistance)
        //{
        //    isLocked = false;
        //    pieceToMove1.transform.position = pieceToMoveTo3.transform.position;
        //}

        //float Distance4 = Vector3.Distance(pieceToMove1.transform.position, pieceToMoveTo4.transform.position);
        //if (Distance4 < dropDistance)
        //{
        //    isLocked = false;
        //    pieceToMove1.transform.position = pieceToMoveTo4.transform.position;
        //}


        //float Distance5 = Vector3.Distance(pieceToMove1.transform.position, pieceToMoveTo5.transform.position);
        //if (Distance5 < dropDistance)
        //{
        //    isLocked = false;
        //    pieceToMove1.transform.position = pieceToMoveTo5.transform.position;
        //}


        //float Distance6 = Vector3.Distance(pieceToMove1.transform.position, pieceToMoveTo6.transform.position);
        //if (Distance6 < dropDistance)
        //{
        //    isLocked = false;
        //    pieceToMove1.transform.position = pieceToMoveTo6.transform.position;
        //}


        //float Distance7 = Vector3.Distance(pieceToMove1.transform.position, pieceToMoveTo7.transform.position);
        //if (Distance7 < dropDistance)
        //{
        //    isLocked = false;
        //    pieceToMove1.transform.position = pieceToMoveTo7.transform.position;
        //}


        //float Distance8 = Vector3.Distance(pieceToMove1.transform.position, pieceToMoveTo8.transform.position);
        //if (Distance8 < dropDistance)
        //{
        //    isLocked = false;
        //    pieceToMove1.transform.position = pieceToMoveTo8.transform.position;
        //}

        //float Distance9 = Vector3.Distance(pieceToMove1.transform.position, pieceToMoveTo9.transform.position);
        //if (Distance9 < dropDistance)
        //{
        //    isLocked = false;
        //    pieceToMove1.transform.position = pieceToMoveTo9.transform.position;
        //}

        float Distance11 = Vector3.Distance(pieceToMove.transform.position, pieceToMoveTo1.transform.position);
        //float Distance12 = Vector3.Distance(pieceToMove2.transform.position, pieceToMoveTo2.transform.position);
        //float Distance13 = Vector3.Distance(pieceToMove3.transform.position, pieceToMoveTo3.transform.position);
        //float Distance14 = Vector3.Distance(pieceToMove4.transform.position, pieceToMoveTo4.transform.position);
        //float Distance15 = Vector3.Distance(pieceToMove5.transform.position, pieceToMoveTo5.transform.position);
        //float Distance16 = Vector3.Distance(pieceToMove6.transform.position, pieceToMoveTo6.transform.position);
        //float Distance17 = Vector3.Distance(pieceToMove7.transform.position, pieceToMoveTo7.transform.position);
        //float Distance18 = Vector3.Distance(pieceToMove8.transform.position, pieceToMoveTo8.transform.position);
        //float Distance19 = Vector3.Distance(pieceToMove9.transform.position, pieceToMoveTo9.transform.position);
        //float Distance20 = Vector3.Distance(pieceToMove10.transform.position, pieceToMoveTo10.transform.position);
        if (Distance1 < 10)
        {
          
           // SceneManager.LoadScene("gameRoom3");
            Debug.Log("Object has snapped");
        }
        else
        {
           // SceneManager.LoadScene("gameRoom2");
            Debug.Log("Object didn't snap");
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
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
            if (Physics.Raycast(ray, out hit, 1000f))
            {
                if (hit.transform == transform)   //pieceToMove.
                {
                    pieceToMove.transform.parent = camera1.transform;
                }
                
                
            }
            if (mousePressed == false)
            {
                mousePressed = true;
            }           
        }
        else if (mousePressed == true)
        {
                  DropObject(pieceToMove);
                  Debug.Log("Object dropped");
            mousePressed = false;
        }
        else if (pieceToMove.transform.parent != null)
        {
            pieceToMove.transform.parent = null;
        }



        


    }

   


}
