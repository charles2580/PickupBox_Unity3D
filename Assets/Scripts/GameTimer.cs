using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameTimer : MonoBehaviour
{
    public GameObject t;
    public GameObject help;
    public static float time = 303.0f;
    [SerializeField] Text timetext;

    Mission1 mission1;
    // Start is called before the first frame update
    void Start()
    {
        timetext.text = time.ToString();
        mission1 = help.GetComponent<Mission1>();
        t.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        startTimer();
    }

    public void startTimer()
    {
        if(mission1.is_start == true)
        {
            t.SetActive(true);
            time -= Time.deltaTime;
           
            int minutes = Mathf.FloorToInt(time / 60);
            int seconds = Mathf.FloorToInt(time - minutes * 60);
            timetext.text = string.Format("Time {0:0}:{1:00}", minutes, seconds);
        }

        if(time<=0)
        {
            t.SetActive(false);
            SceneManager.LoadScene(3);
        }
    }
}
