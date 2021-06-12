using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentNavigation : MonoBehaviour
{
    NavMeshAgent navMeshAgent;
    public Transform target;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        
        InvokeRepeating("SetDestino", 2f, 1f);
    }

    
    void Update()
    {
        
    }

    private void SetDestino()
    {
        navMeshAgent.destination = target.position;

    }
}
