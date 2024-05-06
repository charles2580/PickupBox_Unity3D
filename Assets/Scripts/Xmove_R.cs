using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Xmove_R : MonoBehaviour
{
    public GameObject e2;
    public float Enenmeysd;
    public float maxX, minX;


    private int e2dir = 1;
    private void Start()
    {

    }
    private void Update()
    {
        e2move();
    }

    void e2move()
    {
        e2.transform.position += new Vector3(Enenmeysd * Time.deltaTime * e2dir, 0, 0);
        if (e2.transform.position.x >= maxX || e2.transform.position.x <= minX)
        {
            e2dir *= -1;
        }
    }
}
