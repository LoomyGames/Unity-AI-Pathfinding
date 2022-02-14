using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Navigate : MonoBehaviour
{

    private NavMeshAgent agent;
    public Transform target;
    public Transform target2;
    private Vector3 currentTarget;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(agent.transform.position, target.position) < 4f)
        {
            agent.SetDestination(target2.position);
        }
        else if(Vector3.Distance(agent.transform.position, target2.position) < 4f)
        {
            agent.SetDestination(target.position);
        }
        currentTarget = agent.destination;
    }
}
