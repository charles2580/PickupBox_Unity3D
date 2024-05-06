using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSound : MonoBehaviour
{
    public GameObject enemeyhit;

    private void OnTriggerEnter(Collider other)
    {
        GameObject clone = Instantiate(enemeyhit);
        Destroy(clone);
    }
}
