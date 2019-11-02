using UnityEngine;
using UnityEngine.AI;
using Vector3 = System.Numerics.Vector3;

[RequireComponent(typeof(NavMeshAgent))]
public class EnemyHandler : MonoBehaviour
{
    private NavMeshAgent enemy;
    private Transform destination;
    private Transform destinationObj;
    private NavMeshPath enemyPath;
    public Vector3 corners; 
    
    
    void Start()
    {
        enemy = GetComponent<NavMeshAgent>();
        destination = NavMeshPath.transform;
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
