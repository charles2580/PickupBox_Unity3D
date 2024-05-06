using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mbox1 : MonoBehaviour
{
    public Transform tbox;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.transform.position = tbox.position;
        }
    }
    
}
