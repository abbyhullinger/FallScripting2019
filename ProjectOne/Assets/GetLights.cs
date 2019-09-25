using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetLights : MonoBehaviour
{
    public bool lightIsOn, lightIsOff; 
   
    void Start()
    {
        if (lightIsOff)
        {
            print("It's dark in here!");
        }
        else if (lightIsOn)
        {
           print("It's too bright!"); 
        }
        
    }

}
