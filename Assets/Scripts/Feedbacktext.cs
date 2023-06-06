using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Feedbacktext : MonoBehaviour
{

    public static bool fDefault = true;
    public static bool fDefault1 = true;
    public static bool fDefault2 = true;
    public static bool fRight = false;
    public static bool fRight1 = false;
    public static bool fRight2 = false;
    public static bool fWrong = false;
    public static bool inscaptain = false;



    public GameObject interactionText;
    public GameObject interactionText1;
    public GameObject interactionText2;
    public GameObject interactionText3;
    public GameObject interactionText4;
    public GameObject interactionText5;
    public GameObject interactionTextTel;
    public GameObject captain;

    public Transform textPos;
    public Transform textPos1;
    public Transform textPos2;
    public Transform captainPos;

    

    // Start is called before the first frame update
    void Start()
    {
        fDefault = true;
        fDefault1 = true;
        fDefault2 = true;
        if (inscaptain)
        {
            Instantiate(captain, captainPos.position, captainPos.rotation, captainPos.transform);
          //  inscaptain = false;
        }

    }

    // Update is called once per frame
    void Update()
    {
      
        if (fDefault)
        {
            Instantiate(interactionText, textPos.position, textPos.rotation, textPos.transform);
            fDefault = false;
        }
        if (fRight)
        {
            Instantiate(interactionText1, textPos.position, textPos.rotation, textPos.transform);
            if (GameObject.Find("InteractionText 3(Clone)") != null)
            {
                Destroy(GameObject.Find("InteractionText 3(Clone)"));
            }
            fRight = false;
            
        }
        if (fWrong)
        {
            Instantiate(interactionText2, textPos.position, textPos.rotation, textPos.transform);
            
            if (GameObject.Find("InteractionText 3(Clone)") != null)
            {
                Destroy(GameObject.Find("InteractionText 3(Clone)"));
            }
            fWrong= false;
        }


        if (fDefault1)
        {
            Instantiate(interactionTextTel, textPos1.position, textPos1.rotation, textPos1.transform);
            fDefault1 = false;
        }
        if (fRight1)
        {
            Instantiate(interactionText5, textPos1.position, textPos1.rotation, textPos1.transform);
            if (GameObject.Find("InteractionText 6(Clone)") != null)
            {
                Destroy(GameObject.Find("InteractionText 6(Clone)"));
            }
            fRight1 = false;

        }


        if (fDefault2)
        {
            Instantiate(interactionText3, textPos2.position, textPos2.rotation, textPos2.transform);
            fDefault2 = false;
        }
        if (fRight2)
        {
            Instantiate(interactionText4, textPos2.position, textPos2.rotation, textPos2.transform);
            if (GameObject.Find("InteractionText 7(Clone)") != null)
            {
                Destroy(GameObject.Find("InteractionText 7(Clone)"));
            }
            fRight2 = false;

        }



    }
}
