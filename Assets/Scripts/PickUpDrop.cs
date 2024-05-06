using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PickUpDrop : MonoBehaviour
{
    public Transform PickupPoint;
    public Transform player;

    public float pickupDistance;

    public bool itemPickup;

    private Rigidbody obRd;
    Vector3 startpos;
    private void Start()
    {
        itemPickup = false;
        obRd = GetComponent<Rigidbody>();       
        startpos = transform.position;
    }
    private void Update()
    {
        pickupDistance = Vector3.Distance(player.transform.position, transform.position);

        if(pickupDistance <=2)
        {
            if(Input.GetKeyDown(KeyCode.E)&&itemPickup == false && PickupPoint.childCount < 1)
            {
                GetComponent<Rigidbody>().useGravity = false;
                GetComponent<BoxCollider>().enabled = false;
                this.transform.position = PickupPoint.position;
                this.transform.parent = PickupPoint;

                itemPickup = true;
            }
        }

        if(Input.GetKeyUp(KeyCode.E) && itemPickup == true)
        {
            this.transform.parent = null;
            GetComponent<Rigidbody>().useGravity = true;
            GetComponent<BoxCollider>().enabled = true;
            itemPickup = false;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Dead"))
        {
            transform.position = startpos;
        }
    }


}
