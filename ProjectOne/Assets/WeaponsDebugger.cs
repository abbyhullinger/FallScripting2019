using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponsDebugger : MonoBehaviour
{
    public void OnWeaponSwitch(bool words) 
    {
        Debug.Log(words);
    }

    public void OnDebug()
    {
        Debug.Log(name);
    }
}

