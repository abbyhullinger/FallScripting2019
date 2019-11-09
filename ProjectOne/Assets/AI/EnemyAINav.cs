using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class EnemyAINav : MonoBehaviour
{
    private NavMeshAgent enemyAgent;
    private Vector3Data enemyLocation; 
   void Start()
   {
       enemyAgent = GetComponent<NavMeshAgent>();
   }

   private void OnTriggerEnter()
   {
       enemyAgent.destination = enemyLocation.value;
   }
    
}
