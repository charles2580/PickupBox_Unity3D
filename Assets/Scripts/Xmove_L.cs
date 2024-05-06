using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Xmove_L : MonoBehaviour
{
    public GameObject e1;
    public float Enenmeysd;
    public float maxX, minX;

    private int e1dir = -1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        e1move();
        
    }

    void e1move()
    {
        e1.transform.position += new Vector3(Enenmeysd * Time.deltaTime * e1dir, 0, 0);
        if (e1.transform.position.x >= maxX || e1.transform.position.x <= minX)
        {
            e1dir *= -1;
        }
    }


}
