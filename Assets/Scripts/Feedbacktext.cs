using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Feedbacktext : MonoBehaviour
{

    public static bool fDefault = true;
    public static bool fRight = false;
    public static bool fWrong = false;

    public GameObject interactionText;
    public GameObject interactionText1;
    public GameObject interactionText2;
    public Transform textPos;
    public Transform textPos1;

    

    // Start is called before the first frame update
    void Start()
    {
        fDefault = true;
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
        
        

    }
}
