using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    public int a = 5;
    public int b = 4;
    public int c = 10;
    public string password = "Friend";
    public bool lightsOn = false;
   
    
    void Start()
    {
        if (a + b != c)
        {
            print(true);
        }
        else
        {
            print(false);
        }

        if (password != "OU812")
        {
           print(true); 
        }

        if (!lightsOn)
        {
            print(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
