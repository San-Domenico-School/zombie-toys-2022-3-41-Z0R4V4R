using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class NavMeshController : MonoBehaviour
{
    // Private serialized field for target Transform
    [SerializeField] private Transform target;
    [SerializeField] private NavMeshAgent agent;

    // Private field for speed
    private float speed;

    

    // Start is called before the first frame update
    void Start()
    {
        // You can initialize speed here if needed, for example:
        speed = 5f; // Set the default speed to 5 units per second
        //agent.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.position);

    }
}