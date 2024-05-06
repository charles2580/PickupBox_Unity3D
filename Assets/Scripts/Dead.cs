using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dead : MonoBehaviour
{
    public GameObject Heart1;
    public GameObject Heart2;
    public GameObject Heart3;

    public GameObject player;
    public static int h_count = 3;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            switch (h_count)
            {
                case 3:
                    h_count = 2;
                    break;
                case 2:
                    h_count = 1;
                    break;
                case 1:
                    h_count = 0;
                    break;
            }
        }
    }

    private void Update()
    {
        HeartCheck();
    }
    public void HeartCheck()
    {
        switch (h_count)
        {
            case 3:
                Heart1.SetActive(true);
                Heart2.SetActive(true);
                Heart3.SetActive(true);
                break;
            case 2:
                Heart1.SetActive(true);
                Heart2.SetActive(true);
                Heart3.SetActive(false);
                break;
            case 1:
                Heart1.SetActive(true);
                Heart2.SetActive(false);
                break;
            case 0:
                Heart1.SetActive(false);
                SceneManager.LoadScene(3);
                break;
        }
    }
    
    
}
