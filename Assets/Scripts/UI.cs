using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{

    public static bool check1 = false;
    public static bool check2 = false;
    public static bool check3 = false;
    public static bool check4 = false;
   
    

    public static bool sCheck1 = false;
    public static bool sCheck2 = false;
    public static bool sCheck3 = false;
    public static bool sCheck4 = false;

    public TMP_Text text1;
    public TMP_Text text2;
    public TMP_Text text3;
    public TMP_Text text4;
   
    
    // Start is called before the first frame update
    void Start()
    {
        if (sCheck1)
        {
            check1= true;
        }
        if (sCheck2)
        {
            check2 = true;
        }
        if (sCheck3)
        {
            check3 = true;
        }
        if (sCheck4)
        {
            check4 = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (check1)
        {
            text1.text = "                                         1/1";
            check1= false;
            sCheck1= true;
        }

        if (check2)
        {
            text2.text = "                                         \r\n\r\n                                         1/1\r\n\r\n";
            check2 = false;
            sCheck2 = true;
        }

        if (check3)
        {
            text3.text = "                                         \r\n\r\n                                         \r\n\r\n                                         1/1";
            check3 = false;
            sCheck3 = true;
        }

        if (check4)
        {
            text4.text = "                                         \r\n\r\n                                         \r\n\r\n                                         \r\n\r\n                                         1/1";
            check4 = false;
            sCheck4 = true;
        }

    }
    
    
  
}
