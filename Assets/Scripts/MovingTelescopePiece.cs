//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class MovingTelescopePiece : MonoBehaviour
//{

//    // if u click on a telescope piece it should become a child of the player camera
//    // if u click again while close to a telescope piece (blueprint) the position of the moving piece = position blue print piece. Also make moving piece child of telescope again.


//    public GameObject pieceToMove;
//    public GameObject pieceToMove2;
//    public GameObject pieceToMove3;
//    public GameObject pieceToMove4;
//    public GameObject pieceToMove5;
//    public GameObject pieceToMove6;
//    public GameObject pieceToMove7;
//    public GameObject pieceToMove8;
//    public GameObject pieceToMove9;
//    public GameObject pieceToMove10;
//    public GameObject pieceToMoveTo1;
//    public GameObject pieceToMoveTo2;
//    public GameObject pieceToMoveTo3;
//    public GameObject pieceToMoveTo4;
//    public GameObject pieceToMoveTo5;
//    public GameObject pieceToMoveTo6;
//    public GameObject pieceToMoveTo7;
//    public GameObject pieceToMoveTo8;
//    public GameObject pieceToMoveTo9;
//    public GameObject pieceToMoveTo10;

//    public float dropDistance;

//    public void DropObject()
//    {
//        float Distance1 = Vector3.Distance(pieceToMove.transform.position, pieceToMoveTo1.transform.position);
//        if (Distance1 < dropDistance)
//        {
//            isLocked = false;
//            pieceToMove.transform.position = pieceToMoveTo1.transform.position;
//        }
//        float Distance2 = Vector3.Distance(pieceToMove.transform.position, pieceToMoveTo2.transform.position);
//        if (Distance2 < dropDistance)
//        {
//            isLocked = false;
//            pieceToMove.transform.position = pieceToMoveTo2.transform.position;
//        }


//        float Distance3 = Vector3.Distance(pieceToMove.transform.position, pieceToMoveTo3.transform.position);
//        if (Distance3 < dropDistance)
//        {
//            isLocked = false;
//            pieceToMove.transform.position = pieceToMoveTo3.transform.position;
//        }

//        float Distance4 = Vector3.Distance(pieceToMove.transform.position, pieceToMoveTo4.transform.position);
//        if (Distance4 < dropDistance)
//        {
//            isLocked = false;
//            pieceToMove.transform.position = pieceToMoveTo4.transform.position;
//        }


//        float Distance5 = Vector3.Distance(pieceToMove.transform.position, pieceToMoveTo5.transform.position);
//        if (Distance5 < dropDistance)
//        {
//            isLocked = false;
//            pieceToMove.transform.position = pieceToMoveTo5.transform.position;
//        }


//        float Distance6 = Vector3.Distance(pieceToMove.transform.position, pieceToMoveTo6.transform.position);
//        if (Distance6 < dropDistance)
//        {
//            isLocked = false;
//            pieceToMove.transform.position = pieceToMoveTo6.transform.position;
//        }


//        float Distance7 = Vector3.Distance(pieceToMove.transform.position, pieceToMoveTo7.transform.position);
//        if (Distance7 < dropDistance)
//        {
//            isLocked = false;
//            pieceToMove.transform.position = pieceToMoveTo7.transform.position;
//        }


//        float Distance8 = Vector3.Distance(pieceToMove.transform.position, pieceToMoveTo8.transform.position);
//        if (Distance8 < dropDistance)
//        {
//            isLocked = false;
//            pieceToMove.transform.position = pieceToMoveTo8.transform.position;
//        }

//        float Distance9 = Vector3.Distance(pieceToMove.transform.position, pieceToMoveTo9.transform.position);
//        if (Distance9 < dropDistance)
//        {
//            isLocked = false;
//            pieceToMove.transform.position = pieceToMoveTo9.transform.position;
//        }

//        if (Distance1 > dropDistance && Distance2 > dropDistance && Distance3 > dropDistance && Distance4 > dropDistance && Distance5 > dropDistance && Distance6 > dropDistance && Distance7 > dropDistance && Distance8 > dropDistance && Distance9 > dropDistance)
//        {
//          //  pieceToMove.transform.position = objectInitPos;
//        }

//    }

//    // Start is called before the first frame update
//    void Start()
//    {
        
//    }

//    // Update is called once per frame
//    void Update()
//    {

//    //    velocity.y = Input.GetAxis("Mouse Y") - 1f;
//    //    controller.Move(velocity * speed * Time.deltaTime);
//    }
//}
