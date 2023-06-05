using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Createinteractionpopup1 : MonoBehaviour
{

    public GameObject interactionText;
    public GameObject textInstance;
    public Transform textPos;
    public bool triggerStay;
    public static bool startMinigame = true;


    private void OnTriggerEnter(Collider other)
    {
        if (startMinigame)
        {


            Instantiate(interactionText, textPos.position, textPos.rotation, textPos.transform);
            textInstance = GameObject.Find("InteractionText 1(Clone)");
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
        if (startMinigame)
        {


            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (triggerStay == true)
                {
                    SceneManager.LoadScene("Conversation2");
                    Debug.Log("space was pressed");
                }
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (startMinigame)
        {


            Destroy(textInstance);
            triggerStay = false;
        }
    }



}