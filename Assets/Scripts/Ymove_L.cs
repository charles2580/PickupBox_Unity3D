using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ymove_L : MonoBehaviour
{
    public GameObject y2;
    public float Enenmeysd;
    public float maxY, minY;
    private int y2dir = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        y2move();
    }

    void y2move()
    {
        y2.transform.position += new Vector3(0, Enenmeysd * Time.deltaTime * y2dir, 0);
        if (y2.transform.position.y >= maxY || y2.transform.position.y <= minY)
        {
            y2dir *= -1;
        }
    }

    
}
