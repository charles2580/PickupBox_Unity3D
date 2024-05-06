using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BestScore : MonoBehaviour
{
    public static int best = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bestScore();
    }
    public void bestScore()
    {
        if (best < PlayerPrefs.GetInt("Best_Score"))
        {
            best = PlayerPrefs.GetInt("Best_Score");
        }
    }
}
