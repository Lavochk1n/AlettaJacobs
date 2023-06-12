using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class movingScript : MonoBehaviour
{

    public GameObject pieceToMove;
    public GameObject pieceToMove2;
    public GameObject pieceToMove3;
    public GameObject pieceToMove4;
    public GameObject pieceToMove5;
    public GameObject pieceToMove6;
    public GameObject pieceToMove7;
    public GameObject pieceToMove8;
    public GameObject pieceToMove9;
    public GameObject pieceToMoveTo1;
    public GameObject pieceToMoveTo2;
    public GameObject pieceToMoveTo3;
    public GameObject pieceToMoveTo4;
    public GameObject pieceToMoveTo5;
    public GameObject pieceToMoveTo6;
    public GameObject pieceToMoveTo7;
    public GameObject pieceToMoveTo8;
    public GameObject pieceToMoveTo9;

    public float dropDistance;

    public bool isLocked;
    public bool rightAnswer = false;

    Vector2 objectInitPos;
    Vector2 objectInitPos2;
    Vector2 objectInitPos3;
    Vector2 objectInitPos4;
    Vector2 objectInitPos5;
    Vector2 objectInitPos6;
    Vector2 objectInitPos7;
    Vector2 objectInitPos8;
    Vector2 objectInitPos9;





    void Start()
    {
     
        objectInitPos = pieceToMove.transform.position;
        objectInitPos2 = pieceToMove2.transform.position;
        objectInitPos3 = pieceToMove3.transform.position;
        objectInitPos4 = pieceToMove4.transform.position;
        objectInitPos5 = pieceToMove5.transform.position;
        objectInitPos6 = pieceToMove6.transform.position;
        objectInitPos7 = pieceToMove7.transform.position;
        objectInitPos8 = pieceToMove8.transform.position;
        objectInitPos9 = pieceToMove9.transform.position;
        Cursor.visible = true;
    }

    void Update()
    {

    }

    public void DragObject()
    {
        if (!isLocked)
        {
            pieceToMove.transform.position = Input.mousePosition;

            if (Input.GetKeyDown(KeyCode.R))
            {
                pieceToMove.transform.Rotate(0.0f, 0.0f, 90.0f, Space.World);
                Debug.Log("R pressed");
            }
        }
    }

    public void DragObject2()
    {
        if (!isLocked)
        {
            pieceToMove2.transform.position = Input.mousePosition;
            if (Input.GetKeyDown(KeyCode.R))
            {
                pieceToMove2.transform.Rotate(0.0f, 0.0f, 90.0f, Space.World);
                Debug.Log("R pressed");
            }
        }
    }

    public void DragObject3()
    {
        if (!isLocked)
        {
            pieceToMove3.transform.position = Input.mousePosition;
            if (Input.GetKeyDown(KeyCode.R))
            {
                pieceToMove3.transform.Rotate(0.0f, 0.0f, 90.0f, Space.World);
                Debug.Log("R pressed");
            }
        }
    }

    public void DragObject4()
    {
        if (!isLocked)
        {
            pieceToMove4.transform.position = Input.mousePosition;
            if (Input.GetKeyDown(KeyCode.R))
            {
                pieceToMove4.transform.Rotate(0.0f, 0.0f, 90.0f, Space.World);
                Debug.Log("R pressed");
            }
        }
    }

    public void DragObject5()
    {
        if (!isLocked)
        {
            pieceToMove5.transform.position = Input.mousePosition;
            if (Input.GetKeyDown(KeyCode.R))
            {
                pieceToMove5.transform.Rotate(0.0f, 0.0f, 90.0f, Space.World);
                Debug.Log("R pressed");
            }
        }
    }

    public void DragObject6()
    {
        if (!isLocked)
        {
            pieceToMove6.transform.position = Input.mousePosition;
            if (Input.GetKeyDown(KeyCode.R))
            {
                pieceToMove6.transform.Rotate(0.0f, 0.0f, 90.0f, Space.World);
                Debug.Log("R pressed");
            }
        }
    }

    public void DragObject7()
    {
        if (!isLocked)
        {
            pieceToMove7.transform.position = Input.mousePosition;
            if (Input.GetKeyDown(KeyCode.R))
            {
                pieceToMove7.transform.Rotate(0.0f, 0.0f, 90.0f, Space.World);
                Debug.Log("R pressed");
            }
        }
    }

    public void DragObject8()
    {
        if (!isLocked)
        {
            pieceToMove8.transform.position = Input.mousePosition;
            if (Input.GetKeyDown(KeyCode.R))
            {
                pieceToMove8.transform.Rotate(0.0f, 0.0f, 90.0f, Space.World);
                Debug.Log("R pressed");
            }
        }
    }

    public void DragObject9()
    {
        if (!isLocked)
        {
            pieceToMove9.transform.position = Input.mousePosition;
            if (Input.GetKeyDown(KeyCode.R))
            {
                pieceToMove9.transform.Rotate(0.0f, 0.0f, 90.0f, Space.World);
                Debug.Log("R pressed");
            }
        }
    }

    public void DropObject()
    {
        float Distance1 = Vector3.Distance(pieceToMove.transform.position, pieceToMoveTo1.transform.position);
        if (Distance1 < dropDistance)
        {
            isLocked = false;
            pieceToMove.transform.position = pieceToMoveTo1.transform.position;
        }
        float Distance2 = Vector3.Distance(pieceToMove.transform.position, pieceToMoveTo2.transform.position);
        if (Distance2 < dropDistance)
        {
            isLocked = false;
            pieceToMove.transform.position = pieceToMoveTo2.transform.position;
        }


        float Distance3 = Vector3.Distance(pieceToMove.transform.position, pieceToMoveTo3.transform.position);
        if (Distance3 < dropDistance)
        {
            isLocked = false;
            pieceToMove.transform.position = pieceToMoveTo3.transform.position;
        }

        float Distance4 = Vector3.Distance(pieceToMove.transform.position, pieceToMoveTo4.transform.position);
        if (Distance4 < dropDistance)
        {
            isLocked = false;
            pieceToMove.transform.position = pieceToMoveTo4.transform.position;
        }


        float Distance5 = Vector3.Distance(pieceToMove.transform.position, pieceToMoveTo5.transform.position);
        if (Distance5 < dropDistance)
        {
            isLocked = false;
            pieceToMove.transform.position = pieceToMoveTo5.transform.position;
        }


        float Distance6 = Vector3.Distance(pieceToMove.transform.position, pieceToMoveTo6.transform.position);
        if (Distance6 < dropDistance)
        {
            isLocked = false;
            pieceToMove.transform.position = pieceToMoveTo6.transform.position;
        }


        float Distance7 = Vector3.Distance(pieceToMove.transform.position, pieceToMoveTo7.transform.position);
        if (Distance7 < dropDistance)
        {
            isLocked = false;
            pieceToMove.transform.position = pieceToMoveTo7.transform.position;
        }


        float Distance8 = Vector3.Distance(pieceToMove.transform.position, pieceToMoveTo8.transform.position);
        if (Distance8 < dropDistance)
        {
            isLocked = false;
            pieceToMove.transform.position = pieceToMoveTo8.transform.position;
        }

        float Distance9 = Vector3.Distance(pieceToMove.transform.position, pieceToMoveTo9.transform.position);
        if (Distance9 < dropDistance)
        {
            isLocked = false;
            pieceToMove.transform.position = pieceToMoveTo9.transform.position;
        }

        if (Distance1 > dropDistance && Distance2 > dropDistance && Distance3 > dropDistance && Distance4 > dropDistance && Distance5 > dropDistance && Distance6 > dropDistance && Distance7 > dropDistance && Distance8 > dropDistance && Distance9 > dropDistance)
        {
            pieceToMove.transform.position = objectInitPos;
        }

    }

    public void DropObject2()
    {
        float Distance1 = Vector3.Distance(pieceToMove2.transform.position, pieceToMoveTo1.transform.position);
        if (Distance1 < dropDistance)
        {
            isLocked = false;
            pieceToMove2.transform.position = pieceToMoveTo1.transform.position;
        }
        float Distance2 = Vector3.Distance(pieceToMove2.transform.position, pieceToMoveTo2.transform.position);
        if (Distance2 < dropDistance)
        {
            isLocked = false;
            pieceToMove2.transform.position = pieceToMoveTo2.transform.position;
        }


        float Distance3 = Vector3.Distance(pieceToMove2.transform.position, pieceToMoveTo3.transform.position);
        if (Distance3 < dropDistance)
        {
            isLocked = false;
            pieceToMove2.transform.position = pieceToMoveTo3.transform.position;
        }

        float Distance4 = Vector3.Distance(pieceToMove2.transform.position, pieceToMoveTo4.transform.position);
        if (Distance4 < dropDistance)
        {
            isLocked = false;
            pieceToMove2.transform.position = pieceToMoveTo4.transform.position;
        }


        float Distance5 = Vector3.Distance(pieceToMove2.transform.position, pieceToMoveTo5.transform.position);
        if (Distance5 < dropDistance)
        {
            isLocked = false;
            pieceToMove2.transform.position = pieceToMoveTo5.transform.position;
        }


        float Distance6 = Vector3.Distance(pieceToMove2.transform.position, pieceToMoveTo6.transform.position);
        if (Distance6 < dropDistance)
        {
            isLocked = false;
            pieceToMove2.transform.position = pieceToMoveTo6.transform.position;
        }


        float Distance7 = Vector3.Distance(pieceToMove2.transform.position, pieceToMoveTo7.transform.position);
        if (Distance7 < dropDistance)
        {
            isLocked = false;
            pieceToMove2.transform.position = pieceToMoveTo7.transform.position;
        }


        float Distance8 = Vector3.Distance(pieceToMove2.transform.position, pieceToMoveTo8.transform.position);
        if (Distance8 < dropDistance)
        {
            isLocked = false;
            pieceToMove2.transform.position = pieceToMoveTo8.transform.position;
        }

        float Distance9 = Vector3.Distance(pieceToMove2.transform.position, pieceToMoveTo9.transform.position);
        if (Distance9 < dropDistance)
        {
            isLocked = false;
            pieceToMove2.transform.position = pieceToMoveTo9.transform.position;
        }

        if (Distance1 > dropDistance && Distance2 > dropDistance && Distance3 > dropDistance && Distance4 > dropDistance && Distance5 > dropDistance && Distance6 > dropDistance && Distance7 > dropDistance && Distance8 > dropDistance && Distance9 > dropDistance)
        {
            pieceToMove2.transform.position = objectInitPos2;
        }

    }

    public void DropObject3()
    {
        float Distance1 = Vector3.Distance(pieceToMove3.transform.position, pieceToMoveTo1.transform.position);
        if (Distance1 < dropDistance)
        {
            isLocked = false;
            pieceToMove3.transform.position = pieceToMoveTo1.transform.position;
        }
        float Distance2 = Vector3.Distance(pieceToMove3.transform.position, pieceToMoveTo2.transform.position);
        if (Distance2 < dropDistance)
        {
            isLocked = false;
            pieceToMove3.transform.position = pieceToMoveTo2.transform.position;
        }


        float Distance3 = Vector3.Distance(pieceToMove3.transform.position, pieceToMoveTo3.transform.position);
        if (Distance3 < dropDistance)
        {
            isLocked = false;
            pieceToMove3.transform.position = pieceToMoveTo3.transform.position;
        }

        float Distance4 = Vector3.Distance(pieceToMove3.transform.position, pieceToMoveTo4.transform.position);
        if (Distance4 < dropDistance)
        {
            isLocked = false;
            pieceToMove3.transform.position = pieceToMoveTo4.transform.position;
        }


        float Distance5 = Vector3.Distance(pieceToMove3.transform.position, pieceToMoveTo5.transform.position);
        if (Distance5 < dropDistance)
        {
            isLocked = false;
            pieceToMove3.transform.position = pieceToMoveTo5.transform.position;
        }


        float Distance6 = Vector3.Distance(pieceToMove3.transform.position, pieceToMoveTo6.transform.position);
        if (Distance6 < dropDistance)
        {
            isLocked = false;
            pieceToMove3.transform.position = pieceToMoveTo6.transform.position;
        }


        float Distance7 = Vector3.Distance(pieceToMove3.transform.position, pieceToMoveTo7.transform.position);
        if (Distance7 < dropDistance)
        {
            isLocked = false;
            pieceToMove3.transform.position = pieceToMoveTo7.transform.position;
        }


        float Distance8 = Vector3.Distance(pieceToMove3.transform.position, pieceToMoveTo8.transform.position);
        if (Distance8 < dropDistance)
        {
            isLocked = false;
            pieceToMove3.transform.position = pieceToMoveTo8.transform.position;
        }

        float Distance9 = Vector3.Distance(pieceToMove3.transform.position, pieceToMoveTo9.transform.position);
        if (Distance9 < dropDistance)
        {
            isLocked = false;
            pieceToMove3.transform.position = pieceToMoveTo9.transform.position;
        }

        if (Distance1 > dropDistance && Distance2 > dropDistance && Distance3 > dropDistance && Distance4 > dropDistance && Distance5 > dropDistance && Distance6 > dropDistance && Distance7 > dropDistance && Distance8 > dropDistance && Distance9 > dropDistance)
        {
            pieceToMove3.transform.position = objectInitPos3;
        }

    }

    public void DropObject4()
    {
        float Distance1 = Vector3.Distance(pieceToMove4.transform.position, pieceToMoveTo1.transform.position);
        if (Distance1 < dropDistance)
        {
            isLocked = false;
            pieceToMove4.transform.position = pieceToMoveTo1.transform.position;
        }
        float Distance2 = Vector3.Distance(pieceToMove4.transform.position, pieceToMoveTo2.transform.position);
        if (Distance2 < dropDistance)
        {
            isLocked = false;
            pieceToMove4.transform.position = pieceToMoveTo2.transform.position;
        }


        float Distance3 = Vector3.Distance(pieceToMove4.transform.position, pieceToMoveTo3.transform.position);
        if (Distance3 < dropDistance)
        {
            isLocked = false;
            pieceToMove4.transform.position = pieceToMoveTo3.transform.position;
        }

        float Distance4 = Vector3.Distance(pieceToMove4.transform.position, pieceToMoveTo4.transform.position);
        if (Distance4 < dropDistance)
        {
            isLocked = false;
            pieceToMove4.transform.position = pieceToMoveTo4.transform.position;
        }


        float Distance5 = Vector3.Distance(pieceToMove4.transform.position, pieceToMoveTo5.transform.position);
        if (Distance5 < dropDistance)
        {
            isLocked = false;
            pieceToMove4.transform.position = pieceToMoveTo5.transform.position;
        }


        float Distance6 = Vector3.Distance(pieceToMove4.transform.position, pieceToMoveTo6.transform.position);
        if (Distance6 < dropDistance)
        {
            isLocked = false;
            pieceToMove4.transform.position = pieceToMoveTo6.transform.position;
        }


        float Distance7 = Vector3.Distance(pieceToMove4.transform.position, pieceToMoveTo7.transform.position);
        if (Distance7 < dropDistance)
        {
            isLocked = false;
            pieceToMove4.transform.position = pieceToMoveTo7.transform.position;
        }


        float Distance8 = Vector3.Distance(pieceToMove4.transform.position, pieceToMoveTo8.transform.position);
        if (Distance8 < dropDistance)
        {
            isLocked = false;
            pieceToMove4.transform.position = pieceToMoveTo8.transform.position;
        }

        float Distance9 = Vector3.Distance(pieceToMove4.transform.position, pieceToMoveTo9.transform.position);
        if (Distance9 < dropDistance)
        {
            isLocked = false;
            pieceToMove4.transform.position = pieceToMoveTo9.transform.position;
        }

        if (Distance1 > dropDistance && Distance2 > dropDistance && Distance3 > dropDistance && Distance4 > dropDistance && Distance5 > dropDistance && Distance6 > dropDistance && Distance7 > dropDistance && Distance8 > dropDistance && Distance9 > dropDistance)
        {
            pieceToMove4.transform.position = objectInitPos4;
        }

    }

    public void DropObject5()
    {
        float Distance1 = Vector3.Distance(pieceToMove5.transform.position, pieceToMoveTo1.transform.position);
        if (Distance1 < dropDistance)
        {
            isLocked = false;
            pieceToMove5.transform.position = pieceToMoveTo1.transform.position;
        }
        float Distance2 = Vector3.Distance(pieceToMove5.transform.position, pieceToMoveTo2.transform.position);
        if (Distance2 < dropDistance)
        {
            isLocked = false;
            pieceToMove5.transform.position = pieceToMoveTo2.transform.position;
        }


        float Distance3 = Vector3.Distance(pieceToMove5.transform.position, pieceToMoveTo3.transform.position);
        if (Distance3 < dropDistance)
        {
            isLocked = false;
            pieceToMove5.transform.position = pieceToMoveTo3.transform.position;
        }

        float Distance4 = Vector3.Distance(pieceToMove5.transform.position, pieceToMoveTo4.transform.position);
        if (Distance4 < dropDistance)
        {
            isLocked = false;
            pieceToMove5.transform.position = pieceToMoveTo4.transform.position;
        }


        float Distance5 = Vector3.Distance(pieceToMove5.transform.position, pieceToMoveTo5.transform.position);
        if (Distance5 < dropDistance)
        {
            isLocked = false;
            pieceToMove5.transform.position = pieceToMoveTo5.transform.position;
        }


        float Distance6 = Vector3.Distance(pieceToMove5.transform.position, pieceToMoveTo6.transform.position);
        if (Distance6 < dropDistance)
        {
            isLocked = false;
            pieceToMove5.transform.position = pieceToMoveTo6.transform.position;
        }


        float Distance7 = Vector3.Distance(pieceToMove5.transform.position, pieceToMoveTo7.transform.position);
        if (Distance7 < dropDistance)
        {
            isLocked = false;
            pieceToMove5.transform.position = pieceToMoveTo7.transform.position;
        }


        float Distance8 = Vector3.Distance(pieceToMove5.transform.position, pieceToMoveTo8.transform.position);
        if (Distance8 < dropDistance)
        {
            isLocked = false;
            pieceToMove5.transform.position = pieceToMoveTo8.transform.position;
        }

        float Distance9 = Vector3.Distance(pieceToMove5.transform.position, pieceToMoveTo9.transform.position);
        if (Distance9 < dropDistance)
        {
            isLocked = false;
            pieceToMove5.transform.position = pieceToMoveTo9.transform.position;
        }

        if (Distance1 > dropDistance && Distance2 > dropDistance && Distance3 > dropDistance && Distance4 > dropDistance && Distance5 > dropDistance && Distance6 > dropDistance && Distance7 > dropDistance && Distance8 > dropDistance && Distance9 > dropDistance)
        {
            pieceToMove5.transform.position = objectInitPos5;
        }

    }

    public void DropObject6()
    {
        float Distance1 = Vector3.Distance(pieceToMove6.transform.position, pieceToMoveTo1.transform.position);
        if (Distance1 < dropDistance)
        {
            isLocked = false;
            pieceToMove6.transform.position = pieceToMoveTo1.transform.position;
        }
        float Distance2 = Vector3.Distance(pieceToMove6.transform.position, pieceToMoveTo2.transform.position);
        if (Distance2 < dropDistance)
        {
            isLocked = false;
            pieceToMove6.transform.position = pieceToMoveTo2.transform.position;
        }


        float Distance3 = Vector3.Distance(pieceToMove6.transform.position, pieceToMoveTo3.transform.position);
        if (Distance3 < dropDistance)
        {
            isLocked = false;
            pieceToMove6.transform.position = pieceToMoveTo3.transform.position;
        }

        float Distance4 = Vector3.Distance(pieceToMove6.transform.position, pieceToMoveTo4.transform.position);
        if (Distance4 < dropDistance)
        {
            isLocked = false;
            pieceToMove6.transform.position = pieceToMoveTo4.transform.position;
        }


        float Distance5 = Vector3.Distance(pieceToMove6.transform.position, pieceToMoveTo5.transform.position);
        if (Distance5 < dropDistance)
        {
            isLocked = false;
            pieceToMove6.transform.position = pieceToMoveTo5.transform.position;
        }


        float Distance6 = Vector3.Distance(pieceToMove6.transform.position, pieceToMoveTo6.transform.position);
        if (Distance6 < dropDistance)
        {
            isLocked = false;
            pieceToMove6.transform.position = pieceToMoveTo6.transform.position;
        }


        float Distance7 = Vector3.Distance(pieceToMove6.transform.position, pieceToMoveTo7.transform.position);
        if (Distance7 < dropDistance)
        {
            isLocked = false;
            pieceToMove6.transform.position = pieceToMoveTo7.transform.position;
        }


        float Distance8 = Vector3.Distance(pieceToMove6.transform.position, pieceToMoveTo8.transform.position);
        if (Distance8 < dropDistance)
        {
            isLocked = false;
            pieceToMove6.transform.position = pieceToMoveTo8.transform.position;
        }

        float Distance9 = Vector3.Distance(pieceToMove6.transform.position, pieceToMoveTo9.transform.position);
        if (Distance9 < dropDistance)
        {
            isLocked = false;
            pieceToMove6.transform.position = pieceToMoveTo9.transform.position;
        }

        if (Distance1 > dropDistance && Distance2 > dropDistance && Distance3 > dropDistance && Distance4 > dropDistance && Distance5 > dropDistance && Distance6 > dropDistance && Distance7 > dropDistance && Distance8 > dropDistance && Distance9 > dropDistance)
        {
            pieceToMove6.transform.position = objectInitPos6;
        }

    }

    public void DropObject7()
    {
        float Distance1 = Vector3.Distance(pieceToMove7.transform.position, pieceToMoveTo1.transform.position);
        if (Distance1 < dropDistance)
        {
            isLocked = false;
            pieceToMove7.transform.position = pieceToMoveTo1.transform.position;
        }
        float Distance2 = Vector3.Distance(pieceToMove7.transform.position, pieceToMoveTo2.transform.position);
        if (Distance2 < dropDistance)
        {
            isLocked = false;
            pieceToMove7.transform.position = pieceToMoveTo2.transform.position;
        }


        float Distance3 = Vector3.Distance(pieceToMove7.transform.position, pieceToMoveTo3.transform.position);
        if (Distance3 < dropDistance)
        {
            isLocked = false;
            pieceToMove7.transform.position = pieceToMoveTo3.transform.position;
        }

        float Distance4 = Vector3.Distance(pieceToMove7.transform.position, pieceToMoveTo4.transform.position);
        if (Distance4 < dropDistance)
        {
            isLocked = false;
            pieceToMove7.transform.position = pieceToMoveTo4.transform.position;
        }


        float Distance5 = Vector3.Distance(pieceToMove7.transform.position, pieceToMoveTo5.transform.position);
        if (Distance5 < dropDistance)
        {
            isLocked = false;
            pieceToMove7.transform.position = pieceToMoveTo5.transform.position;
        }


        float Distance6 = Vector3.Distance(pieceToMove7.transform.position, pieceToMoveTo6.transform.position);
        if (Distance6 < dropDistance)
        {
            isLocked = false;
            pieceToMove7.transform.position = pieceToMoveTo6.transform.position;
        }


        float Distance7 = Vector3.Distance(pieceToMove7.transform.position, pieceToMoveTo7.transform.position);
        if (Distance7 < dropDistance)
        {
            isLocked = false;
            pieceToMove7.transform.position = pieceToMoveTo7.transform.position;
        }


        float Distance8 = Vector3.Distance(pieceToMove7.transform.position, pieceToMoveTo8.transform.position);
        if (Distance8 < dropDistance)
        {
            isLocked = false;
            pieceToMove7.transform.position = pieceToMoveTo8.transform.position;
        }

        float Distance9 = Vector3.Distance(pieceToMove7.transform.position, pieceToMoveTo9.transform.position);
        if (Distance9 < dropDistance)
        {
            isLocked = false;
            pieceToMove7.transform.position = pieceToMoveTo9.transform.position;
        }

        if (Distance1 > dropDistance && Distance2 > dropDistance && Distance3 > dropDistance && Distance4 > dropDistance && Distance5 > dropDistance && Distance6 > dropDistance && Distance7 > dropDistance && Distance8 > dropDistance && Distance9 > dropDistance)
        {
            pieceToMove7.transform.position = objectInitPos7;
        }

    }

    public void DropObject8()
    {
        float Distance1 = Vector3.Distance(pieceToMove8.transform.position, pieceToMoveTo1.transform.position);
        if (Distance1 < dropDistance)
        {
            isLocked = false;
            pieceToMove8.transform.position = pieceToMoveTo1.transform.position;
        }
        float Distance2 = Vector3.Distance(pieceToMove8.transform.position, pieceToMoveTo2.transform.position);
        if (Distance2 < dropDistance)
        {
            isLocked = false;
            pieceToMove8.transform.position = pieceToMoveTo2.transform.position;
        }


        float Distance3 = Vector3.Distance(pieceToMove8.transform.position, pieceToMoveTo3.transform.position);
        if (Distance3 < dropDistance)
        {
            isLocked = false;
            pieceToMove8.transform.position = pieceToMoveTo3.transform.position;
        }

        float Distance4 = Vector3.Distance(pieceToMove8.transform.position, pieceToMoveTo4.transform.position);
        if (Distance4 < dropDistance)
        {
            isLocked = false;
            pieceToMove8.transform.position = pieceToMoveTo4.transform.position;
        }


        float Distance5 = Vector3.Distance(pieceToMove8.transform.position, pieceToMoveTo5.transform.position);
        if (Distance5 < dropDistance)
        {
            isLocked = false;
            pieceToMove8.transform.position = pieceToMoveTo5.transform.position;
        }


        float Distance6 = Vector3.Distance(pieceToMove8.transform.position, pieceToMoveTo6.transform.position);
        if (Distance6 < dropDistance)
        {
            isLocked = false;
            pieceToMove8.transform.position = pieceToMoveTo6.transform.position;
        }


        float Distance7 = Vector3.Distance(pieceToMove8.transform.position, pieceToMoveTo7.transform.position);
        if (Distance7 < dropDistance)
        {
            isLocked = false;
            pieceToMove8.transform.position = pieceToMoveTo7.transform.position;
        }


        float Distance8 = Vector3.Distance(pieceToMove8.transform.position, pieceToMoveTo8.transform.position);
        if (Distance8 < dropDistance)
        {
            isLocked = false;
            pieceToMove8.transform.position = pieceToMoveTo8.transform.position;
        }

        float Distance9 = Vector3.Distance(pieceToMove8.transform.position, pieceToMoveTo9.transform.position);
        if (Distance9 < dropDistance)
        {
            isLocked = false;
            pieceToMove8.transform.position = pieceToMoveTo9.transform.position;
        }

        if (Distance1 > dropDistance && Distance2 > dropDistance && Distance3 > dropDistance && Distance4 > dropDistance && Distance5 > dropDistance && Distance6 > dropDistance && Distance7 > dropDistance && Distance8 > dropDistance && Distance9 > dropDistance)
        {
            pieceToMove8.transform.position = objectInitPos8;
        }

    }

    public void DropObject9()
    {
        float Distance1 = Vector3.Distance(pieceToMove9.transform.position, pieceToMoveTo1.transform.position);
        if (Distance1 < dropDistance)
        {
            isLocked = false;
            pieceToMove9.transform.position = pieceToMoveTo1.transform.position;
        }
        float Distance2 = Vector3.Distance(pieceToMove9.transform.position, pieceToMoveTo2.transform.position);
        if (Distance2 < dropDistance)
        {
            isLocked = false;
            pieceToMove9.transform.position = pieceToMoveTo2.transform.position;
        }


        float Distance3 = Vector3.Distance(pieceToMove9.transform.position, pieceToMoveTo3.transform.position);
        if (Distance3 < dropDistance)
        {
            isLocked = false;
            pieceToMove9.transform.position = pieceToMoveTo3.transform.position;
        }

        float Distance4 = Vector3.Distance(pieceToMove9.transform.position, pieceToMoveTo4.transform.position);
        if (Distance4 < dropDistance)
        {
            isLocked = false;
            pieceToMove9.transform.position = pieceToMoveTo4.transform.position;
        }


        float Distance5 = Vector3.Distance(pieceToMove9.transform.position, pieceToMoveTo5.transform.position);
        if (Distance5 < dropDistance)
        {
            isLocked = false;
            pieceToMove9.transform.position = pieceToMoveTo5.transform.position;
        }


        float Distance6 = Vector3.Distance(pieceToMove9.transform.position, pieceToMoveTo6.transform.position);
        if (Distance6 < dropDistance)
        {
            isLocked = false;
            pieceToMove9.transform.position = pieceToMoveTo6.transform.position;
        }


        float Distance7 = Vector3.Distance(pieceToMove9.transform.position, pieceToMoveTo7.transform.position);
        if (Distance7 < dropDistance)
        {
            isLocked = false;
            pieceToMove9.transform.position = pieceToMoveTo7.transform.position;
        }


        float Distance8 = Vector3.Distance(pieceToMove9.transform.position, pieceToMoveTo8.transform.position);
        if (Distance8 < dropDistance)
        {
            isLocked = false;
            pieceToMove9.transform.position = pieceToMoveTo8.transform.position;
        }

        float Distance9 = Vector3.Distance(pieceToMove9.transform.position, pieceToMoveTo9.transform.position);
        if (Distance9 < dropDistance)
        {
            isLocked = false;
            pieceToMove9.transform.position = pieceToMoveTo9.transform.position;
        }

        if (Distance1 > dropDistance && Distance2 > dropDistance && Distance3 > dropDistance && Distance4 > dropDistance && Distance5 > dropDistance && Distance6 > dropDistance && Distance7 > dropDistance && Distance8 > dropDistance && Distance9 > dropDistance)
        {
            pieceToMove9.transform.position = objectInitPos9;
        }

    }

    public void Checkpuzzle()
    {

        float Distance1 = Vector3.Distance(pieceToMove.transform.position, pieceToMoveTo1.transform.position);
        float Distance2 = Vector3.Distance(pieceToMove2.transform.position, pieceToMoveTo2.transform.position);
        float Distance3 = Vector3.Distance(pieceToMove3.transform.position, pieceToMoveTo3.transform.position);
        float Distance4 = Vector3.Distance(pieceToMove4.transform.position, pieceToMoveTo4.transform.position);
        float Distance5 = Vector3.Distance(pieceToMove5.transform.position, pieceToMoveTo5.transform.position);
        float Distance6 = Vector3.Distance(pieceToMove6.transform.position, pieceToMoveTo6.transform.position);
        float Distance7 = Vector3.Distance(pieceToMove7.transform.position, pieceToMoveTo7.transform.position);
        float Distance8 = Vector3.Distance(pieceToMove8.transform.position, pieceToMoveTo8.transform.position);
        float Distance9 = Vector3.Distance(pieceToMove9.transform.position, pieceToMoveTo9.transform.position);
        if (Distance1 < 10 && Distance2 < 10 && Distance3 < 10 && Distance4 < 10 && Distance5 < 10 && Distance6 < 10 && Distance7 < 10 && Distance8 < 10 && Distance9 < 10)
        {
            rightAnswer = true;
        }
        else
        {
            rightAnswer = false;
        }

        if (rightAnswer == true)
        {
            SceneManager.LoadScene("New Building");
            buttonscript.setPos2 = true;
            Feedbacktext.fRight = true;
            Feedbacktext.lastInst = 1;
            UI.check1 = true;

            Createinteractionpopup1.startMinigame = false;

        }
        else
        {
           SceneManager.LoadScene("New Building");
           buttonscript.setPos2 = true;
           Feedbacktext.fWrong = true;

        }
    }


}
