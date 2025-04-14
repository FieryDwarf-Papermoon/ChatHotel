using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TeleportSolo : MonoBehaviour
{
    public Transform point;


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("ew");
        //CharacterController character = other.GetComponent<CharacterController>();
        NavMeshAgent agent = other.GetComponent<NavMeshAgent>();
        agent.Warp(point.position);
        //character.enabled = false;
        //other.transform.position = point.position;
        //character.enabled = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
