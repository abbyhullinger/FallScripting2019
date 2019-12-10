using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectGems : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
       ScoringSystem.theScore += 1;
       Destroy(gameObject);
    }
}
