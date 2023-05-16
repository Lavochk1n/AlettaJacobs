using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonscript : MonoBehaviour
{

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
        SceneManager.LoadScene("GameRoom1");
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
        SceneManager.LoadScene("GameRoom2");
    }

    public void ToGame3()
    {
        SceneManager.LoadScene("GameRoom3");
    }

    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }





}



