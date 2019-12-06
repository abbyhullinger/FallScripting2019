using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireWeapons : MonoBehaviour
{
    public ApplyForce ammo;
    public void Fire()
    {
      Instantiate(ammo, transform.position, Quaternion.identity);
       
    }
}
