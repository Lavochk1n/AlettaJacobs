using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Createinteractionpopup3 : MonoBehaviour
{

    public GameObject interactionText;
    public GameObject interactionTextToInstantiate;
    public GameObject interactionText1;
    public GameObject interactionText2;
    public GameObject textInstance;
    public Transform textPos;
    public bool triggerStay1 = false;

    public static bool fRight = false;
    public static bool fWrong = false;
    public static bool pm = true;
    public static int lastInst = 0;


    private void OnTriggerEnter(Collider other)
    {
        
            if (GameObject.Find("InteractionText 5(Clone)") == null && GameObject.Find("InteractionText 9(Clone)") == null)
            {
                Instantiate(interactionText, textPos.position, textPos.rotation, textPos.transform);
                textInstance = GameObject.Find("InteractionText 8(Clone)");
            }
                triggerStay1 = true;
            
        
    }
   

    //  void OnTriggerStay(Collider other)
    //  {
    //      if (Input.GetKeyDown(KeyCode.Space))
    //      {
    //          SceneManager.LoadScene("Conversation1");
    //          Debug.Log("space was pressed");
    //      }
    // }

    // Start is called before the first frame update
    void Start()
    {
        if (lastInst == 1)
        {
            fRight = true;
        }
        if (lastInst == 2)
        {
            fWrong = true;
        }


    }


    void Update()
    {
        if (pm)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (triggerStay1 == true)
                {
                    SceneManager.LoadScene("Painting minigame");
                    Debug.Log("space was pressed");
                }
            }
        }

            if (fRight)
            {
                Instantiate(interactionText1, textPos.position, textPos.rotation, textPos.transform);
                if (GameObject.Find("InteractionText 8(Clone)") != null)
                {
                    Destroy(GameObject.Find("InteractionText 8(Clone)"));
                }
                fRight = false;
                lastInst = 1;

            }
            if (fWrong)
            {
                Instantiate(interactionText2, textPos.position, textPos.rotation, textPos.transform);

                if (GameObject.Find("InteractionText 8(Clone)") != null)
                {
                    Destroy(GameObject.Find("InteractionText 8(Clone)"));
                }
                fWrong = false;
                lastInst = 2;
            }
        
    }

    void OnTriggerExit(Collider other)
    {
        
            Destroy(textInstance);
            triggerStay1 = false;
        
    }



}