using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Following : MonoBehaviour
{

    public Transform player;
    NavMeshAgent nav;

    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
 
    }

    // Update is called once per frame
    void Update()
    {
        nav.SetDestination(player.position);

    }
  
}
