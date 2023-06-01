using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickTheCaptain : MonoBehaviour
{


    public GameObject camera1;
    public GameObject objectToClick;

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
                      SceneManager.LoadScene("New Building");
                    Debug.Log("Right object clicked");

                }
                else
                {
                    // write a message like wrong object

                }



            }

        }
    }
}
