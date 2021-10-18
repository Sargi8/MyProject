using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{

    public PlayerControler Player;
    public Transform torse;
    public float speedRotation = 2f;
    public NavMeshAgent navMeshAgent;
    public Transform[] wayPoints;
    private int m_CurrentWaypointIndex;

    private void Awake()
    {
        //нахождение плеера на сцене
        Player = GameObject.FindObjectOfType<PlayerControler>();
        navMeshAgent = GetComponent<NavMeshAgent>();
        
    }

    void Start()
    {
        navMeshAgent.SetDestination(wayPoints[0].position);
    }

    void FixedUpdate()
    {
        if(navMeshAgent.remainingDistance <= navMeshAgent.stoppingDistance)
        {
            m_CurrentWaypointIndex = (m_CurrentWaypointIndex + 1) % wayPoints.Length;
            navMeshAgent.SetDestination(wayPoints[m_CurrentWaypointIndex].position);
        }

        Vector3 direction = Player.transform.position - torse.position;
        Vector3 forwardDirection = new Vector3(direction.x, 0, direction.z);

        Vector3 stepRotation = Vector3.RotateTowards(torse.forward, forwardDirection, speedRotation * Time.fixedDeltaTime, 0.0f);

        torse.rotation = Quaternion.LookRotation(stepRotation);
    }
}
