using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonscript : MonoBehaviour
{

    public GameObject playerMovement1 = null;

    public static bool setPos2 = false;

    public Scene scene;


    public void NextScene()
    {
        SceneManager.LoadScene("whathappened");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ToControls()
    {
        SceneManager.LoadScene("Controls");
    }

    public void ToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void ToConvo()
    {
        SceneManager.LoadScene("Conversation1");
    }

    public void ToGame()
    {
        SceneManager.LoadScene("New Building");
        Createinteractionpopup1.startMinigame = true;
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
        
        SceneManager.LoadScene("New Building");
        setPos2 = true;
     //   Feedbacktext.fDefault = true;

    }

    public void ToGame3()
    {
        SceneManager.LoadScene("New Building");
    }

    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Scene scene = SceneManager.GetActiveScene();
    }

    void Update()
    {

        //if (setPos2 == true)  // scene.name == "New Building" && 
        //{
        //    playerMovement1 = GameObject.Find("Player");
        //    if (playerMovement1 != null )
        //    {
        //    playerMovement1.GetComponent<playerMovement>().SetPos2();
        //    setPos2 = false;

        //    }
        //}
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu");
        }
    }




}



