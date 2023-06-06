using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInspector : MonoBehaviour
{
    [SerializeField] private GameObject imageQuadUI;
    [SerializeField] private bool quadShwoing = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("InfoBoard"))
        {
            imageQuadUI.SetActive(true);
            imageQuadUI.GetComponent<Animator>().Play("QuadOpen");

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("InfoBoard"))
        {
            imageQuadUI.SetActive(false);


        }
    }
}
