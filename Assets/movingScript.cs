using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class movingScript : MonoBehaviour
{

    public GameObject pieceToMove;
    public GameObject pieceToMoveTo;

    public float dropDistance;

    public bool isLocked;

    Vector2 objectInitPos;

    void Start()
    {
        objectInitPos = pieceToMove.transform.position;
    }

   public void DragObject()
    {
        if (!isLocked)
        {
            pieceToMove.transform.position = Input.mousePosition;
        }
    }

    public void DropObject ()
    {
        float Distance = Vector3.Distance(pieceToMove.transform.position, pieceToMoveTo.transform.position);
        if (Distance < dropDistance)
        {
            isLocked = true;
            pieceToMove.transform.position = pieceToMoveTo.transform.position;
        }
        else
        {
            pieceToMove.transform.position = objectInitPos;
        }
    }


}
