using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Feedbacktext : MonoBehaviour
{

    public static bool fDefault = true;
    public static bool fDefault1 = true;
    public static bool fRight = false;
    public static bool fRight1 = false;
    public static bool fWrong = false;
    public static int lastInst = 0;
    public static int lastInst1 = 0;



    public GameObject interactionText;
    public GameObject interactionText1;
    public GameObject interactionText2;
    public GameObject interactionText3;
    public GameObject interactionTextTel;
    public Transform textPos;
    public Transform textPos1;

    

    // Start is called before the first frame update
    void Start()
    {
        if (lastInst == 0)
        {
            fDefault = true;
        }

        if (lastInst == 1)
        {
            fRight= true;
        }
        if (lastInst == 2)
        {
            fWrong = true;
        }
        if (lastInst1 == 3)
        {
            fRight1 = true;
        }
        else
        {
            fDefault1= true;
        }

        

    }

    // Update is called once per frame
    void Update()
    {
      
        if (fDefault)
        {
            Instantiate(interactionText, textPos.position, textPos.rotation, textPos.transform);
            fDefault = false;
            lastInst = 0;
        }
        if (fRight)
        {
            Instantiate(interactionText1, textPos.position, textPos.rotation, textPos.transform);
            if (GameObject.Find("InteractionText 3(Clone)") != null)
            {
                Destroy(GameObject.Find("InteractionText 3(Clone)"));
            }
            fRight = false;
            lastInst= 1;
            
        }
        if (fWrong)
        {
            Instantiate(interactionText2, textPos.position, textPos.rotation, textPos.transform);
            
            if (GameObject.Find("InteractionText 3(Clone)") != null)
            {
                Destroy(GameObject.Find("InteractionText 3(Clone)"));
            }
            fWrong= false;
            lastInst = 2;
        }


        if (fDefault1)
        {
            Instantiate(interactionTextTel, textPos1.position, textPos1.rotation, textPos1.transform);
            fDefault1 = false;
        }
        if (fRight1)
        {
            Instantiate(interactionText3, textPos1.position, textPos1.rotation, textPos1.transform);
            if (GameObject.Find("InteractionText 6(Clone)") != null)
            {
                Destroy(GameObject.Find("InteractionText 6(Clone)"));
            }
            fRight1 = false;
            lastInst1 = 3;

        }
        


    }
}
