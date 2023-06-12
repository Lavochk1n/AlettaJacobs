using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Createinteractionpopup4 : MonoBehaviour
{

    public GameObject interactionText;
    public GameObject textInstance;
    public Transform textPos;
    public bool triggerStay;
    public static bool c4 = true;


    private void OnTriggerEnter(Collider other)
    {
        if (c4)
        {
            Instantiate(interactionText, textPos.position, textPos.rotation, textPos.transform);
            textInstance = GameObject.Find("InteractionText 2(Clone)");
            triggerStay = true;
        }
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

    }


    void Update()
    {
        if (c4)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (triggerStay == true)
                {
                    //  playerMovement.setPos3 = true;
                    SceneManager.LoadScene("TelescopeMinigame");
                    Debug.Log("space was pressed");
                }
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (c4)
        {
            Destroy(textInstance);
            triggerStay = false;
        }
    }



}