using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Createinteractionpopup3 : MonoBehaviour
{

    public GameObject interactionText;
    public GameObject textInstance;
    public Transform textPos;
    public bool triggerStay1 = false;


    private void OnTriggerEnter(Collider other)
    {
        //     Instantiate(interactionText, textPos.position, textPos.rotation, textPos.transform);
        //     textInstance = GameObject.Find("InteractionText 2(Clone)");
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

    }


    void Update()
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

    void OnTriggerExit(Collider other)
    {
     //   Destroy(textInstance);
        triggerStay1 = false;
    }



}