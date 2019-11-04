using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Vector3 = System.Numerics.Vector3;

[CreateAssetMenu]
public class AIData : GameArtData
{
    public NavMeshAgent potion;
    private Transform currentDestination;
    private GameObject startObj;
    public Transform potionMovement;
       
    void Start()
    {
        
    }

    private void OnTriggerEnter()
    {
        currentDestination = potionMovement; 
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
