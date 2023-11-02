using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieScript : MonoBehaviour
{
    private NavMeshAgent agent;

    [SerializeField]
    private Transform player;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (agent.destination != player.position)
        {
            agent.destination = player.position;
            Debug.Log("New Destination: " + agent.destination);
        }
    }
}
