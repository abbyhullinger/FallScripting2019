using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class PlatformHandler : MonoBehaviour
{
    private NavMeshAgent platformAI;
    private Transform destination;
    private  Transform platformMovement;
    
    
    void Start()
    {
        platformAI = GetComponent<NavMeshAgent>();
        destination = transform;
    }

    private void OnTriggerEnter(Collider other)
    {
        destination = platformMovement; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
