using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class NavMesh : MonoBehaviour
{
    [SerializeField] public Transform[] Points;

    public NavMeshAgent agent;
    public float Speed;
    void Start()
    {
        //MonstersUp.s_MonstersUp.OnMonstersUpgradeed += SpeedChange;

        agent = GetComponent<NavMeshAgent>();
    }


    void Update()
    {
        agent.speed = Enemy.speedUP;
        var destP = Points[Random.RandomRange(0, Points.Length)];
        if (!agent.pathPending && agent.remainingDistance <= 0.5f)
        {
            agent.destination = destP.position;

        }
    }
    //public void SpeedChange()
    //{
    //    Speed += 0.1f;
    //}
}