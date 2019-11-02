using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponLoop : MonoBehaviour
{
    private int weaponNumber = 4; 
    void Start()
    {
        for (int i = 0; i < weaponNumber; i++)
        {
            Debug.Log("Number of Weapons: " + i);
        }

        
    }

   
}
