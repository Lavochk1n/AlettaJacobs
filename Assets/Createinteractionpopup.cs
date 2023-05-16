using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Createinteractionpopup : MonoBehaviour
{

    public GameObject interactionText;
    public GameObject textInstance;
    public Transform textPos;
    public bool triggerStay;


    private void OnTriggerEnter(Collider other)
    {
        Instantiate(interactionText, textPos.position, textPos.rotation, textPos.transform);
        textInstance = GameObject.Find("InteractionText(Clone)");
        triggerStay = true;
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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (triggerStay == true)
            {
                SceneManager.LoadScene("Conversation1");
                Debug.Log("space was pressed");
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        Destroy(textInstance);
        triggerStay = false;
    }



}