using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialBox : MonoBehaviour
{
    public GameObject mbox_1;
    public GameObject map2;
    
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject == mbox_1)
        {
            map2.SetActive(true);
        }
    }
}
