using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ymove_R : MonoBehaviour
{
    public GameObject y1;

    public float Enenmeysd;
    public float maxY, minY;

    private int y1dir = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        y1move();
    }
    void y1move()
    {
        y1.transform.position += new Vector3(0, Enenmeysd * Time.deltaTime * y1dir, 0);
        if (y1.transform.position.y >= maxY || y1.transform.position.y <= minY)
        {
            y1dir *= -1;
        }
    }
}
