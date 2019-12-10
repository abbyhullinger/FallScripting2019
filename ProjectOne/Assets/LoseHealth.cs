using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseHealth : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        HealthSystem.theHealth -= 1;
        Destroy(gameObject);
        
    }
}
