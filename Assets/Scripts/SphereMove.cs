using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using static UnityEngine.GraphicsBuffer;

public class SphereMove : MonoBehaviour
{
    private Rigidbody sphereRd;
    public GameObject Player;
    NavMeshAgent agent;

    private void Start()
    {
        sphereRd = GetComponent<Rigidbody>();
        agent = GetComponent<NavMeshAgent>();
    }
    private void Update()
    {
        agent.destination = Player.transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            transform.localPosition = new Vector3(3, 2.7f, 47);
        }
    }
}
