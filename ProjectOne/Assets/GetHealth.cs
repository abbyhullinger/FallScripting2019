using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetHealth : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        HealthSystem.theHealth += 1;
        Destroy(gameObject);
        
    }
}
