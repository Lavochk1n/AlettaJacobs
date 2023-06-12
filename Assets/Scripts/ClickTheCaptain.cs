using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickTheCaptain : MonoBehaviour
{


    public GameObject camera1;
    public GameObject objectToClick;
    public GameObject objectToNotClick;
    public GameObject objectToNotClick1;
    public GameObject objectToNotClick2;
    public GameObject objectToNotClick3;
    public GameObject objectToNotClick4;
    public GameObject objectToNotClick5;
    public GameObject objectToNotClick6;
    public GameObject objectToNotClick7;
    public GameObject objectToNotClick8;

    // Start is called before the first frame update
    void Start()
    {
       Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        { // if left button pressed...

            Ray ray;
            ray = new Ray(camera1.GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition), camera1.GetComponent<Camera>().transform.forward);
            // or ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 1000f))
            {



                if (hit.transform == objectToClick.transform)
                {
                      SceneManager.LoadScene("FirstQuestion");
                  //  Createinteractionpopup3.pm = false;
                    Debug.Log("Right object clicked");

                }
                else if (hit.transform == objectToNotClick.transform || hit.transform == objectToNotClick1.transform || hit.transform == objectToNotClick2.transform || hit.transform == objectToNotClick3.transform || hit.transform == objectToNotClick4.transform || hit.transform == objectToNotClick5.transform || hit.transform == objectToNotClick6.transform || hit.transform == objectToNotClick7.transform || hit.transform == objectToNotClick8.transform)
                {
                    // write a message like wrong object

                    SceneManager.LoadScene("New Building");
                    playerMovement.setPos5 = true;
                    Createinteractionpopup3.fWrong = true;

                }



            }

        }
    }
}
