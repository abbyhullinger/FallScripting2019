using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class EnemyHandler : MonoBehaviour
{
    private NavMeshAgent enemy;
    private Transform destination;
    private Transform destinationObj;
    private NavMeshPath enemyPath; 
    
    
    void Start()
    {
        enemy = GetComponent<NavMeshAgent>();
        
    }

    private void OnTriggerEnter(Collider other)
    {
        destination = destinationObj;
    }

    // Update is called once per frame
    void Update()
    {
        }

    public Transform NavMeshPath { get; set; }
}
