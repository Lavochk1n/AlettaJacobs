using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonscript : MonoBehaviour
{

   // public GameObject playerMovement1;


    public void NextScene()
    {
        SceneManager.LoadScene("whathappened");
    }

    public void ToConvo()
    {
        SceneManager.LoadScene("Conversation1");
    }

    public void ToGame()
    {
        SceneManager.LoadScene("New Building");
    }

    public void ToWho()
    {
        SceneManager.LoadScene("whoareyou");
    }

    public void ToWhat()
    {
        SceneManager.LoadScene("Whatshould");
    }

    public void ToGame2()
    {
       // playerMovement1.GetComponent<playerMovement>().SetPos2();
        SceneManager.LoadScene("New Building");
        
    }

    public void ToGame3()
    {
        SceneManager.LoadScene("New Building");
    }

    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
      //  playerMovement1 = GameObject.Find("something");
    }





}



